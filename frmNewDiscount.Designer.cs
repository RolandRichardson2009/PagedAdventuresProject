namespace FinalProject
{
    partial class frmNewDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewDiscount));
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.tbxExpirationDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tbxStartDate = new System.Windows.Forms.TextBox();
            this.lblDiscountDollarAmount = new System.Windows.Forms.Label();
            this.tbxDiscountDollarAmount = new System.Windows.Forms.TextBox();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.tbxDiscountPercentage = new System.Windows.Forms.TextBox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.tbxDiscountType = new System.Windows.Forms.TextBox();
            this.lblInventoryID = new System.Windows.Forms.Label();
            this.tbxInventoryID = new System.Windows.Forms.TextBox();
            this.lblDiscountLevel = new System.Windows.Forms.Label();
            this.tbxDiscountLevel = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.tbxDiscountCode = new System.Windows.Forms.TextBox();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.lblRequired = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(84, 295);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(266, 24);
            this.lblExpirationDate.TabIndex = 37;
            this.lblExpirationDate.Text = "Expiration Date: (mm/dd/yyyy)*";
            // 
            // tbxExpirationDate
            // 
            this.tbxExpirationDate.Location = new System.Drawing.Point(372, 292);
            this.tbxExpirationDate.Name = "tbxExpirationDate";
            this.tbxExpirationDate.Size = new System.Drawing.Size(298, 29);
            this.tbxExpirationDate.TabIndex = 8;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(139, 260);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(211, 24);
            this.lblStartDate.TabIndex = 35;
            this.lblStartDate.Text = "Start Date: (mm/dd/yyyy)";
            // 
            // tbxStartDate
            // 
            this.tbxStartDate.Location = new System.Drawing.Point(372, 257);
            this.tbxStartDate.Name = "tbxStartDate";
            this.tbxStartDate.Size = new System.Drawing.Size(298, 29);
            this.tbxStartDate.TabIndex = 7;
            // 
            // lblDiscountDollarAmount
            // 
            this.lblDiscountDollarAmount.AutoSize = true;
            this.lblDiscountDollarAmount.Location = new System.Drawing.Point(6, 225);
            this.lblDiscountDollarAmount.Name = "lblDiscountDollarAmount";
            this.lblDiscountDollarAmount.Size = new System.Drawing.Size(360, 24);
            this.lblDiscountDollarAmount.TabIndex = 33;
            this.lblDiscountDollarAmount.Text = "Discount Dollar Amount: (Enter a decimal)";
            // 
            // tbxDiscountDollarAmount
            // 
            this.tbxDiscountDollarAmount.Location = new System.Drawing.Point(372, 222);
            this.tbxDiscountDollarAmount.MaxLength = 13;
            this.tbxDiscountDollarAmount.Name = "tbxDiscountDollarAmount";
            this.tbxDiscountDollarAmount.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountDollarAmount.TabIndex = 6;
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.Location = new System.Drawing.Point(28, 190);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(338, 24);
            this.lblDiscountPercentage.TabIndex = 31;
            this.lblDiscountPercentage.Text = "Discount Percentage: (Enter a decimal)";
            // 
            // tbxDiscountPercentage
            // 
            this.tbxDiscountPercentage.Location = new System.Drawing.Point(372, 187);
            this.tbxDiscountPercentage.MaxLength = 5;
            this.tbxDiscountPercentage.Name = "tbxDiscountPercentage";
            this.tbxDiscountPercentage.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountPercentage.TabIndex = 5;
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(19, 155);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(347, 24);
            this.lblDiscountType.TabIndex = 29;
            this.lblDiscountType.Text = "Discount Type: (Enter a whole number)*";
            // 
            // tbxDiscountType
            // 
            this.tbxDiscountType.Location = new System.Drawing.Point(372, 152);
            this.tbxDiscountType.Name = "tbxDiscountType";
            this.tbxDiscountType.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountType.TabIndex = 4;
            // 
            // lblInventoryID
            // 
            this.lblInventoryID.AutoSize = true;
            this.lblInventoryID.Location = new System.Drawing.Point(49, 120);
            this.lblInventoryID.Name = "lblInventoryID";
            this.lblInventoryID.Size = new System.Drawing.Size(317, 24);
            this.lblInventoryID.TabIndex = 27;
            this.lblInventoryID.Text = "Inventory ID: (Enter a whole number)";
            // 
            // tbxInventoryID
            // 
            this.tbxInventoryID.Location = new System.Drawing.Point(372, 117);
            this.tbxInventoryID.Name = "tbxInventoryID";
            this.tbxInventoryID.Size = new System.Drawing.Size(298, 29);
            this.tbxInventoryID.TabIndex = 3;
            // 
            // lblDiscountLevel
            // 
            this.lblDiscountLevel.AutoSize = true;
            this.lblDiscountLevel.Location = new System.Drawing.Point(17, 85);
            this.lblDiscountLevel.Name = "lblDiscountLevel";
            this.lblDiscountLevel.Size = new System.Drawing.Size(349, 24);
            this.lblDiscountLevel.TabIndex = 25;
            this.lblDiscountLevel.Text = "Discount Level: (Enter a whole number)*";
            // 
            // tbxDiscountLevel
            // 
            this.tbxDiscountLevel.Location = new System.Drawing.Point(372, 82);
            this.tbxDiscountLevel.Name = "tbxDiscountLevel";
            this.tbxDiscountLevel.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountLevel.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(245, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(121, 24);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "Description: *";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(372, 47);
            this.tbxDescription.MaxLength = 50;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(298, 29);
            this.tbxDescription.TabIndex = 1;
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Location = new System.Drawing.Point(215, 15);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(151, 24);
            this.lblDiscountCode.TabIndex = 21;
            this.lblDiscountCode.Text = "Discount Code: *";
            // 
            // tbxDiscountCode
            // 
            this.tbxDiscountCode.Location = new System.Drawing.Point(372, 12);
            this.tbxDiscountCode.MaxLength = 20;
            this.tbxDiscountCode.Name = "tbxDiscountCode";
            this.tbxDiscountCode.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountCode.TabIndex = 0;
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Location = new System.Drawing.Point(372, 327);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(93, 57);
            this.btnAddDiscount.TabIndex = 9;
            this.btnAddDiscount.Text = "&Add Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(570, 327);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(100, 24);
            this.lblRequired.TabIndex = 39;
            this.lblRequired.Text = "* Required";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(471, 327);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 57);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmNewDiscount
            // 
            this.AcceptButton = this.btnAddDiscount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(687, 394);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.btnAddDiscount);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.tbxExpirationDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.tbxStartDate);
            this.Controls.Add(this.lblDiscountDollarAmount);
            this.Controls.Add(this.tbxDiscountDollarAmount);
            this.Controls.Add(this.lblDiscountPercentage);
            this.Controls.Add(this.tbxDiscountPercentage);
            this.Controls.Add(this.lblDiscountType);
            this.Controls.Add(this.tbxDiscountType);
            this.Controls.Add(this.lblInventoryID);
            this.Controls.Add(this.tbxInventoryID);
            this.Controls.Add(this.lblDiscountLevel);
            this.Controls.Add(this.tbxDiscountLevel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblDiscountCode);
            this.Controls.Add(this.tbxDiscountCode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmNewDiscount";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Discount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox tbxExpirationDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox tbxStartDate;
        private System.Windows.Forms.Label lblDiscountDollarAmount;
        private System.Windows.Forms.TextBox tbxDiscountDollarAmount;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.TextBox tbxDiscountPercentage;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.TextBox tbxDiscountType;
        private System.Windows.Forms.Label lblInventoryID;
        private System.Windows.Forms.TextBox tbxInventoryID;
        private System.Windows.Forms.Label lblDiscountLevel;
        private System.Windows.Forms.TextBox tbxDiscountLevel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.TextBox tbxDiscountCode;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Button btnBack;
    }
}