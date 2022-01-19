using System.Data;
using System.Data.SqlClient;
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

            SqlCommand cmd = new("SELECT * FROM dbo.dajInformacjeOWypozyczeniu(@login)", KlientForm.Connection);
            cmd.Parameters.AddWithValue("@login", KlientForm.UserLogin);
            SqlDataAdapter adapter = new(cmd);
            DataTable dt = new();
            adapter.Fill(dt);

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