using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klient.Database;

namespace Klient.Forms
{
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
            MonthCalendarDataOddania.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);

            if (Repository.GetOrder().Rows.Count > 0)
            {
                HasOrder();
                return;
            }

            DataTable dt = Repository.GetAvailableCars();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s = dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][2].ToString() + " " + dt.Rows[i][3]; 
                ListBoxCars.Items.Add(s);
            }
        }

        private void HasOrder()
        {
            LabelHaveOrder.Visible = true;
            ListBoxCars.Enabled = false;
            MonthCalendarDataOddania.Enabled = false;
            ButtonAddOrder.Enabled = false;
        }

        private void ButtonAddOrder_Click(object sender, EventArgs e)
        {
            string? nrRejestracyjny;
            try
            {
                nrRejestracyjny = ListBoxCars.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                LabelStatus.ForeColor = Color.Red;
                LabelStatus.Text = "Nie zaznaczono samochodu";
                LabelStatus.Visible = true;
                return;
            }
            
            nrRejestracyjny = nrRejestracyjny.Substring(0, 7);
            int status = Repository.AddOrder(nrRejestracyjny, MonthCalendarDataOddania.SelectionStart);
            if (status > 0)
            {
                LabelStatus.ForeColor = Color.Green;
                LabelStatus.Text = "Zamówienie dodane";
                LabelStatus.Visible = true;
                HasOrder();
            }
            else
            {
                LabelStatus.ForeColor = Color.Red;
                LabelStatus.Text = "Coś poszło nie tak";
                LabelStatus.Visible = true;
            }
        }
    }
}
