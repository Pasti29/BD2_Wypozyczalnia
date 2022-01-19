using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Klient.Forms
{
    public partial class FormLogin : Form
    {

        private readonly KlientForm klientForm;

        public FormLogin(KlientForm klientForm)
        {
            this.klientForm = klientForm;
            InitializeComponent();
            if (KlientForm.Connection != null && KlientForm.Connection.State == ConnectionState.Open)
            {
                IsLogged();
            }
        }

        private void IsLogged()
        {
            LabelLogged.Visible = true;
            LabelLogged.Text = "Jesteś już zalogowany";
            TextBoxUser.Enabled = false;
            TextBoxPassword.Enabled = false;
            ButtonLogin.Enabled = false;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxUser.Text.Equals(String.Empty) || TextBoxPassword.Text.Equals(String.Empty))
            {
                LabelConnectionStatus.Visible = true;
                LabelConnectionStatus.ForeColor = Color.Red;
                LabelConnectionStatus.Text = "Nie wpisano wszystkich danych";
            }
            else
            {
                string user = TextBoxUser.Text;
                SqlConnectionStringBuilder builder = new(Resource.ConnectionString)
                {
                    UserID = user,
                    Password = TextBoxPassword.Text
                };
                KlientForm.Connection = new SqlConnection(builder.ConnectionString);
                try
                {
                    KlientForm.Connection.Open();
                }
                catch (SqlException)
                {
                    LabelConnectionStatus.Visible = true;
                    LabelConnectionStatus.ForeColor = Color.Red;
                    LabelConnectionStatus.Text = "Niepoprawne dane";
                }
                if (KlientForm.Connection.State == ConnectionState.Open)
                {
                    KlientForm.UserLogin = TextBoxUser.Text;
                    LabelConnectionStatus.Visible = true;
                    LabelConnectionStatus.ForeColor = Color.Green;
                    LabelConnectionStatus.Text = "Zalogowano";
                    IsLogged();
                    klientForm.ButtonLogin_Visible(false);
                    klientForm.ButtonRegister_Visible(false);
                    klientForm.ButtonAddOrder_Visible(true);
                    klientForm.ButtonOrder_Visible(true);
                    klientForm.ButtonLogout_Visible(true);
                }
            }
        }
    }
}