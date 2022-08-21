namespace FinalProject
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.dgvInventoryManager = new System.Windows.Forms.DataGridView();
            this.btnSearchByTitle = new System.Windows.Forms.Button();
            this.tbxSearchByTitle = new System.Windows.Forms.TextBox();
            this.lblSearchByTitle = new System.Windows.Forms.Label();
            this.btnSearchByCategory = new System.Windows.Forms.Button();
            this.lblFilterByCategory = new System.Windows.Forms.Label();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.btnPlusOnePage = new System.Windows.Forms.Button();
            this.btnMinusOnePage = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRestockThreshold = new System.Windows.Forms.Label();
            this.tbxRestockThreshold = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblItemImage = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnEditImage = new System.Windows.Forms.Button();
            this.ckbDiscontinued = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventoryManager
            // 
            this.dgvInventoryManager.AllowUserToAddRows = false;
            this.dgvInventoryManager.AllowUserToDeleteRows = false;
            this.dgvInventoryManager.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventoryManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventoryManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryManager.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventoryManager.Location = new System.Drawing.Point(12, 12);
            this.dgvInventoryManager.MultiSelect = false;
            this.dgvInventoryManager.Name = "dgvInventoryManager";
            this.dgvInventoryManager.ReadOnly = true;
            this.dgvInventoryManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryManager.Size = new System.Drawing.Size(958, 749);
            this.dgvInventoryManager.TabIndex = 0;
            this.dgvInventoryManager.TabStop = false;
            this.dgvInventoryManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryManager_CellClick);
            // 
            // btnSearchByTitle
            // 
            this.btnSearchByTitle.Location = new System.Drawing.Point(1306, 54);
            this.btnSearchByTitle.Name = "btnSearchByTitle";
            this.btnSearchByTitle.Size = new System.Drawing.Size(184, 35);
            this.btnSearchByTitle.TabIndex = 1;
            this.btnSearchByTitle.Text = "Search By &Title";
            this.btnSearchByTitle.UseVisualStyleBackColor = true;
            this.btnSearchByTitle.Click += new System.EventHandler(this.btnSearchByTitle_Click);
            // 
            // tbxSearchByTitle
            // 
            this.tbxSearchByTitle.Location = new System.Drawing.Point(1144, 56);
            this.tbxSearchByTitle.Name = "tbxSearchByTitle";
            this.tbxSearchByTitle.Size = new System.Drawing.Size(156, 29);
            this.tbxSearchByTitle.TabIndex = 14;
            // 
            // lblSearchByTitle
            // 
            this.lblSearchByTitle.AutoSize = true;
            this.lblSearchByTitle.Location = new System.Drawing.Point(998, 61);
            this.lblSearchByTitle.Name = "lblSearchByTitle";
            this.lblSearchByTitle.Size = new System.Drawing.Size(140, 24);
            this.lblSearchByTitle.TabIndex = 17;
            this.lblSearchByTitle.Text = "Search by Title:";
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Location = new System.Drawing.Point(1306, 13);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(184, 35);
            this.btnSearchByCategory.TabIndex = 0;
            this.btnSearchByCategory.Text = "Search By &Category";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            this.btnSearchByCategory.Click += new System.EventHandler(this.btnSearchByCategory_Click);
            // 
            // lblFilterByCategory
            // 
            this.lblFilterByCategory.AutoSize = true;
            this.lblFilterByCategory.Location = new System.Drawing.Point(976, 12);
            this.lblFilterByCategory.Name = "lblFilterByCategory";
            this.lblFilterByCategory.Size = new System.Drawing.Size(162, 24);
            this.lblFilterByCategory.TabIndex = 16;
            this.lblFilterByCategory.Text = "Filter By Category:";
            // 
            // cbxCategories
            // 
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(1144, 13);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(156, 32);
            this.cbxCategories.TabIndex = 12;
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(154, 775);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(104, 24);
            this.lblPageNumber.TabIndex = 18;
            this.lblPageNumber.Text = "Page # of #";
            // 
            // btnPlusOnePage
            // 
            this.btnPlusOnePage.Location = new System.Drawing.Point(281, 767);
            this.btnPlusOnePage.Name = "btnPlusOnePage";
            this.btnPlusOnePage.Size = new System.Drawing.Size(124, 43);
            this.btnPlusOnePage.TabIndex = 18;
            this.btnPlusOnePage.Text = "--&>";
            this.btnPlusOnePage.UseVisualStyleBackColor = true;
            this.btnPlusOnePage.Click += new System.EventHandler(this.btnPlusOnePage_Click);
            // 
            // btnMinusOnePage
            // 
            this.btnMinusOnePage.Enabled = false;
            this.btnMinusOnePage.Location = new System.Drawing.Point(13, 766);
            this.btnMinusOnePage.Name = "btnMinusOnePage";
            this.btnMinusOnePage.Size = new System.Drawing.Size(124, 43);
            this.btnMinusOnePage.TabIndex = 17;
            this.btnMinusOnePage.Text = "&<--";
            this.btnMinusOnePage.UseVisualStyleBackColor = true;
            this.btnMinusOnePage.Click += new System.EventHandler(this.btnMinusOnePage_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(1144, 92);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(117, 43);
            this.btnClearFilters.TabIndex = 2;
            this.btnClearFilters.Text = "Clear &Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(1275, 218);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(215, 29);
            this.tbxName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1203, 218);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 24);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name:";
            // 
            // lblRestockThreshold
            // 
            this.lblRestockThreshold.AutoSize = true;
            this.lblRestockThreshold.Location = new System.Drawing.Point(1096, 358);
            this.lblRestockThreshold.Name = "lblRestockThreshold";
            this.lblRestockThreshold.Size = new System.Drawing.Size(173, 24);
            this.lblRestockThreshold.TabIndex = 26;
            this.lblRestockThreshold.Text = "Restock Threshold:";
            // 
            // tbxRestockThreshold
            // 
            this.tbxRestockThreshold.Location = new System.Drawing.Point(1275, 358);
            this.tbxRestockThreshold.Name = "tbxRestockThreshold";
            this.tbxRestockThreshold.Size = new System.Drawing.Size(215, 29);
            this.tbxRestockThreshold.TabIndex = 14;
            this.tbxRestockThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRestockThreshold_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(1186, 323);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 24);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity:";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(1275, 323);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(215, 29);
            this.tbxQuantity.TabIndex = 13;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(1217, 288);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(52, 24);
            this.lblCost.TabIndex = 30;
            this.lblCost.Text = "Cost:";
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(1275, 288);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(215, 29);
            this.tbxCost.TabIndex = 12;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(1211, 253);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "Price:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(1275, 253);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(215, 29);
            this.tbxPrice.TabIndex = 11;
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(1275, 180);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(215, 32);
            this.cbxCategory.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(1179, 183);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 24);
            this.lblCategory.TabIndex = 35;
            this.lblCategory.Text = "Category:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(1002, 463);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(493, 339);
            this.rtbDescription.TabIndex = 16;
            this.rtbDescription.Text = "";
            // 
            // lblItemImage
            // 
            this.lblItemImage.AutoSize = true;
            this.lblItemImage.Location = new System.Drawing.Point(1261, 101);
            this.lblItemImage.Name = "lblItemImage";
            this.lblItemImage.Size = new System.Drawing.Size(107, 24);
            this.lblItemImage.TabIndex = 37;
            this.lblItemImage.Text = "Item Image:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(998, 436);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(109, 24);
            this.lblDescription.TabIndex = 38;
            this.lblDescription.Text = "Description:";
            // 
            // btnEditImage
            // 
            this.btnEditImage.Location = new System.Drawing.Point(1374, 95);
            this.btnEditImage.Name = "btnEditImage";
            this.btnEditImage.Size = new System.Drawing.Size(116, 35);
            this.btnEditImage.TabIndex = 3;
            this.btnEditImage.Text = "&Edit Image";
            this.btnEditImage.UseVisualStyleBackColor = true;
            this.btnEditImage.Click += new System.EventHandler(this.btnEditImage_Click);
            // 
            // ckbDiscontinued
            // 
            this.ckbDiscontinued.AutoSize = true;
            this.ckbDiscontinued.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbDiscontinued.Location = new System.Drawing.Point(1145, 146);
            this.ckbDiscontinued.Name = "ckbDiscontinued";
            this.ckbDiscontinued.Size = new System.Drawing.Size(144, 28);
            this.ckbDiscontinued.TabIndex = 8;
            this.ckbDiscontinued.Text = "Discontinued:";
            this.ckbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(976, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(976, 293);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(72, 59);
            this.btnDeleteItem.TabIndex = 6;
            this.btnDeleteItem.Text = "&Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Location = new System.Drawing.Point(976, 180);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(58, 58);
            this.btnNewItem.TabIndex = 4;
            this.btnNewItem.Text = "&New Item";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(1427, 424);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 36);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(976, 358);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(83, 56);
            this.btnRefreshTable.TabIndex = 7;
            this.btnRefreshTable.Text = "&Refresh Table";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // frmInventory
            // 
            this.AcceptButton = this.btnSearchByTitle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1507, 814);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ckbDiscontinued);
            this.Controls.Add(this.btnEditImage);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblItemImage);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lblRestockThreshold);
            this.Controls.Add(this.tbxRestockThreshold);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnPlusOnePage);
            this.Controls.Add(this.btnMinusOnePage);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnSearchByTitle);
            this.Controls.Add(this.tbxSearchByTitle);
            this.Controls.Add(this.lblSearchByTitle);
            this.Controls.Add(this.btnSearchByCategory);
            this.Controls.Add(this.lblFilterByCategory);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.dgvInventoryManager);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmInventory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInventory_FormClosing);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventoryManager;
        private System.Windows.Forms.Button btnSearchByTitle;
        private System.Windows.Forms.TextBox tbxSearchByTitle;
        private System.Windows.Forms.Label lblSearchByTitle;
        private System.Windows.Forms.Button btnSearchByCategory;
        private System.Windows.Forms.Label lblFilterByCategory;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button btnPlusOnePage;
        private System.Windows.Forms.Button btnMinusOnePage;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRestockThreshold;
        private System.Windows.Forms.TextBox tbxRestockThreshold;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblItemImage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnEditImage;
        private System.Windows.Forms.CheckBox ckbDiscontinued;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefreshTable;
    }
}