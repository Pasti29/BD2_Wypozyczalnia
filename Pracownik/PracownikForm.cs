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

        // Tutaj zmienne jakie ma zawierać okno obiekt PracownikForm
        private Button _currentPressedButton;

        /// <summary>
        /// Konstruktor PracownikForm
        /// </summary>
        public PracownikForm()
        {
            InitializeComponent();
        }


        // Metody

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
                    control.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
            }
        }

        /// <summary>
        /// Metoda wyróżniająca przycisk
        /// </summary>
        private void ActiveButton(Object eventSender)
        {

            if (eventSender != null)
            {
                // Sprawdzamy, czy przycisk nie jest już wyróżniony
                if (_currentPressedButton != (Button)eventSender)
                {
                    DisableButtons();
                    // Aktualizujemy _currentPressedButton
                    _currentPressedButton = (Button)eventSender;

                    // Ustawianie jego nadzwyczajnych parametrów
                    _currentPressedButton.BackColor = Color.FromArgb(44, 44, 166);
                    _currentPressedButton.ForeColor = Color.White;
                    _currentPressedButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnKatalogSamochodow_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnModyfikowanieKat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnDodajUzytkownika_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnWyloguj_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
    }

     

    
}
