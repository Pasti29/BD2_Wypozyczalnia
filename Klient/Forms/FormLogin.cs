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
            if (KlientForm.connection != null && KlientForm.connection.State == ConnectionState.Open)
            {
                LabelLogged.Visible = true;
                LabelLogged.Text = "Jesteś już zalogowany";
                TextBoxUser.Enabled = false;
                TextBoxPassword.Enabled = false;
                ButtonLogin.Enabled = false;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxUser.Text.Equals(String.Empty) || TextBoxPassword.Text.Equals(String.Empty))
            {
                LabelConnectionStatus.Visible = true;
                LabelConnectionStatus.ForeColor = Color.Red;
                LabelConnectionStatus.Text = "Nie wpisano danych";
            }
            else
            {
                String user = TextBoxUser.Text;
                String password = TextBoxPassword.Text;
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Resource.ConnectionString);
                builder.UserID = user;
                builder.Password = password;
                KlientForm.connection = new SqlConnection(builder.ConnectionString);
                try
                {
                    KlientForm.connection.Open();
                }
                catch (SqlException ex)
                {
                    LabelConnectionStatus.Visible = true;
                    LabelConnectionStatus.ForeColor = Color.Red;
                    LabelConnectionStatus.Text = "Dane niepoprawne";
                }
                if (KlientForm.connection.State == ConnectionState.Open)
                {
                    LabelConnectionStatus.Visible = true;
                    LabelConnectionStatus.ForeColor = Color.Green;
                    LabelConnectionStatus.Text = "Zalogowany";
                }
            }
        }
    }
}
