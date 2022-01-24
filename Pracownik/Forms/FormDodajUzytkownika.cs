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
    public partial class FormWeryfikacjaKilentow : Form
    {
        public FormWeryfikacjaKilentow()
        {
            InitializeComponent();

            // Uzupełnienie dataGridView
            dataGridViewUsers.DataSource = Repository.GetClientsToVerify();

            // Edycja parametrów
            dataGridViewUsers.Columns["NrTelefonu"].HeaderText = "Numer telefonu";
            dataGridViewUsers.Columns["NrPrawaJazdy"].HeaderText = "Numer prawa jazdy";
            dataGridViewUsers.Columns["Zweryfikowany"].Visible = false;

            // Formatowanie komórek nagłówkowych
            foreach (DataGridViewColumn col in dataGridViewUsers.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

        }

        private void bntConfirm_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count != 0) {

                DataGridViewRow dataRow = dataGridViewUsers.SelectedRows[0];
                string login = (string)dataRow.Cells["Login"].Value;

                Repository.VerifyClient(login);

                // Odświeżenie siatki
                dataGridViewUsers.DataSource = Repository.GetClientsToVerify();

            }
            
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count != 0)
            {
                DataGridViewRow dataRow = dataGridViewUsers.SelectedRows[0];
                string login = (string)dataRow.Cells["Login"].Value;

                Repository.RejectClient(login);

                // Odświeżenie siatki
                dataGridViewUsers.DataSource = Repository.GetClientsToVerify();

            }
        }

    }
}
