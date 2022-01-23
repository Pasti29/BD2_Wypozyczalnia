using Klient.Database;
using System.Data;
using System.Windows.Forms;

namespace Klient.Forms
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();

            TextBox[] TextBoxesInOrder =
            {
                TextBoxNrRejestracyjny,
                TextBoxMarka,
                TextBoxModel,
                TextBoxRocznik,
                TextBoxSrednieSpalanie,
                TextBoxPredkoscMAX,
                TextBoxPojemnoscSilnika,
                TextBoxDataWypoczyczenia,
                TextBoxDataOddania,
                TextBoxOplata
            };

            DataTable dt = Repository.GetOrder();

            if (dt.Rows.Count == 0)
            {
                LabelNoOrder.Visible = true;
            }
            else
            {
                int i = 0;
                foreach (TextBox textBox in TextBoxesInOrder)
                {
                    if (i == 7 || i == 8)
                    {
                        textBox.Text = dt.Rows[0][i].ToString().Substring(0, 10);
                    }
                    else
                    {
                        textBox.Text = dt.Rows[0][i].ToString();
                    }
                    i++;
                }
            }
        }
    }
}