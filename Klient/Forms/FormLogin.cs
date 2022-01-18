using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient.Forms
{

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxUser.Text.Equals(String.Empty) || TextBoxPassword.Text.Equals(String.Empty))
            {
                MessageBox.Show("Nie wpisano danych!", "Błąd");
            } else
            {
                String user = TextBoxUser.Text;
                String password = TextBoxPassword.Text;
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder("Data Source=LEGIO;Initial Catalog=WypozyczalniaSamochodow");
                builder.UserID = user;
                builder.Password = password;
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Źle wpisałeś dane!", "Błąd");
                }
                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Połączenie nawiązane", "Udało się");
                    connection.Close();
                }
                //if (connection.State != ConnectionState.Open)
                //{
                //    MessageBox.Show("Źle wpisałeś dane!", "Błąd");
                //}
                //else
                //{
                //    connection.Close();
                //}
            }
            //Close();
            
        }
    }
}
