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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtonAddOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthCalendarDataOddania
            // 
            this.MonthCalendarDataOddania.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MonthCalendarDataOddania.Location = new System.Drawing.Point(374, 36);
            this.MonthCalendarDataOddania.MaxSelectionCount = 1;
            this.MonthCalendarDataOddania.MinDate = new System.DateTime(2022, 1, 23, 0, 0, 0, 0);
            this.MonthCalendarDataOddania.Name = "MonthCalendarDataOddania";
            this.MonthCalendarDataOddania.TabIndex = 1;
            // 
            // LabelDataOddania
            // 
            this.LabelDataOddania.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelDataOddania.AutoSize = true;
            this.LabelDataOddania.Location = new System.Drawing.Point(374, 10);
            this.LabelDataOddania.Name = "LabelDataOddania";
            this.LabelDataOddania.Size = new System.Drawing.Size(89, 17);
            this.LabelDataOddania.TabIndex = 3;
            this.LabelDataOddania.Text = "Data Oddania";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 293);
            this.listBox1.TabIndex = 4;
            // 
            // ButtonAddOrder
            // 
            this.ButtonAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAddOrder.AutoSize = true;
            this.ButtonAddOrder.Location = new System.Drawing.Point(454, 243);
            this.ButtonAddOrder.Name = "ButtonAddOrder";
            this.ButtonAddOrder.Size = new System.Drawing.Size(114, 27);
            this.ButtonAddOrder.TabIndex = 5;
            this.ButtonAddOrder.Text = "Złóż zamówienie";
            this.ButtonAddOrder.UseVisualStyleBackColor = true;
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 314);
            this.Controls.Add(this.ButtonAddOrder);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ButtonAddOrder;
    }
}