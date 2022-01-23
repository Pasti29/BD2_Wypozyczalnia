namespace Klient.Forms
{
    partial class FormAddOrder
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
            this.MonthCalendarDataWypozyczenia = new System.Windows.Forms.MonthCalendar();
            this.MonthCalendarDataOddania = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // MonthCalendarDataWypozyczenia
            // 
            this.MonthCalendarDataWypozyczenia.Location = new System.Drawing.Point(513, 18);
            this.MonthCalendarDataWypozyczenia.MaxSelectionCount = 1;
            this.MonthCalendarDataWypozyczenia.MinDate = new System.DateTime(2022, 1, 23, 0, 0, 0, 0);
            this.MonthCalendarDataWypozyczenia.Name = "MonthCalendarDataWypozyczenia";
            this.MonthCalendarDataWypozyczenia.TabIndex = 0;
            this.MonthCalendarDataWypozyczenia.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendarDataWypozyczenia_DateChanged);
            // 
            // MonthCalendarDataOddania
            // 
            this.MonthCalendarDataOddania.Location = new System.Drawing.Point(513, 270);
            this.MonthCalendarDataOddania.MaxSelectionCount = 1;
            this.MonthCalendarDataOddania.MinDate = new System.DateTime(2022, 1, 23, 0, 0, 0, 0);
            this.MonthCalendarDataOddania.Name = "MonthCalendarDataOddania";
            this.MonthCalendarDataOddania.TabIndex = 1;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MonthCalendarDataOddania);
            this.Controls.Add(this.MonthCalendarDataWypozyczenia);
            this.Name = "FormAddOrder";
            this.Text = "Złóż wypożyczenie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MonthCalendarDataWypozyczenia;
        private System.Windows.Forms.MonthCalendar MonthCalendarDataOddania;
    }
}