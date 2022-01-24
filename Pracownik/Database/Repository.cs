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
        private readonly SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);


        public void AddCar(string carID, int workerID, string brand, string model, bool borrowed, int vintage, float averageConsumption, int maxSpeed, int engineCapacity, DateTime controlDate, Image image)
        {

            _connection.Open();
            SqlCommand command = _connection.CreateCommand();

            // Konwertowanie obrazu na bajty
            var convertedImage = new ImageConverter().ConvertTo(image, typeof(Byte[]));
            command.Parameters.AddWithValue("@image", convertedImage);
            
            // Wywołanie procedury dodajSamochod(...)
            command.CommandText = $"EXEC dodajSamochod '{carID}', '{workerID}', '{brand}', '{model}', '{borrowed}', '{vintage}', '{averageConsumption}', '{maxSpeed}', '{engineCapacity}', '{controlDate.ToString("MM/dd/yyyy")}', @image ";
            
            // Wykonanie zapytania
            command.ExecuteNonQuery();
            _connection.Close();


        }



        public void UpdateCar(string carID, int workerID, string brand, string model, bool borrowed, int vintage, float averageConsumption, int maxSpeed, int engineCapacity, DateTime controlDate, Image image)
        {

            _connection.Open();
            SqlCommand command = _connection.CreateCommand();

            // Konwertowanie obrazu na bajty
            var convertedImage = new ImageConverter().ConvertTo(image, typeof(Byte[]));
            command.Parameters.AddWithValue("@image", convertedImage);

            // Wywołanie procedury aktualizujSamochod(...)
            command.CommandText = $"EXEC aktualizujSamochod '{carID}', '{workerID}', '{brand}', '{model}', '{borrowed}', '{vintage}', '{averageConsumption}', '{maxSpeed}', '{engineCapacity}', '{controlDate}', @image ";

            // Wykonanie zapytania
            command.ExecuteNonQuery();
            _connection.Close();


        }

        public DataTable GetAllOrders()
        {
            //utworzenie zapytania wywołującego funkcję wyswietlHistorieZamowien
            string query = "SELECT * " +
                           "FROM wyswietlHistorieZamowien();";


            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public void DeleteCar(string carID) 
        {
            // Wywołanie procedury usunSamochod
            _connection.Open();

            string query = $"EXEC usunSamochod '{carID}'";
            SqlCommand command = new SqlCommand(query, _connection);

            // Wywołanie zapytania
            command.ExecuteNonQuery();
            _connection.Close();
        }



        public DataRow? GetCar(string carID) 
        {
            //wywołanie funkcji wyszukajSamochod(IDsamochodu)
            string query = "SELECT * " +
                           $"FROM wyszukajSamochod('{carID}');";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
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

            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
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


        public DataTable GetCarsTable() {

            //utworzenie zapytania
            string query = "SELECT * " +
                           "FROM Samochody ;";


            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
