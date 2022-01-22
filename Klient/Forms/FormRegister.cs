using Klient.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Klient.Forms
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text.Equals(string.Empty)
                || TextBoxPassword.Text.Equals(string.Empty)
                || TextBoxImie.Text.Equals(string.Empty)
                || TextBoxNazwisko.Text.Equals(string.Empty)
                || MaskedTextBoxNrTelefonu.Text.Equals(string.Empty)
                || MaskedTextBoxNrPrawaJazdy.Text.Equals(string.Empty))
            {
                LabelStatus.Visible = true;
                LabelStatus.ForeColor = Color.Red;
                LabelStatus.Text = "Nie wpisano wszystkich danych";
                return;
            }

            string login = TextBoxLogin.Text;
            string password = TextBoxPassword.Text;
            string imie = TextBoxImie.Text;
            string nazwisko = TextBoxNazwisko.Text;

            int nrTelefonu = int.Parse(MaskedTextBoxNrTelefonu.Text);
            if (nrTelefonu.ToString().Length < 9)
            {
                LabelStatus.Visible = true;
                LabelStatus.ForeColor = Color.Red;
                LabelStatus.Text = "Wpisano nieprawidłowe dane w polu Nr telefonu";
                return;
            }

            string nrPrawaJazdy = MaskedTextBoxNrPrawaJazdy.Text;
            if (nrPrawaJazdy.Length < 13)
            {
                LabelStatus.Visible = true;
                LabelStatus.ForeColor = Color.Red;
                LabelStatus.Text = "Wpisano nieprawidłowe dane w polu Nr prawa jazdy";
                return;
            }

            if (Repository.RegisterUser(login, password, imie, nazwisko, nrTelefonu, nrPrawaJazdy))
            {
                LabelStatus.Visible = true;
                LabelStatus.ForeColor = Color.Green;
                LabelStatus.Text = "Konto zostało utworzone" +
                                   "Poczekaj aż pracownik zatwierdzi twoje konto";
            }
            else
            {
                LabelStatus.Visible = true;
                LabelStatus.ForeColor = Color.Red;
                LabelStatus.Text = "Takie konto już istnieje";
            }
        }
    }
}