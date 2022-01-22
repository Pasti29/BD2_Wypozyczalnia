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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonAddOrder = new System.Windows.Forms.Button();
            this.ButtonOrder = new System.Windows.Forms.Button();
            this.ButtonCatalog = new System.Windows.Forms.Button();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.LabelLogo = new System.Windows.Forms.Label();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.PanelMenu.Controls.Add(this.ButtonAddOrder);
            this.PanelMenu.Controls.Add(this.ButtonOrder);
            this.PanelMenu.Controls.Add(this.ButtonCatalog);
            this.PanelMenu.Controls.Add(this.ButtonLogout);
            this.PanelMenu.Controls.Add(this.ButtonRegister);
            this.PanelMenu.Controls.Add(this.ButtonLogin);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 681);
            this.PanelMenu.TabIndex = 1;
            // 
            // ButtonAddOrder
            // 
            this.ButtonAddOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAddOrder.Enabled = false;
            this.ButtonAddOrder.FlatAppearance.BorderSize = 0;
            this.ButtonAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonAddOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddOrder.Location = new System.Drawing.Point(0, 400);
            this.ButtonAddOrder.Name = "ButtonAddOrder";
            this.ButtonAddOrder.Size = new System.Drawing.Size(220, 80);
            this.ButtonAddOrder.TabIndex = 5;
            this.ButtonAddOrder.Text = "Utwórz nowe wypożyczenie";
            this.ButtonAddOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAddOrder.UseVisualStyleBackColor = true;
            this.ButtonAddOrder.Click += new System.EventHandler(this.ButtonAddOrder_Click);
            // 
            // ButtonOrder
            // 
            this.ButtonOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonOrder.Enabled = false;
            this.ButtonOrder.FlatAppearance.BorderSize = 0;
            this.ButtonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonOrder.Location = new System.Drawing.Point(0, 320);
            this.ButtonOrder.Name = "ButtonOrder";
            this.ButtonOrder.Size = new System.Drawing.Size(220, 80);
            this.ButtonOrder.TabIndex = 4;
            this.ButtonOrder.Text = "Informacje o aktualnym wypożyczeniu";
            this.ButtonOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonOrder.UseVisualStyleBackColor = true;
            this.ButtonOrder.Click += new System.EventHandler(this.ButtonOrder_Click);
            // 
            // ButtonCatalog
            // 
            this.ButtonCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCatalog.FlatAppearance.BorderSize = 0;
            this.ButtonCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCatalog.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCatalog.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCatalog.Location = new System.Drawing.Point(0, 240);
            this.ButtonCatalog.Name = "ButtonCatalog";
            this.ButtonCatalog.Size = new System.Drawing.Size(220, 80);
            this.ButtonCatalog.TabIndex = 2;
            this.ButtonCatalog.Text = "Wyświetl katalog";
            this.ButtonCatalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCatalog.UseVisualStyleBackColor = true;
            this.ButtonCatalog.Click += new System.EventHandler(this.ButtonCatalog_Click);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonLogout.FlatAppearance.BorderSize = 0;
            this.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogout.Location = new System.Drawing.Point(0, 601);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(220, 80);
            this.ButtonLogout.TabIndex = 3;
            this.ButtonLogout.Text = "Wyloguj się";
            this.ButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Visible = false;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRegister.Location = new System.Drawing.Point(0, 160);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(220, 80);
            this.ButtonRegister.TabIndex = 2;
            this.ButtonRegister.Text = "Rejestracja";
            this.ButtonRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.PanelTitleBar.Controls.Add(this.LabelTitle);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(1044, 80);
            this.PanelTitleBar.TabIndex = 2;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(6, 24);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(1026, 32);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Strona główna";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(220, 80);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(1044, 601);
            this.PanelDesktop.TabIndex = 3;
            // 
            // KlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Name = "KlientForm";
            this.Text = "Klient";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.PanelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelLogo;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Button ButtonCatalog;
        private System.Windows.Forms.Button ButtonAddOrder;
        private System.Windows.Forms.Button ButtonOrder;
    }
}
