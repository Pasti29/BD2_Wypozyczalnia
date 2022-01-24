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
        /// <summary>
        /// Nawiązanie połączenia z naszą bazą danych zefiniowaną w ConnectionString
        /// </summary>
        private static SqlConnection? connection;
        private static string? userLogin;
        public static SqlConnection? Connection => connection;


        public void AddCar(string carID, int workerID, string brand, string model, bool borrowed, int vintage, float averageConsumption, int maxSpeed, int engineCapacity, DateTime controlDate, Image image)
        {

            connection.Open();
            SqlCommand command = connection.CreateCommand();

            // Konwertowanie obrazu na bajty
            var convertedImage = new ImageConverter().ConvertTo(image, typeof(Byte[]));
            command.Parameters.AddWithValue("@image", convertedImage);
            
            // Wywołanie procedury dodajSamochod(...)
            command.CommandText = $"EXEC dodajSamochod '{carID}', '{workerID}', '{brand}', '{model}', '{borrowed}', '{vintage}', '{averageConsumption}', '{maxSpeed}', '{engineCapacity}', '{controlDate}', @image ";
            
            // Wykonanie zapytania
            command.ExecuteNonQuery();
            connection.Close();


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
            SqlDataAdapter adapter = new(cmd);

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



        public void UpdateCar(string carID, int workerID, string brand, string model, bool borrowed, int vintage, float averageConsumption, int maxSpeed, int engineCapacity, DateTime controlDate, Image image)
        {

            connection.Open();
            SqlCommand command = connection.CreateCommand();

            // Konwertowanie obrazu na bajty
            var convertedImage = new ImageConverter().ConvertTo(image, typeof(Byte[]));
            command.Parameters.AddWithValue("@image", convertedImage);

            // Wywołanie procedury aktualizujSamochod(...)
            command.CommandText = $"EXEC aktualizujSamochod '{carID}', '{workerID}', '{brand}', '{model}', '{borrowed}', '{vintage}', '{averageConsumption}', '{maxSpeed}', '{engineCapacity}', '{controlDate}', @image ";

            // Wykonanie zapytania
            command.ExecuteNonQuery();
            connection.Close();


        }



        public void DeleteCar(string carID) 
        {
            // Wywołanie procedury usunSamochod
            connection.Open();

            string query = $"EXEC usunSamochod '{carID}'";
            SqlCommand command = new SqlCommand(query, connection);

            // Wywołanie zapytania
            command.ExecuteNonQuery();
            connection.Close();
        }



        public DataRow? GetCar(string carID) 
        {
            //utworzenie zapytania zwracającego informację o samochodzie o danym id
            string query = "SELECT * " +
                           $"FROM Samochody WHERE  IDsamochodu = '{carID}';";

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



        public DataRow? GetWorker(int IDpracownika) 
        {
            // Wywołani funkcji tabelarycznej wyszukajPracownika(IDpracownika)
            string query = "SELECT * " +
                           $"FROM dbo.wyszukajPracownika('{IDpracownika}');";

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


        public static DataTable GetCarsTable()
        {
            if (!IsConnectionOpened())
            {
                connection = new(Properties.Resources.GuestString);
                connection.Open();
            }

            string query = "SELECT * from dbo.wyswietlSamochody()";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (connection.WorkstationId.Equals("guest"))
            {
                connection.Close();
            }

            return dt;
        }
    }
}
