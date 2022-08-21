namespace FinalProject
{
    partial class frmPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonnel));
            this.btnDeleteManager = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNewManager = new System.Windows.Forms.Button();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.cbxSuffix = new System.Windows.Forms.ComboBox();
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            this.tbxSecondaryPhone = new System.Windows.Forms.TextBox();
            this.tbxPrimaryPhone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxZipcode = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxAddressThree = new System.Windows.Forms.TextBox();
            this.tbxAddressTwo = new System.Windows.Forms.TextBox();
            this.tbxAddressOne = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblSecondaryPhone = new System.Windows.Forms.Label();
            this.lblPrimaryPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressThree = new System.Windows.Forms.Label();
            this.lblAddressTwo = new System.Windows.Forms.Label();
            this.lblAddressOne = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.btnDisableAccount = new System.Windows.Forms.Button();
            this.btnEnableAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteManager
            // 
            this.btnDeleteManager.Location = new System.Drawing.Point(1162, 323);
            this.btnDeleteManager.Name = "btnDeleteManager";
            this.btnDeleteManager.Size = new System.Drawing.Size(102, 59);
            this.btnDeleteManager.TabIndex = 71;
            this.btnDeleteManager.Text = "Delete Manager";
            this.btnDeleteManager.UseVisualStyleBackColor = true;
            this.btnDeleteManager.Click += new System.EventHandler(this.btnDeleteManager_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1054, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 59);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewManager
            // 
            this.btnNewManager.Location = new System.Drawing.Point(946, 323);
            this.btnNewManager.Name = "btnNewManager";
            this.btnNewManager.Size = new System.Drawing.Size(102, 59);
            this.btnNewManager.TabIndex = 69;
            this.btnNewManager.Text = "New Manager";
            this.btnNewManager.UseVisualStyleBackColor = true;
            this.btnNewManager.Click += new System.EventHandler(this.btnNewManager_Click);
            // 
            // cbxState
            // 
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CZ",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VI",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cbxState.Location = new System.Drawing.Point(665, 425);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(275, 32);
            this.cbxState.TabIndex = 68;
            // 
            // cbxSuffix
            // 
            this.cbxSuffix.FormattingEnabled = true;
            this.cbxSuffix.Items.AddRange(new object[] {
            "",
            "Jr.",
            "Sr.",
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IX",
            "X"});
            this.cbxSuffix.Location = new System.Drawing.Point(141, 458);
            this.cbxSuffix.Name = "cbxSuffix";
            this.cbxSuffix.Size = new System.Drawing.Size(275, 32);
            this.cbxSuffix.TabIndex = 67;
            // 
            // cbxTitle
            // 
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.Items.AddRange(new object[] {
            "",
            "Dr.",
            "Mr.",
            "Ms.",
            "Mrs.",
            "PFC",
            "LT.",
            "Gen.",
            "Adm.",
            "1stLt."});
            this.cbxTitle.Location = new System.Drawing.Point(141, 323);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(275, 32);
            this.cbxTitle.TabIndex = 66;
            // 
            // tbxSecondaryPhone
            // 
            this.tbxSecondaryPhone.Location = new System.Drawing.Point(665, 530);
            this.tbxSecondaryPhone.MaxLength = 20;
            this.tbxSecondaryPhone.Name = "tbxSecondaryPhone";
            this.tbxSecondaryPhone.Size = new System.Drawing.Size(275, 29);
            this.tbxSecondaryPhone.TabIndex = 65;
            // 
            // tbxPrimaryPhone
            // 
            this.tbxPrimaryPhone.Location = new System.Drawing.Point(665, 496);
            this.tbxPrimaryPhone.MaxLength = 20;
            this.tbxPrimaryPhone.Name = "tbxPrimaryPhone";
            this.tbxPrimaryPhone.Size = new System.Drawing.Size(275, 29);
            this.tbxPrimaryPhone.TabIndex = 64;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(665, 462);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(275, 29);
            this.tbxEmail.TabIndex = 63;
            // 
            // tbxZipcode
            // 
            this.tbxZipcode.Location = new System.Drawing.Point(665, 391);
            this.tbxZipcode.MaxLength = 10;
            this.tbxZipcode.Name = "tbxZipcode";
            this.tbxZipcode.Size = new System.Drawing.Size(275, 29);
            this.tbxZipcode.TabIndex = 62;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(665, 357);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(275, 29);
            this.tbxCity.TabIndex = 61;
            // 
            // tbxAddressThree
            // 
            this.tbxAddressThree.Location = new System.Drawing.Point(665, 323);
            this.tbxAddressThree.MaxLength = 30;
            this.tbxAddressThree.Name = "tbxAddressThree";
            this.tbxAddressThree.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressThree.TabIndex = 60;
            // 
            // tbxAddressTwo
            // 
            this.tbxAddressTwo.Location = new System.Drawing.Point(141, 527);
            this.tbxAddressTwo.MaxLength = 30;
            this.tbxAddressTwo.Name = "tbxAddressTwo";
            this.tbxAddressTwo.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressTwo.TabIndex = 59;
            // 
            // tbxAddressOne
            // 
            this.tbxAddressOne.Location = new System.Drawing.Point(141, 494);
            this.tbxAddressOne.MaxLength = 30;
            this.tbxAddressOne.Name = "tbxAddressOne";
            this.tbxAddressOne.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressOne.TabIndex = 58;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(141, 425);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(275, 29);
            this.tbxLastName.TabIndex = 57;
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(141, 392);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(275, 29);
            this.tbxMiddleName.TabIndex = 56;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(141, 359);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(275, 29);
            this.tbxFirstName.TabIndex = 55;
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(519, 781);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(100, 24);
            this.lblRequired.TabIndex = 54;
            this.lblRequired.Text = "* Required";
            // 
            // lblSecondaryPhone
            // 
            this.lblSecondaryPhone.AutoSize = true;
            this.lblSecondaryPhone.Location = new System.Drawing.Point(492, 530);
            this.lblSecondaryPhone.Name = "lblSecondaryPhone";
            this.lblSecondaryPhone.Size = new System.Drawing.Size(167, 24);
            this.lblSecondaryPhone.TabIndex = 53;
            this.lblSecondaryPhone.Text = "Secondary Phone:";
            // 
            // lblPrimaryPhone
            // 
            this.lblPrimaryPhone.AutoSize = true;
            this.lblPrimaryPhone.Location = new System.Drawing.Point(520, 496);
            this.lblPrimaryPhone.Name = "lblPrimaryPhone";
            this.lblPrimaryPhone.Size = new System.Drawing.Size(139, 24);
            this.lblPrimaryPhone.TabIndex = 52;
            this.lblPrimaryPhone.Text = "Primary Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(597, 462);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(591, 428);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 24);
            this.lblState.TabIndex = 50;
            this.lblState.Text = "* State:";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(562, 394);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(97, 24);
            this.lblZipcode.TabIndex = 49;
            this.lblZipcode.Text = "* Zipcode:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(602, 360);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 24);
            this.lblCity.TabIndex = 48;
            this.lblCity.Text = "* City:";
            // 
            // lblAddressThree
            // 
            this.lblAddressThree.AutoSize = true;
            this.lblAddressThree.Location = new System.Drawing.Point(559, 326);
            this.lblAddressThree.Name = "lblAddressThree";
            this.lblAddressThree.Size = new System.Drawing.Size(100, 24);
            this.lblAddressThree.TabIndex = 47;
            this.lblAddressThree.Text = "Address 3:";
            // 
            // lblAddressTwo
            // 
            this.lblAddressTwo.AutoSize = true;
            this.lblAddressTwo.Location = new System.Drawing.Point(35, 531);
            this.lblAddressTwo.Name = "lblAddressTwo";
            this.lblAddressTwo.Size = new System.Drawing.Size(100, 24);
            this.lblAddressTwo.TabIndex = 46;
            this.lblAddressTwo.Text = "Address 2:";
            // 
            // lblAddressOne
            // 
            this.lblAddressOne.AutoSize = true;
            this.lblAddressOne.Location = new System.Drawing.Point(23, 496);
            this.lblAddressOne.Name = "lblAddressOne";
            this.lblAddressOne.Size = new System.Drawing.Size(112, 24);
            this.lblAddressOne.TabIndex = 45;
            this.lblAddressOne.Text = "* Address 1:";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(75, 462);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(60, 24);
            this.lblSuffix.TabIndex = 44;
            this.lblSuffix.Text = "Suffix:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(19, 428);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(116, 24);
            this.lblLastName.TabIndex = 43;
            this.lblLastName.Text = "* Last Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(7, 394);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(128, 24);
            this.lblMiddleName.TabIndex = 42;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 360);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(118, 24);
            this.lblFirstName.TabIndex = 41;
            this.lblFirstName.Text = "* First Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(85, 326);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 24);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Title:";
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPersonnel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(1785, 305);
            this.dgvPersonnel.TabIndex = 39;
            this.dgvPersonnel.TabStop = false;
            this.dgvPersonnel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnel_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1378, 323);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 59);
            this.btnBack.TabIndex = 73;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(1270, 323);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(102, 59);
            this.btnRefreshTable.TabIndex = 72;
            this.btnRefreshTable.Text = "Refresh Table";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // btnDisableAccount
            // 
            this.btnDisableAccount.Location = new System.Drawing.Point(1486, 323);
            this.btnDisableAccount.Name = "btnDisableAccount";
            this.btnDisableAccount.Size = new System.Drawing.Size(102, 59);
            this.btnDisableAccount.TabIndex = 74;
            this.btnDisableAccount.Text = "Disable Account";
            this.btnDisableAccount.UseVisualStyleBackColor = true;
            this.btnDisableAccount.Click += new System.EventHandler(this.btnDisableAccount_Click);
            // 
            // btnEnableAccount
            // 
            this.btnEnableAccount.Location = new System.Drawing.Point(1486, 388);
            this.btnEnableAccount.Name = "btnEnableAccount";
            this.btnEnableAccount.Size = new System.Drawing.Size(102, 59);
            this.btnEnableAccount.TabIndex = 75;
            this.btnEnableAccount.Text = "Enable Account";
            this.btnEnableAccount.UseVisualStyleBackColor = true;
            this.btnEnableAccount.Click += new System.EventHandler(this.btnEnableAccount_Click);
            // 
            // frmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 817);
            this.Controls.Add(this.btnEnableAccount);
            this.Controls.Add(this.btnDisableAccount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.btnDeleteManager);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNewManager);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.cbxSuffix);
            this.Controls.Add(this.cbxTitle);
            this.Controls.Add(this.tbxSecondaryPhone);
            this.Controls.Add(this.tbxPrimaryPhone);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxZipcode);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxAddressThree);
            this.Controls.Add(this.tbxAddressTwo);
            this.Controls.Add(this.tbxAddressOne);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxMiddleName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblSecondaryPhone);
            this.Controls.Add(this.lblPrimaryPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblZipcode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddressThree);
            this.Controls.Add(this.lblAddressTwo);
            this.Controls.Add(this.lblAddressOne);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvPersonnel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmPersonnel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonnel_FormClosing);
            this.Load += new System.EventHandler(this.frmPersonnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteManager;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNewManager;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.ComboBox cbxSuffix;
        private System.Windows.Forms.ComboBox cbxTitle;
        private System.Windows.Forms.TextBox tbxSecondaryPhone;
        private System.Windows.Forms.TextBox tbxPrimaryPhone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxZipcode;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxAddressThree;
        private System.Windows.Forms.TextBox tbxAddressTwo;
        private System.Windows.Forms.TextBox tbxAddressOne;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblSecondaryPhone;
        private System.Windows.Forms.Label lblPrimaryPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressThree;
        private System.Windows.Forms.Label lblAddressTwo;
        private System.Windows.Forms.Label lblAddressOne;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Button btnDisableAccount;
        private System.Windows.Forms.Button btnEnableAccount;
    }
}