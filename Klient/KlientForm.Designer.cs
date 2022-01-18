namespace Klient
{
    partial class KlientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonCatalog = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.LabelLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.ButtonLogout);
            this.panelMenu.Controls.Add(this.ButtonCatalog);
            this.panelMenu.Controls.Add(this.ButtonLogin);
            this.panelMenu.Controls.Add(this.PanelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 681);
            this.panelMenu.TabIndex = 1;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLogout.FlatAppearance.BorderSize = 0;
            this.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogout.Location = new System.Drawing.Point(0, 240);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(220, 80);
            this.ButtonLogout.TabIndex = 3;
            this.ButtonLogout.Text = "Wyloguj się";
            this.ButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonCatalog
            // 
            this.ButtonCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCatalog.FlatAppearance.BorderSize = 0;
            this.ButtonCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCatalog.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCatalog.Location = new System.Drawing.Point(0, 160);
            this.ButtonCatalog.Name = "ButtonCatalog";
            this.ButtonCatalog.Size = new System.Drawing.Size(220, 80);
            this.ButtonCatalog.TabIndex = 2;
            this.ButtonCatalog.Text = "Wyświetl katalog";
            this.ButtonCatalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCatalog.UseVisualStyleBackColor = true;
            this.ButtonCatalog.Click += new System.EventHandler(this.ButtonCatalog_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogin.Location = new System.Drawing.Point(0, 80);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(220, 80);
            this.ButtonLogin.TabIndex = 1;
            this.ButtonLogin.Text = "Zaloguj się";
            this.ButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(114)))), ((int)(((byte)(178)))));
            this.PanelLogo.Controls.Add(this.LabelLogo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 80);
            this.PanelLogo.TabIndex = 0;
            // 
            // LabelLogo
            // 
            this.LabelLogo.AutoSize = true;
            this.LabelLogo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLogo.ForeColor = System.Drawing.Color.White;
            this.LabelLogo.Location = new System.Drawing.Point(38, 15);
            this.LabelLogo.Name = "LabelLogo";
            this.LabelLogo.Size = new System.Drawing.Size(144, 50);
            this.LabelLogo.TabIndex = 0;
            this.LabelLogo.Text = "Wypożyczalnia\r\nsamochodów";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.LabelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1044, 80);
            this.panelTitleBar.TabIndex = 2;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(438, 24);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(167, 32);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Strona główna";
            // 
            // KlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "KlientForm";
            this.Text = "Klient";
            //this.Load += new System.EventHandler(this.KlientForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ButtonCatalog;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelLogo;
    }
}
