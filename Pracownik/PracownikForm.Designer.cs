namespace Pracownik
{
    partial class PracownikForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelEnd = new System.Windows.Forms.Panel();
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.btnDodajUzytkownika = new System.Windows.Forms.Button();
            this.btnModyfikowanieKat = new System.Windows.Forms.Button();
            this.btnKatalogSamochodow = new System.Windows.Forms.Button();
            this.btnLogowanie = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelEnd);
            this.panelMenu.Controls.Add(this.btnWyloguj);
            this.panelMenu.Controls.Add(this.btnDodajUzytkownika);
            this.panelMenu.Controls.Add(this.btnModyfikowanieKat);
            this.panelMenu.Controls.Add(this.btnKatalogSamochodow);
            this.panelMenu.Controls.Add(this.btnLogowanie);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 560);
            this.panelMenu.TabIndex = 1;
            // 
            // panelEnd
            // 
            this.panelEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEnd.Location = new System.Drawing.Point(0, 480);
            this.panelEnd.Name = "panelEnd";
            this.panelEnd.Size = new System.Drawing.Size(220, 80);
            this.panelEnd.TabIndex = 6;
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnWyloguj.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWyloguj.FlatAppearance.BorderSize = 0;
            this.btnWyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWyloguj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWyloguj.ForeColor = System.Drawing.Color.White;
            this.btnWyloguj.Location = new System.Drawing.Point(0, 400);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(220, 80);
            this.btnWyloguj.TabIndex = 5;
            this.btnWyloguj.Text = "WYLOGUJ";
            this.btnWyloguj.UseVisualStyleBackColor = false;
            this.btnWyloguj.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // btnDodajUzytkownika
            // 
            this.btnDodajUzytkownika.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDodajUzytkownika.FlatAppearance.BorderSize = 0;
            this.btnDodajUzytkownika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajUzytkownika.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDodajUzytkownika.ForeColor = System.Drawing.Color.White;
            this.btnDodajUzytkownika.Location = new System.Drawing.Point(0, 320);
            this.btnDodajUzytkownika.Name = "btnDodajUzytkownika";
            this.btnDodajUzytkownika.Size = new System.Drawing.Size(220, 80);
            this.btnDodajUzytkownika.TabIndex = 4;
            this.btnDodajUzytkownika.Text = "       DODAJ       UŻYTKOWNIKA";
            this.btnDodajUzytkownika.UseVisualStyleBackColor = true;
            this.btnDodajUzytkownika.Click += new System.EventHandler(this.btnDodajUzytkownika_Click);
            // 
            // btnModyfikowanieKat
            // 
            this.btnModyfikowanieKat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModyfikowanieKat.FlatAppearance.BorderSize = 0;
            this.btnModyfikowanieKat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModyfikowanieKat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModyfikowanieKat.ForeColor = System.Drawing.Color.White;
            this.btnModyfikowanieKat.Location = new System.Drawing.Point(0, 240);
            this.btnModyfikowanieKat.Name = "btnModyfikowanieKat";
            this.btnModyfikowanieKat.Size = new System.Drawing.Size(220, 80);
            this.btnModyfikowanieKat.TabIndex = 3;
            this.btnModyfikowanieKat.Text = " MODYFIKOWANIE   KATALOGU";
            this.btnModyfikowanieKat.UseVisualStyleBackColor = true;
            this.btnModyfikowanieKat.Click += new System.EventHandler(this.btnModyfikowanieKat_Click);
            // 
            // btnKatalogSamochodow
            // 
            this.btnKatalogSamochodow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKatalogSamochodow.FlatAppearance.BorderSize = 0;
            this.btnKatalogSamochodow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKatalogSamochodow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKatalogSamochodow.ForeColor = System.Drawing.Color.White;
            this.btnKatalogSamochodow.Location = new System.Drawing.Point(0, 160);
            this.btnKatalogSamochodow.Name = "btnKatalogSamochodow";
            this.btnKatalogSamochodow.Size = new System.Drawing.Size(220, 80);
            this.btnKatalogSamochodow.TabIndex = 2;
            this.btnKatalogSamochodow.Text = "     KATALOG     SAMOCHODÓW";
            this.btnKatalogSamochodow.UseVisualStyleBackColor = true;
            this.btnKatalogSamochodow.Click += new System.EventHandler(this.btnKatalogSamochodow_Click);
            // 
            // btnLogowanie
            // 
            this.btnLogowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnLogowanie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogowanie.FlatAppearance.BorderSize = 0;
            this.btnLogowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogowanie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogowanie.ForeColor = System.Drawing.Color.White;
            this.btnLogowanie.Location = new System.Drawing.Point(0, 80);
            this.btnLogowanie.Name = "btnLogowanie";
            this.btnLogowanie.Size = new System.Drawing.Size(220, 80);
            this.btnLogowanie.TabIndex = 1;
            this.btnLogowanie.Text = "LOGOWANIE";
            this.btnLogowanie.UseVisualStyleBackColor = false;
            this.btnLogowanie.Click += new System.EventHandler(this.btnLogowanie_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(842, 80);
            this.panelTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(842, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LOGOWANIE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(842, 480);
            this.panelContent.TabIndex = 3;
            // 
            // PracownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 560);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "PracownikForm";
            this.Text = "Pracownik";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDodajUzytkownika;
        private System.Windows.Forms.Button btnModyfikowanieKat;
        private System.Windows.Forms.Button btnKatalogSamochodow;
        private System.Windows.Forms.Button btnLogowanie;
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.Panel panelEnd;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContent;
    }
}
