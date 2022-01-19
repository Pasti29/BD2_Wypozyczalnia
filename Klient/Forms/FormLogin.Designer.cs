namespace Klient.Forms
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.LabelLogged = new System.Windows.Forms.Label();
            this.LabelConnectionStatus = new System.Windows.Forms.Label();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.PanelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.Controls.Add(this.LabelLogged);
            this.PanelDesktop.Controls.Add(this.LabelConnectionStatus);
            this.PanelDesktop.Controls.Add(this.TextBoxUser);
            this.PanelDesktop.Controls.Add(this.ButtonLogin);
            this.PanelDesktop.Controls.Add(this.TextBoxPassword);
            this.PanelDesktop.Controls.Add(this.LabelUser);
            this.PanelDesktop.Controls.Add(this.LabelPassword);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(0, 0);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(412, 159);
            this.PanelDesktop.TabIndex = 0;
            // 
            // LabelLogged
            // 
            this.LabelLogged.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLogged.AutoSize = true;
            this.LabelLogged.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLogged.Location = new System.Drawing.Point(136, 9);
            this.LabelLogged.Name = "LabelLogged";
            this.LabelLogged.Size = new System.Drawing.Size(128, 17);
            this.LabelLogged.TabIndex = 6;
            this.LabelLogged.Text = "#Czy zalogowany?#";
            this.LabelLogged.Visible = false;
            // 
            // LabelConnectionStatus
            // 
            this.LabelConnectionStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelConnectionStatus.Location = new System.Drawing.Point(223, 96);
            this.LabelConnectionStatus.Name = "LabelConnectionStatus";
            this.LabelConnectionStatus.Size = new System.Drawing.Size(182, 23);
            this.LabelConnectionStatus.TabIndex = 5;
            this.LabelConnectionStatus.Text = "#Status połączenia#";
            this.LabelConnectionStatus.Visible = false;
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxUser.Location = new System.Drawing.Point(136, 32);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(269, 25);
            this.TextBoxUser.TabIndex = 2;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonLogin.Location = new System.Drawing.Point(136, 91);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(81, 27);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Zaloguj się";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxPassword.Location = new System.Drawing.Point(136, 60);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(269, 25);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // LabelUser
            // 
            this.LabelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelUser.AutoSize = true;
            this.LabelUser.Location = new System.Drawing.Point(7, 32);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(120, 17);
            this.LabelUser.TabIndex = 0;
            this.LabelUser.Text = "Nazwa użytkownika";
            // 
            // LabelPassword
            // 
            this.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(86, 63);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(41, 17);
            this.LabelPassword.TabIndex = 1;
            this.LabelPassword.Text = "Hasło";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 159);
            this.Controls.Add(this.PanelDesktop);
            this.Name = "FormLogin";
            this.Text = "Zaloguj się";
            this.PanelDesktop.ResumeLayout(false);
            this.PanelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label LabelConnectionStatus;
        private System.Windows.Forms.Label LabelLogged;
    }
}