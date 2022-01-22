using System;
using System.Drawing;
using System.Windows.Forms;
using Klient.Database;

namespace Klient.Forms
{
    public partial class FormLogin : Form
    {

        private readonly KlientForm klientForm;

        public FormLogin(KlientForm klientForm)
        {
            this.klientForm = klientForm;
            InitializeComponent();
            if (Repository.IsConnectionOpened())
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
            if (TextBoxUser.Text.Equals(string.Empty) || TextBoxPassword.Text.Equals(string.Empty))
            {
                LabelConnectionStatus.Visible = true;
                LabelConnectionStatus.ForeColor = Color.Red;
                LabelConnectionStatus.Text = "Nie wpisano wszystkich danych";
            }
            else
            {
                string user = TextBoxUser.Text;
                string password = TextBoxPassword.Text;
                if (Repository.OpenConnection(user, password))
                {
                    string? role = Repository.GetCurrentUserRole();
                    if (role == "Klient")
                    {
                        LabelConnectionStatus.Visible = true;
                        LabelConnectionStatus.ForeColor = Color.Green;
                        LabelConnectionStatus.Text = "Zalogowano";
                        IsLogged();
                        klientForm.ButtonLogin_Visible(false);
                        klientForm.ButtonRegister_Visible(false);
                        klientForm.ButtonAddOrder_Enable(true);
                        klientForm.ButtonOrder_Enable(true);
                        klientForm.ButtonLogout_Visible(true);
                    }
                    else
                    {
                        Repository.CloseConnection();
                        LabelConnectionStatus.Visible = true;
                        LabelConnectionStatus.ForeColor = Color.Blue;
                        LabelConnectionStatus.Text = "To jest aplikacja kliencka\n" +
                                                     "Pracownik nie może się tu zalogować";
                    }
                }
                else
                {
                    LabelConnectionStatus.Visible = true;
                    LabelConnectionStatus.ForeColor = Color.Red;
                    LabelConnectionStatus.Text = "Niepoprawne dane";
                }
            }
        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {
            LabelConnectionStatus.Visible = false;
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            LabelConnectionStatus.Visible = false;
        }
    }
}