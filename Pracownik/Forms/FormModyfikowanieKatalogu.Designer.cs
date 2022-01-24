
namespace Pracownik.Forms
{
    partial class FormModyfikowanieKatalogu
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
            this.panelModifyFooter = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelModifySearch = new System.Windows.Forms.Panel();
            this.maskedTextBoxRegistration = new System.Windows.Forms.MaskedTextBox();
            this.labelInsertRegistration = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBoxWorkerID = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxVintage = new System.Windows.Forms.TextBox();
            this.textBoxAverageConsumption = new System.Windows.Forms.TextBox();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxEngineCapacity = new System.Windows.Forms.TextBox();
            this.labelWorkerID = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelBorrowed = new System.Windows.Forms.Label();
            this.labelVintage = new System.Windows.Forms.Label();
            this.labelAverageConsumption = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.labelEngineCapacity = new System.Windows.Forms.Label();
            this.labelControlDate = new System.Windows.Forms.Label();
            this.pictureBoxAuto = new System.Windows.Forms.PictureBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.checkBoxBorrowed = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxControlDate = new System.Windows.Forms.MaskedTextBox();
            this.panelModifyFooter.SuspendLayout();
            this.panelModifySearch.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelModifyFooter
            // 
            this.panelModifyFooter.Controls.Add(this.labelStatus);
            this.panelModifyFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelModifyFooter.Location = new System.Drawing.Point(0, 539);
            this.panelModifyFooter.Name = "panelModifyFooter";
            this.panelModifyFooter.Size = new System.Drawing.Size(993, 50);
            this.panelModifyFooter.TabIndex = 9;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(205)))));
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Location = new System.Drawing.Point(0, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(993, 50);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status: Oczekiwanie na rejestrację...";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(262, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(470, 29);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelModifySearch
            // 
            this.panelModifySearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelModifySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(143)))), ((int)(((byte)(152)))));
            this.panelModifySearch.Controls.Add(this.maskedTextBoxRegistration);
            this.panelModifySearch.Controls.Add(this.labelInsertRegistration);
            this.panelModifySearch.Location = new System.Drawing.Point(262, 5);
            this.panelModifySearch.Name = "panelModifySearch";
            this.panelModifySearch.Size = new System.Drawing.Size(470, 48);
            this.panelModifySearch.TabIndex = 8;
            // 
            // maskedTextBoxRegistration
            // 
            this.maskedTextBoxRegistration.AsciiOnly = true;
            this.maskedTextBoxRegistration.Location = new System.Drawing.Point(203, 11);
            this.maskedTextBoxRegistration.Mask = "AAAAAAA";
            this.maskedTextBoxRegistration.Name = "maskedTextBoxRegistration";
            this.maskedTextBoxRegistration.Size = new System.Drawing.Size(241, 27);
            this.maskedTextBoxRegistration.TabIndex = 34;
            this.maskedTextBoxRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelInsertRegistration
            // 
            this.labelInsertRegistration.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelInsertRegistration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInsertRegistration.ForeColor = System.Drawing.Color.White;
            this.labelInsertRegistration.Location = new System.Drawing.Point(0, 0);
            this.labelInsertRegistration.Name = "labelInsertRegistration";
            this.labelInsertRegistration.Size = new System.Drawing.Size(212, 48);
            this.labelInsertRegistration.TabIndex = 6;
            this.labelInsertRegistration.Text = "Wprowadź rejestrację:";
            this.labelInsertRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(262, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(470, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Dodaj auto";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(205)))));
            this.panelHeader.Controls.Add(this.btnReturn);
            this.panelHeader.Controls.Add(this.btnDelete);
            this.panelHeader.Controls.Add(this.btnUpdate);
            this.panelHeader.Controls.Add(this.btnAdd);
            this.panelHeader.Controls.Add(this.panelModifySearch);
            this.panelHeader.Controls.Add(this.btnSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(993, 133);
            this.panelHeader.TabIndex = 12;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(500, 59);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(232, 29);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(262, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 29);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(262, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(470, 29);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Aktualizuj";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBoxWorkerID
            // 
            this.textBoxWorkerID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxWorkerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxWorkerID.Location = new System.Drawing.Point(241, 203);
            this.textBoxWorkerID.Name = "textBoxWorkerID";
            this.textBoxWorkerID.Size = new System.Drawing.Size(209, 27);
            this.textBoxWorkerID.TabIndex = 14;
            this.textBoxWorkerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBrand.Location = new System.Drawing.Point(241, 236);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(209, 27);
            this.textBoxBrand.TabIndex = 15;
            this.textBoxBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxModel.Location = new System.Drawing.Point(241, 269);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(209, 27);
            this.textBoxModel.TabIndex = 16;
            this.textBoxModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxVintage
            // 
            this.textBoxVintage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxVintage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVintage.Location = new System.Drawing.Point(241, 335);
            this.textBoxVintage.Name = "textBoxVintage";
            this.textBoxVintage.Size = new System.Drawing.Size(209, 27);
            this.textBoxVintage.TabIndex = 18;
            this.textBoxVintage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAverageConsumption
            // 
            this.textBoxAverageConsumption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAverageConsumption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAverageConsumption.Location = new System.Drawing.Point(241, 368);
            this.textBoxAverageConsumption.Name = "textBoxAverageConsumption";
            this.textBoxAverageConsumption.Size = new System.Drawing.Size(209, 27);
            this.textBoxAverageConsumption.TabIndex = 19;
            this.textBoxAverageConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMaxSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(241, 401);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(209, 27);
            this.textBoxMaxSpeed.TabIndex = 20;
            this.textBoxMaxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEngineCapacity
            // 
            this.textBoxEngineCapacity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEngineCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEngineCapacity.Location = new System.Drawing.Point(241, 434);
            this.textBoxEngineCapacity.Name = "textBoxEngineCapacity";
            this.textBoxEngineCapacity.Size = new System.Drawing.Size(209, 27);
            this.textBoxEngineCapacity.TabIndex = 21;
            this.textBoxEngineCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWorkerID
            // 
            this.labelWorkerID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWorkerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWorkerID.ForeColor = System.Drawing.Color.Black;
            this.labelWorkerID.Location = new System.Drawing.Point(103, 203);
            this.labelWorkerID.Name = "labelWorkerID";
            this.labelWorkerID.Size = new System.Drawing.Size(130, 27);
            this.labelWorkerID.TabIndex = 23;
            this.labelWorkerID.Text = "ID Pracownika:";
            this.labelWorkerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBrand
            // 
            this.labelBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.ForeColor = System.Drawing.Color.Black;
            this.labelBrand.Location = new System.Drawing.Point(164, 236);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(70, 27);
            this.labelBrand.TabIndex = 24;
            this.labelBrand.Text = "Marka:";
            this.labelBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelModel
            // 
            this.labelModel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelModel.ForeColor = System.Drawing.Color.Black;
            this.labelModel.Location = new System.Drawing.Point(164, 269);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(70, 27);
            this.labelModel.TabIndex = 25;
            this.labelModel.Text = "Model:";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBorrowed
            // 
            this.labelBorrowed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBorrowed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBorrowed.ForeColor = System.Drawing.Color.Black;
            this.labelBorrowed.Location = new System.Drawing.Point(103, 302);
            this.labelBorrowed.Name = "labelBorrowed";
            this.labelBorrowed.Size = new System.Drawing.Size(130, 27);
            this.labelBorrowed.TabIndex = 26;
            this.labelBorrowed.Text = "Wypożyczony:";
            this.labelBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVintage
            // 
            this.labelVintage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelVintage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVintage.ForeColor = System.Drawing.Color.Black;
            this.labelVintage.Location = new System.Drawing.Point(156, 335);
            this.labelVintage.Name = "labelVintage";
            this.labelVintage.Size = new System.Drawing.Size(78, 27);
            this.labelVintage.TabIndex = 27;
            this.labelVintage.Text = "Rocznik:";
            this.labelVintage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAverageConsumption
            // 
            this.labelAverageConsumption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAverageConsumption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAverageConsumption.ForeColor = System.Drawing.Color.Black;
            this.labelAverageConsumption.Location = new System.Drawing.Point(49, 368);
            this.labelAverageConsumption.Name = "labelAverageConsumption";
            this.labelAverageConsumption.Size = new System.Drawing.Size(184, 27);
            this.labelAverageConsumption.TabIndex = 28;
            this.labelAverageConsumption.Text = "Średnie spalanie:";
            this.labelAverageConsumption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMaxSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMaxSpeed.ForeColor = System.Drawing.Color.Black;
            this.labelMaxSpeed.Location = new System.Drawing.Point(29, 401);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(205, 27);
            this.labelMaxSpeed.TabIndex = 29;
            this.labelMaxSpeed.Text = "Prędkość maksymalna:";
            this.labelMaxSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEngineCapacity
            // 
            this.labelEngineCapacity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEngineCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEngineCapacity.ForeColor = System.Drawing.Color.Black;
            this.labelEngineCapacity.Location = new System.Drawing.Point(49, 434);
            this.labelEngineCapacity.Name = "labelEngineCapacity";
            this.labelEngineCapacity.Size = new System.Drawing.Size(184, 27);
            this.labelEngineCapacity.TabIndex = 30;
            this.labelEngineCapacity.Text = "Pojemność silnika:";
            this.labelEngineCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelControlDate
            // 
            this.labelControlDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControlDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelControlDate.ForeColor = System.Drawing.Color.Black;
            this.labelControlDate.Location = new System.Drawing.Point(92, 467);
            this.labelControlDate.Name = "labelControlDate";
            this.labelControlDate.Size = new System.Drawing.Size(142, 27);
            this.labelControlDate.TabIndex = 31;
            this.labelControlDate.Text = "Data przeglądu:";
            this.labelControlDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxAuto
            // 
            this.pictureBoxAuto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxAuto.BackColor = System.Drawing.Color.White;
            this.pictureBoxAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAuto.Location = new System.Drawing.Point(518, 212);
            this.pictureBoxAuto.Name = "pictureBoxAuto";
            this.pictureBoxAuto.Size = new System.Drawing.Size(384, 216);
            this.pictureBoxAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAuto.TabIndex = 13;
            this.pictureBoxAuto.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(143)))), ((int)(((byte)(152)))));
            this.btnSelectPhoto.FlatAppearance.BorderSize = 0;
            this.btnSelectPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectPhoto.ForeColor = System.Drawing.Color.White;
            this.btnSelectPhoto.Location = new System.Drawing.Point(518, 434);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(384, 29);
            this.btnSelectPhoto.TabIndex = 0;
            this.btnSelectPhoto.Text = "Wybierz zdjęcie";
            this.btnSelectPhoto.UseVisualStyleBackColor = false;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // checkBoxBorrowed
            // 
            this.checkBoxBorrowed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxBorrowed.AutoSize = true;
            this.checkBoxBorrowed.Location = new System.Drawing.Point(337, 308);
            this.checkBoxBorrowed.Name = "checkBoxBorrowed";
            this.checkBoxBorrowed.Size = new System.Drawing.Size(18, 17);
            this.checkBoxBorrowed.TabIndex = 32;
            this.checkBoxBorrowed.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxControlDate
            // 
            this.maskedTextBoxControlDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskedTextBoxControlDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxControlDate.Location = new System.Drawing.Point(241, 467);
            this.maskedTextBoxControlDate.Mask = "00/00/0000";
            this.maskedTextBoxControlDate.Name = "maskedTextBoxControlDate";
            this.maskedTextBoxControlDate.Size = new System.Drawing.Size(209, 27);
            this.maskedTextBoxControlDate.TabIndex = 33;
            this.maskedTextBoxControlDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxControlDate.ValidatingType = typeof(System.DateTime);
            // 
            // FormModyfikowanieKatalogu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 589);
            this.Controls.Add(this.maskedTextBoxControlDate);
            this.Controls.Add(this.checkBoxBorrowed);
            this.Controls.Add(this.pictureBoxAuto);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.labelControlDate);
            this.Controls.Add(this.textBoxWorkerID);
            this.Controls.Add(this.labelEngineCapacity);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.panelModifyFooter);
            this.Controls.Add(this.labelMaxSpeed);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelWorkerID);
            this.Controls.Add(this.labelAverageConsumption);
            this.Controls.Add(this.textBoxEngineCapacity);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelVintage);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.textBoxVintage);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBorrowed);
            this.Controls.Add(this.textBoxAverageConsumption);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormModyfikowanieKatalogu";
            this.Text = "MODYFIKOWANIE KATALOGU";
            this.panelModifyFooter.ResumeLayout(false);
            this.panelModifySearch.ResumeLayout(false);
            this.panelModifySearch.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelModifyFooter;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelModifySearch;
        private System.Windows.Forms.Label labelInsertRegistration;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBoxWorkerID;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxVintage;
        private System.Windows.Forms.TextBox textBoxAverageConsumption;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.TextBox textBoxEngineCapacity;
        private System.Windows.Forms.Label labelWorkerID;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelBorrowed;
        private System.Windows.Forms.Label labelVintage;
        private System.Windows.Forms.Label labelAverageConsumption;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelEngineCapacity;
        private System.Windows.Forms.Label labelControlDate;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.PictureBox pictureBoxAuto;
        private System.Windows.Forms.CheckBox checkBoxBorrowed;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxControlDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRegistration;
    }
}