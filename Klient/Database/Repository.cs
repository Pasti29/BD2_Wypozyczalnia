using System.Data;
using System.Data.SqlClient;

namespace Klient.Database
{
    public class Repository
    {
        private static SqlConnection? connection;
        private static string? userLogin;
        public static SqlConnection? Connection => connection;

        public static void CloseConnection()
        {
            connection?.Close();
            connection = null;
            userLogin = null;
        }

        public static string? GetCurrentUserRole()
        {
            SqlCommand cmd = new("SELECT * FROM dbo.wyswietlRoleUzytkownika()", connection);
            SqlDataAdapter adapter = new(cmd);

            return cmd.ExecuteScalar().ToString();
        }

        public static DataTable GetOrder()
        {
            SqlCommand cmd = new("SELECT * FROM dbo.dajInformacjeOWypozyczeniu(@login)", connection);
            cmd.Parameters.AddWithValue("@login", userLogin);
            SqlDataAdapter adapter = new(cmd);
            DataTable dt = new();
            adapter.Fill(dt);

            return dt;
        }

        public static bool IsConnectionOpened()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        public static bool IsVerified()
        {
            SqlCommand cmd = new("SELECT * FROM dbo.czyZweryfikowany(@login)", connection);
            cmd.Parameters.AddWithValue("@login", userLogin);

            return bool.Parse(cmd.ExecuteScalar().ToString());
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

        public static bool RegisterUser(string login,
                                        string password,
                                        string imie,
                                        string nazwisko,
                                        int nrTelefonu,
                                        string nrPrawaJazdy)
        {
            connection = new(Properties.Resources.RegisterString);
            connection.Open();
            string command = "EXEC dbo.zarejestrujKlienta " +
                             $"{login}, " +
                             $"{password}, " +
                             "Klient, " +
                             $"{imie}, " +
                             $"{nazwisko}, " +
                             $"{nrTelefonu}, " +
                             $"'{nrPrawaJazdy}';";
            SqlCommand cmd = new(command, connection);
            string? status = cmd.ExecuteScalar().ToString();
            connection.Close();
            if (status == "success")
            {
                return true;
            }
            return false;
        }
    }
}