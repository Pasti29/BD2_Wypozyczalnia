using Pracownik.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownik
{

    
    public partial class PracownikForm : Form
    {

        // Tutaj zmienne jakie ma zawierać okno obiekt PracownikForm, symbol '?' oznacza, że zmienne mogą przyjmować wartość null,
        // Symbol '_' oznacza, że zmienna jest prywatna

        private Button? _currentPressedButton;
        private Form? _displayedForm;
        private Boolean _isLogged = false;




        /// <summary>
        /// Konstruktor PracownikForm
        /// </summary>
        public PracownikForm()
        {
            InitializeComponent();

            // Na starcie programu będzie wybrana zakładka logowania
            DisableButtons();
            OpenChildForm(new FormLogowanie(this), btnLogowanie);
            
        }




        // ----------------------------------------------------Metody-----------------------------------------------------

        /// <summary>
        /// Metoda przywracająca wszystkie przyciski do stanu pierwotnego
        /// </summary>
        private void DisableButtons()
        {
            foreach (Control control in panelMenu.Controls)
            {
                // Dla każdego przycisku przypientego do panelu 
                if (control.GetType() == typeof(Button)) {

                    
                    // Ustawiamy jego podstawowe parametry
                    control.BackColor = Color.FromArgb(51, 51, 76);
                    control.ForeColor = Color.White;
                    control.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    control.Enabled = true;
                    control.Visible = true;

                    // Jeśli użytkownik nie będzie zalogowany - wybrane przyciski będą ukryte
                    if (((control == btnModyfikowanieKat) || (control == btnDodajUzytkownika) || (control == btnWyloguj)||(control == btnHistoriaWypozyczen)) && (!_isLogged))
                    {
                        control.Visible = false;
                    }
                }
            }
        }

        /// <summary>
        /// Metoda wyróżniająca przycisk
        /// </summary>
        private void ActiveButton(Object? eventSender)
        {

            if (eventSender != null)
            {
                // Sprawdzamy, czy przycisk nie jest już wyróżniony
                if (_currentPressedButton != (Button)eventSender)
                {
                    // Przywrócenie przycisków do początkowego wyglądu
                    DisableButtons();
                    // Aktualizujemy _currentPressedButton
                    _currentPressedButton = (Button)eventSender;

                    // Ustawianie jego nadzwyczajnych parametrów
                    _currentPressedButton.BackColor = Color.FromArgb(0, 150, 136);
                    _currentPressedButton.ForeColor = Color.White;
                    _currentPressedButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
            }
            
        }

        /// <summary>
        /// Metoda zmieniająca zawartość główego panela (panelContent) na podstawie klikniętego przycisku 
        /// </summary>
        /// <param name="childForm"></param>
        /// <param name="btnSender"></param>
        private void OpenChildForm(Form childForm, object btnSender) {

            // Zamykamy wcześniejszą formę, jeśli jeszcze nie zostało to zrobione
            if (_displayedForm != null) {

                _displayedForm.Close();
            }
            // Wyróżniamy kliknięty przycisk
            ActiveButton(btnSender);

            // Ustawienie nowego kontentu
            _displayedForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

            // Zmiana nagłówka w zależności od wyświetlanej zawartości 
            lblTitle.Text = childForm.Text;
        }

        /// <summary>
        /// Metoda logująca użytkownika
        /// </summary>
        public void Login() 
        {
            _isLogged = true;
            // Ustawiamy na null, aby zakładki ponownie się wygenerowały, ponieważ jeśli _currentPressedButton == btnSender (sytuacja,
            // gdy już wcześniej wybraliśmy daną zakładkę) to zakładki nie zmieniają swojego wyglądu i właściwości - my jednak chcemy wymusić
            // ich ponowne wygenerowanie
            _currentPressedButton = null;
            OpenChildForm(new FormLogowanie(this), btnLogowanie);
        }

        private void btnLogowanie_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLogowanie(this), sender);
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            // Zapisanie przycisku, z którego przeszliśmy do zakładki wyloguj 
            Button? previousButton = _currentPressedButton;

            // Wyróżnienie przycisku wyloguj (spowoduje zmianę _currentPressedButton)
            ActiveButton(btnWyloguj);

            // Wyświetlenie komunikatu
            var result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wylogowanie", MessageBoxButtons.YesNo);

            // Obsłużenie wyniku
            if (result == DialogResult.Yes)
            {
                // Wylogowanie
                _isLogged = false;
                // Przejście do zakładki logowania
                OpenChildForm(new FormLogowanie(this), btnLogowanie);
            }
            else 
            {
                ActiveButton(previousButton);
            }
        }

        private void btnKatalogSamochodow_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKatalogSamochodow(), sender);
        }

        private void btnModyfikowanieKat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormModyfikowanieKatalogu(), sender);
        }

        private void btnDodajUzytkownika_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDodajUzytkownika(), sender);
        }

        private void btnHistoriaWypozyczen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHistoriaWypozyczen(), sender);
        }
    }

     

    
}
