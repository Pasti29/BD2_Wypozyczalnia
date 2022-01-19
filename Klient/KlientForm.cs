using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Klient
{
    public partial class KlientForm : Form
    {
        private Form? activeForm;
        private Button? currentButton;
        static public SqlConnection? connection;

        public KlientForm()
        {
            InitializeComponent();
            ButtonLogout.Enabled = false;
        }

        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    DisableButton();
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = Color.FromArgb(170, 164, 255);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(50, 52, 77);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object buttonSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(buttonSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            LabelTitle.Text = childForm.Text;
        }

        public void ReturnToStart()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                DisableButton();
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.FormLogin(), sender);
        }

        private void ButtonCatalog_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                ActivateButton(sender);
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}