namespace FinalProject
{
    partial class frmDiscounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscounts));
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvDiscounts = new System.Windows.Forms.DataGridView();
            this.tbxDiscountCode = new System.Windows.Forms.TextBox();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDiscountLevel = new System.Windows.Forms.Label();
            this.tbxDiscountLevel = new System.Windows.Forms.TextBox();
            this.lblInventoryID = new System.Windows.Forms.Label();
            this.tbxInventoryID = new System.Windows.Forms.TextBox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            this.tbxDiscountType = new System.Windows.Forms.TextBox();
            this.lblDiscountPercentage = new System.Windows.Forms.Label();
            this.tbxDiscountPercentage = new System.Windows.Forms.TextBox();
            this.lblDiscountDollarAmount = new System.Windows.Forms.Label();
            this.tbxDiscountDollarAmount = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tbxStartDate = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.tbxExpirationDate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblRequired = new System.Windows.Forms.Label();
            this.btnDeleteCode = new System.Windows.Forms.Button();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(1147, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvDiscounts
            // 
            this.dgvDiscounts.AllowUserToAddRows = false;
            this.dgvDiscounts.AllowUserToDeleteRows = false;
            this.dgvDiscounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDiscounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscounts.Location = new System.Drawing.Point(12, 12);
            this.dgvDiscounts.MultiSelect = false;
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.ReadOnly = true;
            this.dgvDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscounts.Size = new System.Drawing.Size(1783, 443);
            this.dgvDiscounts.TabIndex = 1;
            this.dgvDiscounts.TabStop = false;
            this.dgvDiscounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscounts_CellClick);
            // 
            // tbxDiscountCode
            // 
            this.tbxDiscountCode.Location = new System.Drawing.Point(1497, 496);
            this.tbxDiscountCode.MaxLength = 20;
            this.tbxDiscountCode.Name = "tbxDiscountCode";
            this.tbxDiscountCode.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountCode.TabIndex = 1;
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Location = new System.Drawing.Point(1341, 499);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(151, 24);
            this.lblDiscountCode.TabIndex = 3;
            this.lblDiscountCode.Text = "Discount Code: *";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(1372, 534);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(121, 24);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description: *";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(1497, 531);
            this.tbxDescription.MaxLength = 50;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(298, 29);
            this.tbxDescription.TabIndex = 2;
            // 
            // lblDiscountLevel
            // 
            this.lblDiscountLevel.AutoSize = true;
            this.lblDiscountLevel.Location = new System.Drawing.Point(1345, 569);
            this.lblDiscountLevel.Name = "lblDiscountLevel";
            this.lblDiscountLevel.Size = new System.Drawing.Size(150, 24);
            this.lblDiscountLevel.TabIndex = 7;
            this.lblDiscountLevel.Text = "Discount Level: *";
            // 
            // tbxDiscountLevel
            // 
            this.tbxDiscountLevel.Location = new System.Drawing.Point(1497, 566);
            this.tbxDiscountLevel.Name = "tbxDiscountLevel";
            this.tbxDiscountLevel.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountLevel.TabIndex = 3;
            // 
            // lblInventoryID
            // 
            this.lblInventoryID.AutoSize = true;
            this.lblInventoryID.Location = new System.Drawing.Point(1378, 604);
            this.lblInventoryID.Name = "lblInventoryID";
            this.lblInventoryID.Size = new System.Drawing.Size(113, 24);
            this.lblInventoryID.TabIndex = 9;
            this.lblInventoryID.Text = "Inventory ID:";
            // 
            // tbxInventoryID
            // 
            this.tbxInventoryID.Location = new System.Drawing.Point(1497, 601);
            this.tbxInventoryID.Name = "tbxInventoryID";
            this.tbxInventoryID.Size = new System.Drawing.Size(298, 29);
            this.tbxInventoryID.TabIndex = 4;
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(1347, 639);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(148, 24);
            this.lblDiscountType.TabIndex = 11;
            this.lblDiscountType.Text = "Discount Type: *";
            // 
            // tbxDiscountType
            // 
            this.tbxDiscountType.Location = new System.Drawing.Point(1497, 636);
            this.tbxDiscountType.Name = "tbxDiscountType";
            this.tbxDiscountType.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountType.TabIndex = 5;
            // 
            // lblDiscountPercentage
            // 
            this.lblDiscountPercentage.AutoSize = true;
            this.lblDiscountPercentage.Location = new System.Drawing.Point(1301, 674);
            this.lblDiscountPercentage.Name = "lblDiscountPercentage";
            this.lblDiscountPercentage.Size = new System.Drawing.Size(190, 24);
            this.lblDiscountPercentage.TabIndex = 13;
            this.lblDiscountPercentage.Text = "Discount Percentage:";
            // 
            // tbxDiscountPercentage
            // 
            this.tbxDiscountPercentage.Location = new System.Drawing.Point(1497, 671);
            this.tbxDiscountPercentage.MaxLength = 5;
            this.tbxDiscountPercentage.Name = "tbxDiscountPercentage";
            this.tbxDiscountPercentage.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountPercentage.TabIndex = 6;
            // 
            // lblDiscountDollarAmount
            // 
            this.lblDiscountDollarAmount.AutoSize = true;
            this.lblDiscountDollarAmount.Location = new System.Drawing.Point(1279, 709);
            this.lblDiscountDollarAmount.Name = "lblDiscountDollarAmount";
            this.lblDiscountDollarAmount.Size = new System.Drawing.Size(212, 24);
            this.lblDiscountDollarAmount.TabIndex = 15;
            this.lblDiscountDollarAmount.Text = "Discount Dollar Amount:";
            // 
            // tbxDiscountDollarAmount
            // 
            this.tbxDiscountDollarAmount.Location = new System.Drawing.Point(1497, 706);
            this.tbxDiscountDollarAmount.MaxLength = 13;
            this.tbxDiscountDollarAmount.Name = "tbxDiscountDollarAmount";
            this.tbxDiscountDollarAmount.Size = new System.Drawing.Size(298, 29);
            this.tbxDiscountDollarAmount.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(1397, 744);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 17;
            this.lblStartDate.Text = "Start Date:";
            // 
            // tbxStartDate
            // 
            this.tbxStartDate.Location = new System.Drawing.Point(1497, 741);
            this.tbxStartDate.Name = "tbxStartDate";
            this.tbxStartDate.Size = new System.Drawing.Size(298, 29);
            this.tbxStartDate.TabIndex = 8;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(1338, 779);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(154, 24);
            this.lblExpirationDate.TabIndex = 19;
            this.lblExpirationDate.Text = "Expiration Date: *";
            // 
            // tbxExpirationDate
            // 
            this.tbxExpirationDate.Location = new System.Drawing.Point(1497, 776);
            this.tbxExpirationDate.Name = "tbxExpirationDate";
            this.tbxExpirationDate.Size = new System.Drawing.Size(298, 29);
            this.tbxExpirationDate.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1147, 499);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 40);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1147, 591);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(79, 59);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(1695, 469);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(100, 24);
            this.lblRequired.TabIndex = 40;
            this.lblRequired.Text = "* Required";
            // 
            // btnDeleteCode
            // 
            this.btnDeleteCode.Location = new System.Drawing.Point(1147, 657);
            this.btnDeleteCode.Name = "btnDeleteCode";
            this.btnDeleteCode.Size = new System.Drawing.Size(79, 59);
            this.btnDeleteCode.TabIndex = 13;
            this.btnDeleteCode.Text = "&Delete Code";
            this.btnDeleteCode.UseVisualStyleBackColor = true;
            this.btnDeleteCode.Click += new System.EventHandler(this.btnDeleteCode_Click);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(1147, 722);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(83, 56);
            this.btnRefreshTable.TabIndex = 14;
            this.btnRefreshTable.Text = "&Refresh Table";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // frmDiscounts
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1807, 817);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.btnDeleteCode);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnUpdate);
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
            this.Controls.Add(this.dgvDiscounts);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmDiscounts";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Discounts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDiscounts_FormClosing);
            this.Load += new System.EventHandler(this.frmDiscounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvDiscounts;
        private System.Windows.Forms.TextBox tbxDiscountCode;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDiscountLevel;
        private System.Windows.Forms.TextBox tbxDiscountLevel;
        private System.Windows.Forms.Label lblInventoryID;
        private System.Windows.Forms.TextBox tbxInventoryID;
        private System.Windows.Forms.Label lblDiscountType;
        private System.Windows.Forms.TextBox tbxDiscountType;
        private System.Windows.Forms.Label lblDiscountPercentage;
        private System.Windows.Forms.TextBox tbxDiscountPercentage;
        private System.Windows.Forms.Label lblDiscountDollarAmount;
        private System.Windows.Forms.TextBox tbxDiscountDollarAmount;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox tbxStartDate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox tbxExpirationDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Button btnDeleteCode;
        private System.Windows.Forms.Button btnRefreshTable;
    }
}