﻿namespace Klient.Forms
{
    partial class FormOrder
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
            this.LabelNoOrder = new System.Windows.Forms.Label();
            this.TextBoxOplata = new System.Windows.Forms.TextBox();
            this.LabelOplata = new System.Windows.Forms.Label();
            this.TextBoxDataOddania = new System.Windows.Forms.TextBox();
            this.LabelDataOddania = new System.Windows.Forms.Label();
            this.TextBoxDataWypoczyczenia = new System.Windows.Forms.TextBox();
            this.LabelDataWypozyczenia = new System.Windows.Forms.Label();
            this.TextBoxPojemnoscSilnika = new System.Windows.Forms.TextBox();
            this.LabelPojemnoscSilnika = new System.Windows.Forms.Label();
            this.TextBoxPredkoscMAX = new System.Windows.Forms.TextBox();
            this.LabelPredkoscMAX = new System.Windows.Forms.Label();
            this.TextBoxSrednieSpalanie = new System.Windows.Forms.TextBox();
            this.LabelSrednieSpalanie = new System.Windows.Forms.Label();
            this.TextBoxRocznik = new System.Windows.Forms.TextBox();
            this.LabelRocznik = new System.Windows.Forms.Label();
            this.TextBoxModel = new System.Windows.Forms.TextBox();
            this.LabelModel = new System.Windows.Forms.Label();
            this.TextBoxMarka = new System.Windows.Forms.TextBox();
            this.LabelMarka = new System.Windows.Forms.Label();
            this.PanelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.Controls.Add(this.LabelNoOrder);
            this.PanelDesktop.Controls.Add(this.TextBoxOplata);
            this.PanelDesktop.Controls.Add(this.LabelOplata);
            this.PanelDesktop.Controls.Add(this.TextBoxDataOddania);
            this.PanelDesktop.Controls.Add(this.LabelDataOddania);
            this.PanelDesktop.Controls.Add(this.TextBoxDataWypoczyczenia);
            this.PanelDesktop.Controls.Add(this.LabelDataWypozyczenia);
            this.PanelDesktop.Controls.Add(this.TextBoxPojemnoscSilnika);
            this.PanelDesktop.Controls.Add(this.LabelPojemnoscSilnika);
            this.PanelDesktop.Controls.Add(this.TextBoxPredkoscMAX);
            this.PanelDesktop.Controls.Add(this.LabelPredkoscMAX);
            this.PanelDesktop.Controls.Add(this.TextBoxSrednieSpalanie);
            this.PanelDesktop.Controls.Add(this.LabelSrednieSpalanie);
            this.PanelDesktop.Controls.Add(this.TextBoxRocznik);
            this.PanelDesktop.Controls.Add(this.LabelRocznik);
            this.PanelDesktop.Controls.Add(this.TextBoxModel);
            this.PanelDesktop.Controls.Add(this.LabelModel);
            this.PanelDesktop.Controls.Add(this.TextBoxMarka);
            this.PanelDesktop.Controls.Add(this.LabelMarka);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(0, 0);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(351, 358);
            this.PanelDesktop.TabIndex = 0;
            // 
            // LabelNoOrder
            // 
            this.LabelNoOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNoOrder.AutoSize = true;
            this.LabelNoOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNoOrder.Location = new System.Drawing.Point(12, 9);
            this.LabelNoOrder.Name = "LabelNoOrder";
            this.LabelNoOrder.Size = new System.Drawing.Size(334, 30);
            this.LabelNoOrder.TabIndex = 18;
            this.LabelNoOrder.Text = "Nie masz żadnego wypożyczenia";
            this.LabelNoOrder.Visible = false;
            // 
            // TextBoxOplata
            // 
            this.TextBoxOplata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxOplata.Location = new System.Drawing.Point(161, 296);
            this.TextBoxOplata.Name = "TextBoxOplata";
            this.TextBoxOplata.Size = new System.Drawing.Size(167, 25);
            this.TextBoxOplata.TabIndex = 17;
            // 
            // LabelOplata
            // 
            this.LabelOplata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelOplata.AutoSize = true;
            this.LabelOplata.Location = new System.Drawing.Point(104, 299);
            this.LabelOplata.Name = "LabelOplata";
            this.LabelOplata.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelOplata.Size = new System.Drawing.Size(47, 17);
            this.LabelOplata.TabIndex = 16;
            this.LabelOplata.Text = "Opłata";
            this.LabelOplata.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxDataOddania
            // 
            this.TextBoxDataOddania.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxDataOddania.Location = new System.Drawing.Point(161, 265);
            this.TextBoxDataOddania.Name = "TextBoxDataOddania";
            this.TextBoxDataOddania.Size = new System.Drawing.Size(167, 25);
            this.TextBoxDataOddania.TabIndex = 15;
            // 
            // LabelDataOddania
            // 
            this.LabelDataOddania.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelDataOddania.AutoSize = true;
            this.LabelDataOddania.Location = new System.Drawing.Point(64, 268);
            this.LabelDataOddania.Name = "LabelDataOddania";
            this.LabelDataOddania.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelDataOddania.Size = new System.Drawing.Size(87, 17);
            this.LabelDataOddania.TabIndex = 14;
            this.LabelDataOddania.Text = "Data oddania";
            this.LabelDataOddania.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxDataWypoczyczenia
            // 
            this.TextBoxDataWypoczyczenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxDataWypoczyczenia.Location = new System.Drawing.Point(161, 234);
            this.TextBoxDataWypoczyczenia.Name = "TextBoxDataWypoczyczenia";
            this.TextBoxDataWypoczyczenia.Size = new System.Drawing.Size(167, 25);
            this.TextBoxDataWypoczyczenia.TabIndex = 13;
            // 
            // LabelDataWypozyczenia
            // 
            this.LabelDataWypozyczenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelDataWypozyczenia.AutoSize = true;
            this.LabelDataWypozyczenia.Location = new System.Drawing.Point(33, 237);
            this.LabelDataWypozyczenia.Name = "LabelDataWypozyczenia";
            this.LabelDataWypozyczenia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelDataWypozyczenia.Size = new System.Drawing.Size(118, 17);
            this.LabelDataWypozyczenia.TabIndex = 12;
            this.LabelDataWypozyczenia.Text = "Data wypożyczenia";
            this.LabelDataWypozyczenia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxPojemnoscSilnika
            // 
            this.TextBoxPojemnoscSilnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxPojemnoscSilnika.Location = new System.Drawing.Point(161, 203);
            this.TextBoxPojemnoscSilnika.Name = "TextBoxPojemnoscSilnika";
            this.TextBoxPojemnoscSilnika.Size = new System.Drawing.Size(167, 25);
            this.TextBoxPojemnoscSilnika.TabIndex = 11;
            // 
            // LabelPojemnoscSilnika
            // 
            this.LabelPojemnoscSilnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPojemnoscSilnika.AutoSize = true;
            this.LabelPojemnoscSilnika.Location = new System.Drawing.Point(41, 206);
            this.LabelPojemnoscSilnika.Name = "LabelPojemnoscSilnika";
            this.LabelPojemnoscSilnika.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPojemnoscSilnika.Size = new System.Drawing.Size(110, 17);
            this.LabelPojemnoscSilnika.TabIndex = 10;
            this.LabelPojemnoscSilnika.Text = "Pojemność silnika";
            this.LabelPojemnoscSilnika.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxPredkoscMAX
            // 
            this.TextBoxPredkoscMAX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxPredkoscMAX.Location = new System.Drawing.Point(161, 172);
            this.TextBoxPredkoscMAX.Name = "TextBoxPredkoscMAX";
            this.TextBoxPredkoscMAX.Size = new System.Drawing.Size(167, 25);
            this.TextBoxPredkoscMAX.TabIndex = 9;
            // 
            // LabelPredkoscMAX
            // 
            this.LabelPredkoscMAX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPredkoscMAX.AutoSize = true;
            this.LabelPredkoscMAX.Location = new System.Drawing.Point(15, 175);
            this.LabelPredkoscMAX.Name = "LabelPredkoscMAX";
            this.LabelPredkoscMAX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPredkoscMAX.Size = new System.Drawing.Size(136, 17);
            this.LabelPredkoscMAX.TabIndex = 8;
            this.LabelPredkoscMAX.Text = "Prędkość maksymalna";
            this.LabelPredkoscMAX.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxSrednieSpalanie
            // 
            this.TextBoxSrednieSpalanie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxSrednieSpalanie.Location = new System.Drawing.Point(161, 141);
            this.TextBoxSrednieSpalanie.Name = "TextBoxSrednieSpalanie";
            this.TextBoxSrednieSpalanie.Size = new System.Drawing.Size(167, 25);
            this.TextBoxSrednieSpalanie.TabIndex = 7;
            // 
            // LabelSrednieSpalanie
            // 
            this.LabelSrednieSpalanie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelSrednieSpalanie.AutoSize = true;
            this.LabelSrednieSpalanie.Location = new System.Drawing.Point(47, 144);
            this.LabelSrednieSpalanie.Name = "LabelSrednieSpalanie";
            this.LabelSrednieSpalanie.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelSrednieSpalanie.Size = new System.Drawing.Size(104, 17);
            this.LabelSrednieSpalanie.TabIndex = 6;
            this.LabelSrednieSpalanie.Text = "Średnie spalanie";
            this.LabelSrednieSpalanie.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxRocznik
            // 
            this.TextBoxRocznik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxRocznik.Location = new System.Drawing.Point(161, 110);
            this.TextBoxRocznik.Name = "TextBoxRocznik";
            this.TextBoxRocznik.Size = new System.Drawing.Size(167, 25);
            this.TextBoxRocznik.TabIndex = 5;
            // 
            // LabelRocznik
            // 
            this.LabelRocznik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelRocznik.AutoSize = true;
            this.LabelRocznik.Location = new System.Drawing.Point(99, 113);
            this.LabelRocznik.Name = "LabelRocznik";
            this.LabelRocznik.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelRocznik.Size = new System.Drawing.Size(52, 17);
            this.LabelRocznik.TabIndex = 4;
            this.LabelRocznik.Text = "Rocznik";
            this.LabelRocznik.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxModel
            // 
            this.TextBoxModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxModel.Location = new System.Drawing.Point(161, 79);
            this.TextBoxModel.Name = "TextBoxModel";
            this.TextBoxModel.Size = new System.Drawing.Size(167, 25);
            this.TextBoxModel.TabIndex = 3;
            // 
            // LabelModel
            // 
            this.LabelModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelModel.AutoSize = true;
            this.LabelModel.Location = new System.Drawing.Point(105, 82);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelModel.Size = new System.Drawing.Size(46, 17);
            this.LabelModel.TabIndex = 2;
            this.LabelModel.Text = "Model";
            this.LabelModel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxMarka
            // 
            this.TextBoxMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxMarka.Location = new System.Drawing.Point(161, 48);
            this.TextBoxMarka.Name = "TextBoxMarka";
            this.TextBoxMarka.Size = new System.Drawing.Size(167, 25);
            this.TextBoxMarka.TabIndex = 1;
            // 
            // LabelMarka
            // 
            this.LabelMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelMarka.AutoSize = true;
            this.LabelMarka.Location = new System.Drawing.Point(106, 51);
            this.LabelMarka.Name = "LabelMarka";
            this.LabelMarka.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelMarka.Size = new System.Drawing.Size(45, 17);
            this.LabelMarka.TabIndex = 0;
            this.LabelMarka.Text = "Marka";
            this.LabelMarka.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 358);
            this.Controls.Add(this.PanelDesktop);
            this.Name = "FormOrder";
            this.Text = "Wyświetl aktualne wypożyczenie";
            this.PanelDesktop.ResumeLayout(false);
            this.PanelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.TextBox TextBoxModel;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.TextBox TextBoxMarka;
        private System.Windows.Forms.Label LabelMarka;
        private System.Windows.Forms.TextBox TextBoxOplata;
        private System.Windows.Forms.Label LabelOplata;
        private System.Windows.Forms.TextBox TextBoxDataOddania;
        private System.Windows.Forms.Label LabelDataOddania;
        private System.Windows.Forms.TextBox TextBoxDataWypoczyczenia;
        private System.Windows.Forms.Label LabelDataWypozyczenia;
        private System.Windows.Forms.TextBox TextBoxPojemnoscSilnika;
        private System.Windows.Forms.Label LabelPojemnoscSilnika;
        private System.Windows.Forms.TextBox TextBoxPredkoscMAX;
        private System.Windows.Forms.Label LabelPredkoscMAX;
        private System.Windows.Forms.TextBox TextBoxSrednieSpalanie;
        private System.Windows.Forms.Label LabelSrednieSpalanie;
        private System.Windows.Forms.TextBox TextBoxRocznik;
        private System.Windows.Forms.Label LabelRocznik;
        private System.Windows.Forms.Label LabelNoOrder;
    }
}