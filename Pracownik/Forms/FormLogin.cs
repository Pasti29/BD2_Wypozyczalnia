using Pracownik.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pracownik.Forms
{
    public partial class FormLogin : Form
    {
        private readonly PracownikForm pracownikForm;

        public FormLogin(PracownikForm pracownikForm)
        {
            this.pracownikForm = pracownikForm;
            InitializeComponent();
            if (Repository.IsConnectionOpened())
            {
                IsLogged();
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxUser.Text.Equals(string.Empty) || TextBoxPassword.Text.Equals(string.Empty))
            {
                LabelConnectionStatus.Visible = true;
                LabelConnectionStatus.ForeColor = Color.Red;
                LabelConnectionStatus.Text = "Nie wpisano wszystkich danych";
                return;
            }

            string user = TextBoxUser.Text;
            string password = TextBoxPassword.Text;

            if (!Repository.OpenConnection(user, password))
            {
                LabelConnectionStatus.Visible = true;
                LabelConnectionStatus.ForeColor = Color.Red;
                LabelConnectionStatus.Text = "Niepoprawne dane";
                return;
            }

            string? role = Repository.GetCurrentUserRole();

            if (role != "Pracownik")
            {
                Repository.CloseConnection();
                LabelConnectionStatus.Visible = true;
                LabelConnectionStatus.ForeColor = Color.Blue;
                LabelConnectionStatus.Text = "To jest aplikacja pracownicza\n" +
                                             "Klient nie może się tu zalogować";
                return;
            }

            LabelConnectionStatus.Visible = true;
            LabelConnectionStatus.ForeColor = Color.Green;
            LabelConnectionStatus.Text = "Zalogowano";
            IsLogged();
            pracownikForm.Login();
        }

        private void IsLogged()
        {
            LabelLogged.Visible = true;
            LabelLogged.Text = "Jesteś już zalogowany";
            TextBoxUser.Enabled = false;
            TextBoxPassword.Enabled = false;
            ButtonLogin.Enabled = false;
        }
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            LabelConnectionStatus.Visible = false;
        }

        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {
            LabelConnectionStatus.Visible = false;
        }
    }
}