using System.Data;
using System.Data.SqlClient;

namespace Klient.Database
{
    public class Repository
    {
        private static SqlConnectionStringBuilder? builder;
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
            DataTable dt = new();
            adapter.Fill(dt);

            return dt.Rows[0][0].ToString();
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

        public static bool OpenConnection(string user, string password)
        {
            builder = new(Properties.Resources.ConnectionString)
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
    }
}