
namespace Pracownik.Forms
{
    partial class FormWeryfikacjaKilentow
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.btnReject = new System.Windows.Forms.Button();
            this.bntConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(188, 100);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUsers.RowTemplate.Height = 29;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(677, 327);
            this.dataGridViewUsers.TabIndex = 3;
            // 
            // btnReject
            // 
            this.btnReject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReject.BackColor = System.Drawing.Color.LightCoral;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Location = new System.Drawing.Point(538, 449);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(161, 38);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Odrzuć";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // bntConfirm
            // 
            this.bntConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bntConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.bntConfirm.FlatAppearance.BorderSize = 0;
            this.bntConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntConfirm.Location = new System.Drawing.Point(371, 449);
            this.bntConfirm.Name = "bntConfirm";
            this.bntConfirm.Size = new System.Drawing.Size(161, 38);
            this.bntConfirm.TabIndex = 0;
            this.bntConfirm.Text = "Potwierdź";
            this.bntConfirm.UseVisualStyleBackColor = false;
            this.bntConfirm.Click += new System.EventHandler(this.bntConfirm_Click);
            // 
            // FormWeryfikacjaKilentow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 551);
            this.Controls.Add(this.bntConfirm);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.btnReject);
            this.Name = "FormWeryfikacjaKilentow";
            this.Text = "WERYFIKACJA KLIENTÓW";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button bntConfirm;
    }
}