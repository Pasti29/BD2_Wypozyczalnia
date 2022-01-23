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
            this.MonthCalendarDataOddania = new System.Windows.Forms.MonthCalendar();
            this.LabelDataOddania = new System.Windows.Forms.Label();
            this.ListBoxCars = new System.Windows.Forms.ListBox();
            this.ButtonAddOrder = new System.Windows.Forms.Button();
            this.LabelHaveOrder = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MonthCalendarDataOddania
            // 
            this.MonthCalendarDataOddania.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MonthCalendarDataOddania.Location = new System.Drawing.Point(373, 81);
            this.MonthCalendarDataOddania.MaxSelectionCount = 1;
            this.MonthCalendarDataOddania.MinDate = new System.DateTime(2022, 1, 23, 0, 0, 0, 0);
            this.MonthCalendarDataOddania.Name = "MonthCalendarDataOddania";
            this.MonthCalendarDataOddania.TabIndex = 1;
            // 
            // LabelDataOddania
            // 
            this.LabelDataOddania.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelDataOddania.AutoSize = true;
            this.LabelDataOddania.Location = new System.Drawing.Point(373, 55);
            this.LabelDataOddania.Name = "LabelDataOddania";
            this.LabelDataOddania.Size = new System.Drawing.Size(89, 17);
            this.LabelDataOddania.TabIndex = 3;
            this.LabelDataOddania.Text = "Data Oddania";
            // 
            // ListBoxCars
            // 
            this.ListBoxCars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListBoxCars.FormattingEnabled = true;
            this.ListBoxCars.ItemHeight = 17;
            this.ListBoxCars.Location = new System.Drawing.Point(11, 57);
            this.ListBoxCars.Name = "ListBoxCars";
            this.ListBoxCars.Size = new System.Drawing.Size(350, 293);
            this.ListBoxCars.TabIndex = 4;
            // 
            // ButtonAddOrder
            // 
            this.ButtonAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAddOrder.AutoSize = true;
            this.ButtonAddOrder.Location = new System.Drawing.Point(453, 288);
            this.ButtonAddOrder.Name = "ButtonAddOrder";
            this.ButtonAddOrder.Size = new System.Drawing.Size(114, 27);
            this.ButtonAddOrder.TabIndex = 5;
            this.ButtonAddOrder.Text = "Złóż zamówienie";
            this.ButtonAddOrder.UseVisualStyleBackColor = true;
            this.ButtonAddOrder.Click += new System.EventHandler(this.ButtonAddOrder_Click);
            // 
            // LabelHaveOrder
            // 
            this.LabelHaveOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelHaveOrder.AutoSize = true;
            this.LabelHaveOrder.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelHaveOrder.Location = new System.Drawing.Point(81, 9);
            this.LabelHaveOrder.Name = "LabelHaveOrder";
            this.LabelHaveOrder.Size = new System.Drawing.Size(477, 23);
            this.LabelHaveOrder.TabIndex = 6;
            this.LabelHaveOrder.Text = "Nie możesz dodać nowego zamówienia, bo już jedno masz";
            this.LabelHaveOrder.Visible = false;
            // 
            // LabelStatus
            // 
            this.LabelStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelStatus.Location = new System.Drawing.Point(373, 333);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(261, 63);
            this.LabelStatus.TabIndex = 7;
            this.LabelStatus.Text = "#Status#";
            this.LabelStatus.Visible = false;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 405);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelHaveOrder);
            this.Controls.Add(this.ButtonAddOrder);
            this.Controls.Add(this.ListBoxCars);
            this.Controls.Add(this.LabelDataOddania);
            this.Controls.Add(this.MonthCalendarDataOddania);
            this.Name = "FormAddOrder";
            this.Text = "Złóż wypożyczenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar MonthCalendarDataOddania;
        private System.Windows.Forms.Label LabelDataOddania;
        private System.Windows.Forms.ListBox ListBoxCars;
        private System.Windows.Forms.Button ButtonAddOrder;
        private System.Windows.Forms.Label LabelHaveOrder;
        private System.Windows.Forms.Label LabelStatus;
    }
}