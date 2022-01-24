using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Pracownik.Database
{
    public class Repository
    {
        
        private static SqlConnection? connection;
        private static string? userLogin;
        //public static SqlConnection? Connection => connection;


        public void AddCar(string registrationNumber, string workerLogin, string brand, string model, int vintage, float averageConsumption, int maxSpeed, int engineCapacity, DateTime controlDate, Image image)
        {
            if (connection != null) 
            {
                //connection.Open();

                SqlCommand command = connection.CreateCommand();

                // Konwertowanie obrazu na bajty
                var convertedImage = new ImageConverter().ConvertTo(image, typeof(Byte[]));
                command.Parameters.AddWithValue("@image", convertedImage);

                // Wywołanie procedury dodajSamochod(...)
                command.CommandText = $"EXEC dodajSamochod '{registrationNumber}', '{workerLogin}', '{brand}', '{model}', '{vintage}', '{averageConsumption}', '{maxSpeed}', '{engineCapacity}', '{controlDate.ToString("MM/dd/yyyy")}', @image ";

                // Wykonanie zapytania
                command.ExecuteNonQuery();

                //connection.Close();
           }
        }

        public static void CloseConnection()
        {
            connection?.Close();
            connection = null;
            userLogin = null;
        }

        public static bool IsConnectionOpened()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        public static string? GetCurrentUserRole()
        {
            SqlCommand cmd = new("SELECT * FROM dbo.wyswietlRoleUzytkownika()", connection);
            //SqlDataAdapter adapter = new(cmd);

            return cmd.ExecuteScalar().ToString();
        }

        public static bool OpenConnection(string user, string password)
        {
            SqlConnectionStringBuilder builder = new(Properties.Resources.ConnectionString)
            {
                UserID = user,
                Password = password
            };
            connection = new(builder.ConnectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException)
            {
                return false;
            }
            userLogin = user;
            return true;
        }

        public static DataTable GetCarsTable()
        {
            bool guest = false;
            if (!IsConnectionOpened())
            {
                connection = new(Properties.Resources.GuestString);
                connection.Open();
                guest = true;
            }

            string query = "SELECT * from dbo.wyswietlSamochody()";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (guest)
            {
                connection.Close();
            }
            return dt;
        }





        public void UpdateCar(string registrationNumber, string workerLogin, string brand, string model, int vintage, float averageConsumption, int maxSpeed, int engineCapacity, DateTime controlDate, Image image)
        {
            if (connection != null) {

                //connection.Open();
                SqlCommand command = connection.CreateCommand();

                // Konwertowanie obrazu na bajty
                var convertedImage = new ImageConverter().ConvertTo(image, typeof(Byte[]));
                command.Parameters.AddWithValue("@image", convertedImage);

                // Wywołanie procedury aktualizujSamochod(...)
                command.CommandText = $"EXEC aktualizujSamochod '{registrationNumber}', '{workerLogin}', '{brand}', '{model}', '{vintage}', '{averageConsumption}', '{maxSpeed}', '{engineCapacity}', '{controlDate}', @image ";

                // Wykonanie zapytania
                command.ExecuteNonQuery();
                //connection.Close();

            }
        }

        public DataTable GetAllOrders()
        {
            //utworzenie zapytania wywołującego funkcję wyswietlHistorieZamowien
            string query = "SELECT * " +
                           "FROM wyswietlHistorieZamowien();";


            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public void DeleteCar(string registrationNumber) 
        {
            if (connection != null) 
            {
                // Wywołanie procedury usunSamochod
                //connection.Open();

                string query = $"EXEC usunSamochod '{registrationNumber}'";
                SqlCommand command = new SqlCommand(query, connection);

                // Wywołanie zapytania
                command.ExecuteNonQuery();
                //connection.Close();
            }
            
        }



        public DataRow? GetCar(string registrationNumber) 
        {
            //wywołanie funkcji wyszukajSamochod(NrRejestracji)
            string query = "SELECT * " +
                           $"FROM dbo.wyszukajSamochod('{registrationNumber}');";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count != 0)
            {
                return table.Rows[0];
            }
            else 
            {
                return null;
            }
        }



        public DataRow? GetWorker(string workerLogin) 
        {
            // Wywołani funkcji tabelarycznej wyszukajPracownika(IDpracownika)
            string query = "SELECT * " +
                           $"FROM dbo.wyszukajPracownika('{workerLogin}');";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count != 0)
            {
                return table.Rows[0];
            }
            else
            {
                return null;
            }
        }
    }
}
