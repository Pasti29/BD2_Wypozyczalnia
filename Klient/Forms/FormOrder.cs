using System.Data;
using System.Windows.Forms;
using Klient.Database;

namespace Klient.Forms
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();

            TextBox[] TextBoxesInOrder =
            {
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
                    textBox.Text = dt.Rows[0][i].ToString();
                    i++;
                }
            }
        }
    }
}