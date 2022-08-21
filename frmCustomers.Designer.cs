namespace FinalProject
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblAddressOne = new System.Windows.Forms.Label();
            this.lblAddressTwo = new System.Windows.Forms.Label();
            this.lblAddressThree = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrimaryPhone = new System.Windows.Forms.Label();
            this.lblSecondaryPhone = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxAddressOne = new System.Windows.Forms.TextBox();
            this.tbxAddressTwo = new System.Windows.Forms.TextBox();
            this.tbxAddressThree = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxZipcode = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPrimaryPhone = new System.Windows.Forms.TextBox();
            this.tbxSecondaryPhone = new System.Windows.Forms.TextBox();
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            this.cbxSuffix = new System.Windows.Forms.ComboBox();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.btnEnableAccount = new System.Windows.Forms.Button();
            this.btnDisableAccount = new System.Windows.Forms.Button();
            this.tbxSearchPrimaryPhone = new System.Windows.Forms.TextBox();
            this.gbxCustomerSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchPrimaryPhone = new System.Windows.Forms.Label();
            this.tbxSearchEmail = new System.Windows.Forms.TextBox();
            this.lblSearchEmail = new System.Windows.Forms.Label();
            this.tbxSearchLastName = new System.Windows.Forms.TextBox();
            this.lblSearchLastName = new System.Windows.Forms.Label();
            this.tbxSearchFirstName = new System.Windows.Forms.TextBox();
            this.lblSearchFirstName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddSelectedCustomerToPOSScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbxCustomerSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1378, 323);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 59);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1785, 305);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.TabStop = false;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(85, 326);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 360);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(118, 24);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "* First Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(7, 394);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(128, 24);
            this.lblMiddleName.TabIndex = 4;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(19, 428);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(116, 24);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "* Last Name:";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(75, 462);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(60, 24);
            this.lblSuffix.TabIndex = 6;
            this.lblSuffix.Text = "Suffix:";
            // 
            // lblAddressOne
            // 
            this.lblAddressOne.AutoSize = true;
            this.lblAddressOne.Location = new System.Drawing.Point(23, 496);
            this.lblAddressOne.Name = "lblAddressOne";
            this.lblAddressOne.Size = new System.Drawing.Size(112, 24);
            this.lblAddressOne.TabIndex = 7;
            this.lblAddressOne.Text = "* Address 1:";
            // 
            // lblAddressTwo
            // 
            this.lblAddressTwo.AutoSize = true;
            this.lblAddressTwo.Location = new System.Drawing.Point(35, 531);
            this.lblAddressTwo.Name = "lblAddressTwo";
            this.lblAddressTwo.Size = new System.Drawing.Size(100, 24);
            this.lblAddressTwo.TabIndex = 8;
            this.lblAddressTwo.Text = "Address 2:";
            // 
            // lblAddressThree
            // 
            this.lblAddressThree.AutoSize = true;
            this.lblAddressThree.Location = new System.Drawing.Point(559, 326);
            this.lblAddressThree.Name = "lblAddressThree";
            this.lblAddressThree.Size = new System.Drawing.Size(100, 24);
            this.lblAddressThree.TabIndex = 9;
            this.lblAddressThree.Text = "Address 3:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(602, 360);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 24);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "* City:";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(562, 394);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(97, 24);
            this.lblZipcode.TabIndex = 11;
            this.lblZipcode.Text = "* Zipcode:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(591, 428);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 24);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "* State:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(597, 462);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // lblPrimaryPhone
            // 
            this.lblPrimaryPhone.AutoSize = true;
            this.lblPrimaryPhone.Location = new System.Drawing.Point(520, 496);
            this.lblPrimaryPhone.Name = "lblPrimaryPhone";
            this.lblPrimaryPhone.Size = new System.Drawing.Size(139, 24);
            this.lblPrimaryPhone.TabIndex = 14;
            this.lblPrimaryPhone.Text = "Primary Phone:";
            // 
            // lblSecondaryPhone
            // 
            this.lblSecondaryPhone.AutoSize = true;
            this.lblSecondaryPhone.Location = new System.Drawing.Point(492, 530);
            this.lblSecondaryPhone.Name = "lblSecondaryPhone";
            this.lblSecondaryPhone.Size = new System.Drawing.Size(167, 24);
            this.lblSecondaryPhone.TabIndex = 15;
            this.lblSecondaryPhone.Text = "Secondary Phone:";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(316, 559);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(100, 24);
            this.lblRequired.TabIndex = 16;
            this.lblRequired.Text = "* Required";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(141, 359);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(275, 29);
            this.tbxFirstName.TabIndex = 18;
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(141, 392);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(275, 29);
            this.tbxMiddleName.TabIndex = 19;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(141, 425);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(275, 29);
            this.tbxLastName.TabIndex = 20;
            // 
            // tbxAddressOne
            // 
            this.tbxAddressOne.Location = new System.Drawing.Point(141, 494);
            this.tbxAddressOne.MaxLength = 30;
            this.tbxAddressOne.Name = "tbxAddressOne";
            this.tbxAddressOne.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressOne.TabIndex = 22;
            // 
            // tbxAddressTwo
            // 
            this.tbxAddressTwo.Location = new System.Drawing.Point(141, 527);
            this.tbxAddressTwo.MaxLength = 30;
            this.tbxAddressTwo.Name = "tbxAddressTwo";
            this.tbxAddressTwo.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressTwo.TabIndex = 23;
            // 
            // tbxAddressThree
            // 
            this.tbxAddressThree.Location = new System.Drawing.Point(665, 323);
            this.tbxAddressThree.MaxLength = 30;
            this.tbxAddressThree.Name = "tbxAddressThree";
            this.tbxAddressThree.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressThree.TabIndex = 24;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(665, 357);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(275, 29);
            this.tbxCity.TabIndex = 25;
            // 
            // tbxZipcode
            // 
            this.tbxZipcode.Location = new System.Drawing.Point(665, 391);
            this.tbxZipcode.MaxLength = 10;
            this.tbxZipcode.Name = "tbxZipcode";
            this.tbxZipcode.Size = new System.Drawing.Size(275, 29);
            this.tbxZipcode.TabIndex = 26;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(665, 462);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(275, 29);
            this.tbxEmail.TabIndex = 28;
            // 
            // tbxPrimaryPhone
            // 
            this.tbxPrimaryPhone.Location = new System.Drawing.Point(665, 496);
            this.tbxPrimaryPhone.MaxLength = 20;
            this.tbxPrimaryPhone.Name = "tbxPrimaryPhone";
            this.tbxPrimaryPhone.Size = new System.Drawing.Size(275, 29);
            this.tbxPrimaryPhone.TabIndex = 29;
            // 
            // tbxSecondaryPhone
            // 
            this.tbxSecondaryPhone.Location = new System.Drawing.Point(665, 530);
            this.tbxSecondaryPhone.MaxLength = 20;
            this.tbxSecondaryPhone.Name = "tbxSecondaryPhone";
            this.tbxSecondaryPhone.Size = new System.Drawing.Size(275, 29);
            this.tbxSecondaryPhone.TabIndex = 30;
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
            this.cbxTitle.TabIndex = 31;
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
            this.cbxSuffix.TabIndex = 32;
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
            this.cbxState.TabIndex = 33;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(946, 323);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(102, 59);
            this.btnNewCustomer.TabIndex = 34;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1054, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 59);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(1162, 323);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(102, 59);
            this.btnDeleteCustomer.TabIndex = 36;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(1270, 323);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(102, 59);
            this.btnRefreshTable.TabIndex = 37;
            this.btnRefreshTable.Text = "Refresh Table";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // btnEnableAccount
            // 
            this.btnEnableAccount.Location = new System.Drawing.Point(1594, 323);
            this.btnEnableAccount.Name = "btnEnableAccount";
            this.btnEnableAccount.Size = new System.Drawing.Size(102, 59);
            this.btnEnableAccount.TabIndex = 77;
            this.btnEnableAccount.Text = "Enable Account";
            this.btnEnableAccount.UseVisualStyleBackColor = true;
            this.btnEnableAccount.Click += new System.EventHandler(this.btnEnableAccount_Click);
            // 
            // btnDisableAccount
            // 
            this.btnDisableAccount.Location = new System.Drawing.Point(1486, 323);
            this.btnDisableAccount.Name = "btnDisableAccount";
            this.btnDisableAccount.Size = new System.Drawing.Size(102, 59);
            this.btnDisableAccount.TabIndex = 76;
            this.btnDisableAccount.Text = "Disable Account";
            this.btnDisableAccount.UseVisualStyleBackColor = true;
            this.btnDisableAccount.Click += new System.EventHandler(this.btnDisableAccount_Click);
            // 
            // tbxSearchPrimaryPhone
            // 
            this.tbxSearchPrimaryPhone.Location = new System.Drawing.Point(167, 34);
            this.tbxSearchPrimaryPhone.MaxLength = 20;
            this.tbxSearchPrimaryPhone.Name = "tbxSearchPrimaryPhone";
            this.tbxSearchPrimaryPhone.Size = new System.Drawing.Size(275, 29);
            this.tbxSearchPrimaryPhone.TabIndex = 79;
            // 
            // gbxCustomerSearch
            // 
            this.gbxCustomerSearch.Controls.Add(this.btnSearch);
            this.gbxCustomerSearch.Controls.Add(this.tbxSearchFirstName);
            this.gbxCustomerSearch.Controls.Add(this.lblSearchFirstName);
            this.gbxCustomerSearch.Controls.Add(this.tbxSearchLastName);
            this.gbxCustomerSearch.Controls.Add(this.lblSearchLastName);
            this.gbxCustomerSearch.Controls.Add(this.tbxSearchEmail);
            this.gbxCustomerSearch.Controls.Add(this.lblSearchEmail);
            this.gbxCustomerSearch.Controls.Add(this.lblSearchPrimaryPhone);
            this.gbxCustomerSearch.Controls.Add(this.tbxSearchPrimaryPhone);
            this.gbxCustomerSearch.Location = new System.Drawing.Point(984, 414);
            this.gbxCustomerSearch.Name = "gbxCustomerSearch";
            this.gbxCustomerSearch.Size = new System.Drawing.Size(462, 235);
            this.gbxCustomerSearch.TabIndex = 80;
            this.gbxCustomerSearch.TabStop = false;
            this.gbxCustomerSearch.Text = "Customer Search";
            // 
            // lblSearchPrimaryPhone
            // 
            this.lblSearchPrimaryPhone.AutoSize = true;
            this.lblSearchPrimaryPhone.Location = new System.Drawing.Point(22, 37);
            this.lblSearchPrimaryPhone.Name = "lblSearchPrimaryPhone";
            this.lblSearchPrimaryPhone.Size = new System.Drawing.Size(139, 24);
            this.lblSearchPrimaryPhone.TabIndex = 81;
            this.lblSearchPrimaryPhone.Text = "Primary Phone:";
            // 
            // tbxSearchEmail
            // 
            this.tbxSearchEmail.Location = new System.Drawing.Point(167, 69);
            this.tbxSearchEmail.MaxLength = 40;
            this.tbxSearchEmail.Name = "tbxSearchEmail";
            this.tbxSearchEmail.Size = new System.Drawing.Size(275, 29);
            this.tbxSearchEmail.TabIndex = 82;
            // 
            // lblSearchEmail
            // 
            this.lblSearchEmail.AutoSize = true;
            this.lblSearchEmail.Location = new System.Drawing.Point(99, 72);
            this.lblSearchEmail.Name = "lblSearchEmail";
            this.lblSearchEmail.Size = new System.Drawing.Size(62, 24);
            this.lblSearchEmail.TabIndex = 81;
            this.lblSearchEmail.Text = "Email:";
            // 
            // tbxSearchLastName
            // 
            this.tbxSearchLastName.Location = new System.Drawing.Point(167, 104);
            this.tbxSearchLastName.MaxLength = 20;
            this.tbxSearchLastName.Name = "tbxSearchLastName";
            this.tbxSearchLastName.Size = new System.Drawing.Size(275, 29);
            this.tbxSearchLastName.TabIndex = 82;
            // 
            // lblSearchLastName
            // 
            this.lblSearchLastName.AutoSize = true;
            this.lblSearchLastName.Location = new System.Drawing.Point(57, 107);
            this.lblSearchLastName.Name = "lblSearchLastName";
            this.lblSearchLastName.Size = new System.Drawing.Size(104, 24);
            this.lblSearchLastName.TabIndex = 81;
            this.lblSearchLastName.Text = "Last Name:";
            // 
            // tbxSearchFirstName
            // 
            this.tbxSearchFirstName.Location = new System.Drawing.Point(167, 139);
            this.tbxSearchFirstName.MaxLength = 20;
            this.tbxSearchFirstName.Name = "tbxSearchFirstName";
            this.tbxSearchFirstName.Size = new System.Drawing.Size(275, 29);
            this.tbxSearchFirstName.TabIndex = 82;
            // 
            // lblSearchFirstName
            // 
            this.lblSearchFirstName.AutoSize = true;
            this.lblSearchFirstName.Location = new System.Drawing.Point(55, 142);
            this.lblSearchFirstName.Name = "lblSearchFirstName";
            this.lblSearchFirstName.Size = new System.Drawing.Size(106, 24);
            this.lblSearchFirstName.TabIndex = 81;
            this.lblSearchFirstName.Text = "First Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(340, 174);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 41);
            this.btnSearch.TabIndex = 83;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddSelectedCustomerToPOSScreen
            // 
            this.btnAddSelectedCustomerToPOSScreen.Location = new System.Drawing.Point(1452, 388);
            this.btnAddSelectedCustomerToPOSScreen.Name = "btnAddSelectedCustomerToPOSScreen";
            this.btnAddSelectedCustomerToPOSScreen.Size = new System.Drawing.Size(136, 148);
            this.btnAddSelectedCustomerToPOSScreen.TabIndex = 81;
            this.btnAddSelectedCustomerToPOSScreen.Text = "Add Selected Customer to P.O.S. Screen";
            this.btnAddSelectedCustomerToPOSScreen.UseVisualStyleBackColor = true;
            this.btnAddSelectedCustomerToPOSScreen.Click += new System.EventHandler(this.btnAddSelectedCustomerToPOSScreen_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 813);
            this.Controls.Add(this.btnAddSelectedCustomerToPOSScreen);
            this.Controls.Add(this.gbxCustomerSearch);
            this.Controls.Add(this.btnEnableAccount);
            this.Controls.Add(this.btnDisableAccount);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNewCustomer);
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
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmCustomers";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomers_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbxCustomerSearch.ResumeLayout(false);
            this.gbxCustomerSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblAddressOne;
        private System.Windows.Forms.Label lblAddressTwo;
        private System.Windows.Forms.Label lblAddressThree;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrimaryPhone;
        private System.Windows.Forms.Label lblSecondaryPhone;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxAddressOne;
        private System.Windows.Forms.TextBox tbxAddressTwo;
        private System.Windows.Forms.TextBox tbxAddressThree;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxZipcode;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPrimaryPhone;
        private System.Windows.Forms.TextBox tbxSecondaryPhone;
        private System.Windows.Forms.ComboBox cbxTitle;
        private System.Windows.Forms.ComboBox cbxSuffix;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnRefreshTable;
        private System.Windows.Forms.Button btnEnableAccount;
        private System.Windows.Forms.Button btnDisableAccount;
        private System.Windows.Forms.TextBox tbxSearchPrimaryPhone;
        private System.Windows.Forms.GroupBox gbxCustomerSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearchFirstName;
        private System.Windows.Forms.Label lblSearchFirstName;
        private System.Windows.Forms.TextBox tbxSearchLastName;
        private System.Windows.Forms.Label lblSearchLastName;
        private System.Windows.Forms.TextBox tbxSearchEmail;
        private System.Windows.Forms.Label lblSearchEmail;
        private System.Windows.Forms.Label lblSearchPrimaryPhone;
        private System.Windows.Forms.Button btnAddSelectedCustomerToPOSScreen;
    }
}