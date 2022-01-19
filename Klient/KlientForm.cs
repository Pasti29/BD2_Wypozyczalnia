using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Klient
{
    public partial class KlientForm : Form
    {
        private static SqlConnection? connection;
        private static string? userLogin;
        private Form? activeForm;
        private Button? currentButton;

        public KlientForm()
        {
            InitializeComponent();
        }

        public static SqlConnection? Connection { get => connection; set => connection = value; }
        public static string? UserLogin { get => userLogin; set => userLogin = value; }

        public void ButtonAddOrder_Visible(bool visible)
        {
            ButtonAddOrder.Visible = visible;
        }

        public void ButtonLogin_Visible(bool visible)
        {
            ButtonLogin.Visible = visible;
        }

        public void ButtonLogout_Visible(bool visible)
        {
            ButtonLogout.Visible = visible;
        }

        public void ButtonOrder_Visible(bool visible)
        {
            ButtonOrder.Visible = visible;
        }

        public void ButtonRegister_Visible(bool visible)
        {
            ButtonRegister.Visible = visible;
        }

        public void ReturnToHomePage()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                LabelTitle.Text = "Strona główna";
            }
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

        private void ButtonAddOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddOrder(), sender);
        }

        private void ButtonCatalog_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCatalog(), sender);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLogin(this), sender);
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (Connection != null)
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                    Connection = null;
                    UserLogin = null;
                }
                DisableButton();
                ButtonLogin_Visible(true);
                ButtonRegister_Visible(true);
                ButtonAddOrder_Visible(false);
                ButtonOrder_Visible(false);
                ButtonLogout_Visible(false);
                ReturnToHomePage();
            }
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrder(), sender);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRegister(), sender);
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
    }
}