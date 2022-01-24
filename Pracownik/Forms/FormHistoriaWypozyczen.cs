using Pracownik.Database;
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
    public partial class FormHistoriaWypozyczen : Form
    {
        public FormHistoriaWypozyczen()
        {
            InitializeComponent();
            // Załadowanie danych do DataGridView
            dataGridViewOrders.DataSource = Repository.GetAllOrders();

            // Nadanie nazw kolumną
            dataGridViewOrders.Columns["IDzamowienia"].HeaderText = "ID Zamówienia";
            dataGridViewOrders.Columns["LoginKlienta"].HeaderText = "Login klienta";
            dataGridViewOrders.Columns["NrRejestracyjny"].HeaderText = "Rejestracja samochodu";
            dataGridViewOrders.Columns["DataWypozyczenia"].HeaderText = "Data wypożyczenia";
            dataGridViewOrders.Columns["DataOddania"].HeaderText = "Data oddania";
            dataGridViewOrders.Columns["Oplata"].HeaderText = "Naliczona opłata";

            // Formatowanie komórek nagłówkowych
            foreach (DataGridViewColumn col in dataGridViewOrders.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }


        }

    }
}
