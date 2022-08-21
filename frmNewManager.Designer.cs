namespace FinalProject
{
    partial class frmNewManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewManager));
            this.btnAddCustomer = new System.Windows.Forms.Button();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(718, 255);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(101, 62);
            this.btnAddCustomer.TabIndex = 92;
            this.btnAddCustomer.Text = "&Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddManager_Click);
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
            this.cbxState.Location = new System.Drawing.Point(665, 115);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(275, 32);
            this.cbxState.TabIndex = 91;
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
            this.cbxSuffix.Location = new System.Drawing.Point(141, 148);
            this.cbxSuffix.Name = "cbxSuffix";
            this.cbxSuffix.Size = new System.Drawing.Size(275, 32);
            this.cbxSuffix.TabIndex = 90;
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
            this.cbxTitle.Location = new System.Drawing.Point(141, 13);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(275, 32);
            this.cbxTitle.TabIndex = 89;
            // 
            // tbxSecondaryPhone
            // 
            this.tbxSecondaryPhone.Location = new System.Drawing.Point(665, 220);
            this.tbxSecondaryPhone.MaxLength = 20;
            this.tbxSecondaryPhone.Name = "tbxSecondaryPhone";
            this.tbxSecondaryPhone.Size = new System.Drawing.Size(275, 29);
            this.tbxSecondaryPhone.TabIndex = 88;
            // 
            // tbxPrimaryPhone
            // 
            this.tbxPrimaryPhone.Location = new System.Drawing.Point(665, 186);
            this.tbxPrimaryPhone.MaxLength = 20;
            this.tbxPrimaryPhone.Name = "tbxPrimaryPhone";
            this.tbxPrimaryPhone.Size = new System.Drawing.Size(275, 29);
            this.tbxPrimaryPhone.TabIndex = 87;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(665, 152);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(275, 29);
            this.tbxEmail.TabIndex = 86;
            // 
            // tbxZipcode
            // 
            this.tbxZipcode.Location = new System.Drawing.Point(665, 81);
            this.tbxZipcode.MaxLength = 10;
            this.tbxZipcode.Name = "tbxZipcode";
            this.tbxZipcode.Size = new System.Drawing.Size(275, 29);
            this.tbxZipcode.TabIndex = 85;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(665, 47);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(275, 29);
            this.tbxCity.TabIndex = 84;
            // 
            // tbxAddressThree
            // 
            this.tbxAddressThree.Location = new System.Drawing.Point(665, 13);
            this.tbxAddressThree.MaxLength = 30;
            this.tbxAddressThree.Name = "tbxAddressThree";
            this.tbxAddressThree.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressThree.TabIndex = 83;
            // 
            // tbxAddressTwo
            // 
            this.tbxAddressTwo.Location = new System.Drawing.Point(141, 221);
            this.tbxAddressTwo.MaxLength = 30;
            this.tbxAddressTwo.Name = "tbxAddressTwo";
            this.tbxAddressTwo.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressTwo.TabIndex = 82;
            // 
            // tbxAddressOne
            // 
            this.tbxAddressOne.Location = new System.Drawing.Point(141, 184);
            this.tbxAddressOne.MaxLength = 30;
            this.tbxAddressOne.Name = "tbxAddressOne";
            this.tbxAddressOne.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressOne.TabIndex = 81;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(141, 115);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(275, 29);
            this.tbxLastName.TabIndex = 80;
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(141, 82);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(275, 29);
            this.tbxMiddleName.TabIndex = 79;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(141, 49);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(275, 29);
            this.tbxFirstName.TabIndex = 78;
            // 
            // lblSecondaryPhone
            // 
            this.lblSecondaryPhone.AutoSize = true;
            this.lblSecondaryPhone.Location = new System.Drawing.Point(492, 220);
            this.lblSecondaryPhone.Name = "lblSecondaryPhone";
            this.lblSecondaryPhone.Size = new System.Drawing.Size(167, 24);
            this.lblSecondaryPhone.TabIndex = 77;
            this.lblSecondaryPhone.Text = "Secondary Phone:";
            // 
            // lblPrimaryPhone
            // 
            this.lblPrimaryPhone.AutoSize = true;
            this.lblPrimaryPhone.Location = new System.Drawing.Point(520, 186);
            this.lblPrimaryPhone.Name = "lblPrimaryPhone";
            this.lblPrimaryPhone.Size = new System.Drawing.Size(139, 24);
            this.lblPrimaryPhone.TabIndex = 76;
            this.lblPrimaryPhone.Text = "Primary Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(597, 152);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "Email:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(591, 118);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 24);
            this.lblState.TabIndex = 74;
            this.lblState.Text = "* State:";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(562, 84);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(97, 24);
            this.lblZipcode.TabIndex = 73;
            this.lblZipcode.Text = "* Zipcode:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(602, 50);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 24);
            this.lblCity.TabIndex = 72;
            this.lblCity.Text = "* City:";
            // 
            // lblAddressThree
            // 
            this.lblAddressThree.AutoSize = true;
            this.lblAddressThree.Location = new System.Drawing.Point(559, 16);
            this.lblAddressThree.Name = "lblAddressThree";
            this.lblAddressThree.Size = new System.Drawing.Size(100, 24);
            this.lblAddressThree.TabIndex = 71;
            this.lblAddressThree.Text = "Address 3:";
            // 
            // lblAddressTwo
            // 
            this.lblAddressTwo.AutoSize = true;
            this.lblAddressTwo.Location = new System.Drawing.Point(35, 221);
            this.lblAddressTwo.Name = "lblAddressTwo";
            this.lblAddressTwo.Size = new System.Drawing.Size(100, 24);
            this.lblAddressTwo.TabIndex = 70;
            this.lblAddressTwo.Text = "Address 2:";
            // 
            // lblAddressOne
            // 
            this.lblAddressOne.AutoSize = true;
            this.lblAddressOne.Location = new System.Drawing.Point(23, 186);
            this.lblAddressOne.Name = "lblAddressOne";
            this.lblAddressOne.Size = new System.Drawing.Size(112, 24);
            this.lblAddressOne.TabIndex = 69;
            this.lblAddressOne.Text = "* Address 1:";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(75, 152);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(60, 24);
            this.lblSuffix.TabIndex = 68;
            this.lblSuffix.Text = "Suffix:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(19, 118);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(116, 24);
            this.lblLastName.TabIndex = 67;
            this.lblLastName.Text = "* Last Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(7, 84);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(128, 24);
            this.lblMiddleName.TabIndex = 66;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(118, 24);
            this.lblFirstName.TabIndex = 65;
            this.lblFirstName.Text = "* First Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(85, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 24);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "Title:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(825, 255);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 62);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmNewManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 330);
            this.Controls.Add(this.btnAddCustomer);
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
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmNewManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewManager_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
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
        private System.Windows.Forms.Button btnBack;
    }
}