using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownik.Forms
{
    public partial class FormLogowanie : Form
    {
        // Zawiera referencję do PracownikForm, aby mógł używać jego publicznych metod np. Login()
        private PracownikForm _pracownikForm;

        /// <summary>
        /// Konstruktor przyjmujący referencję do PracownikForm (główna forma programu)
        /// </summary>
        /// <param name="pracownikForm"></param>
        public FormLogowanie(PracownikForm pracownikForm)
        {
            InitializeComponent();
            _pracownikForm = pracownikForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _pracownikForm.Login();
        }
    }
}
