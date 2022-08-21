namespace FinalProject
{
    partial class frmNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCustomer));
            this.btnBack = new System.Windows.Forms.Button();
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(824, 254);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 62);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.cbxState.Location = new System.Drawing.Point(664, 114);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(275, 32);
            this.cbxState.TabIndex = 61;
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
            this.cbxSuffix.Location = new System.Drawing.Point(140, 147);
            this.cbxSuffix.Name = "cbxSuffix";
            this.cbxSuffix.Size = new System.Drawing.Size(275, 32);
            this.cbxSuffix.TabIndex = 60;
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
            this.cbxTitle.Location = new System.Drawing.Point(140, 12);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(275, 32);
            this.cbxTitle.TabIndex = 59;
            // 
            // tbxSecondaryPhone
            // 
            this.tbxSecondaryPhone.Location = new System.Drawing.Point(664, 219);
            this.tbxSecondaryPhone.MaxLength = 20;
            this.tbxSecondaryPhone.Name = "tbxSecondaryPhone";
            this.tbxSecondaryPhone.Size = new System.Drawing.Size(275, 29);
            this.tbxSecondaryPhone.TabIndex = 58;
            // 
            // tbxPrimaryPhone
            // 
            this.tbxPrimaryPhone.Location = new System.Drawing.Point(664, 185);
            this.tbxPrimaryPhone.MaxLength = 20;
            this.tbxPrimaryPhone.Name = "tbxPrimaryPhone";
            this.tbxPrimaryPhone.Size = new System.Drawing.Size(275, 29);
            this.tbxPrimaryPhone.TabIndex = 57;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(664, 151);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(275, 29);
            this.tbxEmail.TabIndex = 56;
            // 
            // tbxZipcode
            // 
            this.tbxZipcode.Location = new System.Drawing.Point(664, 80);
            this.tbxZipcode.MaxLength = 10;
            this.tbxZipcode.Name = "tbxZipcode";
            this.tbxZipcode.Size = new System.Drawing.Size(275, 29);
            this.tbxZipcode.TabIndex = 55;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(664, 46);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(275, 29);
            this.tbxCity.TabIndex = 54;
            // 
            // tbxAddressThree
            // 
            this.tbxAddressThree.Location = new System.Drawing.Point(664, 12);
            this.tbxAddressThree.MaxLength = 30;
            this.tbxAddressThree.Name = "tbxAddressThree";
            this.tbxAddressThree.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressThree.TabIndex = 53;
            // 
            // tbxAddressTwo
            // 
            this.tbxAddressTwo.Location = new System.Drawing.Point(140, 220);
            this.tbxAddressTwo.MaxLength = 30;
            this.tbxAddressTwo.Name = "tbxAddressTwo";
            this.tbxAddressTwo.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressTwo.TabIndex = 52;
            // 
            // tbxAddressOne
            // 
            this.tbxAddressOne.Location = new System.Drawing.Point(140, 183);
            this.tbxAddressOne.MaxLength = 30;
            this.tbxAddressOne.Name = "tbxAddressOne";
            this.tbxAddressOne.Size = new System.Drawing.Size(275, 29);
            this.tbxAddressOne.TabIndex = 51;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(140, 114);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(275, 29);
            this.tbxLastName.TabIndex = 50;
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(140, 81);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(275, 29);
            this.tbxMiddleName.TabIndex = 49;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(140, 48);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(275, 29);
            this.tbxFirstName.TabIndex = 48;
            // 
            // lblSecondaryPhone
            // 
            this.lblSecondaryPhone.AutoSize = true;
            this.lblSecondaryPhone.Location = new System.Drawing.Point(491, 219);
            this.lblSecondaryPhone.Name = "lblSecondaryPhone";
            this.lblSecondaryPhone.Size = new System.Drawing.Size(167, 24);
            this.lblSecondaryPhone.TabIndex = 47;
            this.lblSecondaryPhone.Text = "Secondary Phone:";
            // 
            // lblPrimaryPhone
            // 
            this.lblPrimaryPhone.AutoSize = true;
            this.lblPrimaryPhone.Location = new System.Drawing.Point(519, 185);
            this.lblPrimaryPhone.Name = "lblPrimaryPhone";
            this.lblPrimaryPhone.Size = new System.Drawing.Size(139, 24);
            this.lblPrimaryPhone.TabIndex = 46;
            this.lblPrimaryPhone.Text = "Primary Phone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(596, 151);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Email:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(590, 117);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 24);
            this.lblState.TabIndex = 44;
            this.lblState.Text = "* State:";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(561, 83);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(97, 24);
            this.lblZipcode.TabIndex = 43;
            this.lblZipcode.Text = "* Zipcode:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(601, 49);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(57, 24);
            this.lblCity.TabIndex = 42;
            this.lblCity.Text = "* City:";
            // 
            // lblAddressThree
            // 
            this.lblAddressThree.AutoSize = true;
            this.lblAddressThree.Location = new System.Drawing.Point(558, 15);
            this.lblAddressThree.Name = "lblAddressThree";
            this.lblAddressThree.Size = new System.Drawing.Size(100, 24);
            this.lblAddressThree.TabIndex = 41;
            this.lblAddressThree.Text = "Address 3:";
            // 
            // lblAddressTwo
            // 
            this.lblAddressTwo.AutoSize = true;
            this.lblAddressTwo.Location = new System.Drawing.Point(34, 220);
            this.lblAddressTwo.Name = "lblAddressTwo";
            this.lblAddressTwo.Size = new System.Drawing.Size(100, 24);
            this.lblAddressTwo.TabIndex = 40;
            this.lblAddressTwo.Text = "Address 2:";
            // 
            // lblAddressOne
            // 
            this.lblAddressOne.AutoSize = true;
            this.lblAddressOne.Location = new System.Drawing.Point(22, 185);
            this.lblAddressOne.Name = "lblAddressOne";
            this.lblAddressOne.Size = new System.Drawing.Size(112, 24);
            this.lblAddressOne.TabIndex = 39;
            this.lblAddressOne.Text = "* Address 1:";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(74, 151);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(60, 24);
            this.lblSuffix.TabIndex = 38;
            this.lblSuffix.Text = "Suffix:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(18, 117);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(116, 24);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "* Last Name:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(6, 83);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(128, 24);
            this.lblMiddleName.TabIndex = 36;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(16, 49);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(118, 24);
            this.lblFirstName.TabIndex = 35;
            this.lblFirstName.Text = "* First Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(84, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 24);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Title:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(717, 254);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(101, 62);
            this.btnAddCustomer.TabIndex = 62;
            this.btnAddCustomer.Text = "&Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 329);
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
            this.Name = "frmNewCustomer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewCustomer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
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
        private System.Windows.Forms.Button btnAddCustomer;
    }
}