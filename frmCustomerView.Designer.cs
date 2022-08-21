namespace FinalProject
{
    partial class frmCustomerView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerView));
            this.dgvCustomerView = new System.Windows.Forms.DataGridView();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnMinusOnePage = new System.Windows.Forms.Button();
            this.btnPlusOnePage = new System.Windows.Forms.Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lblFilterByCategory = new System.Windows.Forms.Label();
            this.btnSearchByCategory = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.lblSearchByTitle = new System.Windows.Forms.Label();
            this.tbxSearchByTitle = new System.Windows.Forms.TextBox();
            this.btnSearchByTitle = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnSubtractOne = new System.Windows.Forms.Button();
            this.tbxDiscountCode = new System.Windows.Forms.TextBox();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCCV = new System.Windows.Forms.Label();
            this.tbxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.tbxExpirationDate = new System.Windows.Forms.TextBox();
            this.tbxCCV = new System.Windows.Forms.TextBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.cbxCardType = new System.Windows.Forms.ComboBox();
            this.btnToggleCreditCardVisibility = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lstShoppingCart = new System.Windows.Forms.ListView();
            this.clmItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.mnsProductsManager = new System.Windows.Forms.MenuStrip();
            this.mnsProductsManagerInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsProductsManagerDiscounts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsProductsManagerPersonnel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsProductsManagerCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsProductsManagerReports = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerView)).BeginInit();
            this.mnsProductsManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomerView
            // 
            this.dgvCustomerView.AllowUserToAddRows = false;
            this.dgvCustomerView.AllowUserToDeleteRows = false;
            this.dgvCustomerView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomerView.ColumnHeadersHeight = 40;
            this.dgvCustomerView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCustomerView.Location = new System.Drawing.Point(955, 164);
            this.dgvCustomerView.Name = "dgvCustomerView";
            this.dgvCustomerView.ReadOnly = true;
            this.dgvCustomerView.RowHeadersVisible = false;
            this.dgvCustomerView.RowHeadersWidth = 5;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerView.RowTemplate.Height = 300;
            this.dgvCustomerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerView.Size = new System.Drawing.Size(614, 589);
            this.dgvCustomerView.TabIndex = 0;
            this.dgvCustomerView.TabStop = false;
            this.dgvCustomerView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerView_CellClick);
            // 
            // btnSignOut
            // 
            this.btnSignOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignOut.Location = new System.Drawing.Point(12, 357);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(102, 35);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "&Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnMinusOnePage
            // 
            this.btnMinusOnePage.Enabled = false;
            this.btnMinusOnePage.Location = new System.Drawing.Point(1030, 759);
            this.btnMinusOnePage.Name = "btnMinusOnePage";
            this.btnMinusOnePage.Size = new System.Drawing.Size(124, 43);
            this.btnMinusOnePage.TabIndex = 18;
            this.btnMinusOnePage.Text = "&<--";
            this.btnMinusOnePage.UseVisualStyleBackColor = true;
            this.btnMinusOnePage.Click += new System.EventHandler(this.btnMinusOnePage_Click);
            // 
            // btnPlusOnePage
            // 
            this.btnPlusOnePage.Location = new System.Drawing.Point(1446, 759);
            this.btnPlusOnePage.Name = "btnPlusOnePage";
            this.btnPlusOnePage.Size = new System.Drawing.Size(124, 43);
            this.btnPlusOnePage.TabIndex = 19;
            this.btnPlusOnePage.Text = "--&>";
            this.btnPlusOnePage.UseVisualStyleBackColor = true;
            this.btnPlusOnePage.Click += new System.EventHandler(this.btnPlusOnePage_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(1249, 768);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(104, 24);
            this.lblPageNumber.TabIndex = 6;
            this.lblPageNumber.Text = "Page # of #";
            // 
            // cbxCategories
            // 
            this.cbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(12, 164);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(329, 32);
            this.cbxCategories.TabIndex = 0;
            // 
            // lblFilterByCategory
            // 
            this.lblFilterByCategory.AutoSize = true;
            this.lblFilterByCategory.Location = new System.Drawing.Point(8, 137);
            this.lblFilterByCategory.Name = "lblFilterByCategory";
            this.lblFilterByCategory.Size = new System.Drawing.Size(162, 24);
            this.lblFilterByCategory.TabIndex = 8;
            this.lblFilterByCategory.Text = "Filter By Category:";
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Location = new System.Drawing.Point(12, 203);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(329, 35);
            this.btnSearchByCategory.TabIndex = 1;
            this.btnSearchByCategory.Text = "Search By &Category";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            this.btnSearchByCategory.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(120, 357);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(117, 35);
            this.btnClearFilters.TabIndex = 5;
            this.btnClearFilters.Text = "Clear &Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // lblSearchByTitle
            // 
            this.lblSearchByTitle.AutoSize = true;
            this.lblSearchByTitle.Location = new System.Drawing.Point(8, 250);
            this.lblSearchByTitle.Name = "lblSearchByTitle";
            this.lblSearchByTitle.Size = new System.Drawing.Size(140, 24);
            this.lblSearchByTitle.TabIndex = 11;
            this.lblSearchByTitle.Text = "Search by Title:";
            // 
            // tbxSearchByTitle
            // 
            this.tbxSearchByTitle.Location = new System.Drawing.Point(12, 278);
            this.tbxSearchByTitle.Name = "tbxSearchByTitle";
            this.tbxSearchByTitle.Size = new System.Drawing.Size(329, 29);
            this.tbxSearchByTitle.TabIndex = 2;
            // 
            // btnSearchByTitle
            // 
            this.btnSearchByTitle.Location = new System.Drawing.Point(12, 313);
            this.btnSearchByTitle.Name = "btnSearchByTitle";
            this.btnSearchByTitle.Size = new System.Drawing.Size(329, 35);
            this.btnSearchByTitle.TabIndex = 3;
            this.btnSearchByTitle.Text = "Search By &Title";
            this.btnSearchByTitle.UseVisualStyleBackColor = true;
            this.btnSearchByTitle.Click += new System.EventHandler(this.btnSearchByTitle_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(12, 646);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(871, 155);
            this.rtbDescription.TabIndex = 14;
            this.rtbDescription.TabStop = false;
            this.rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(13, 619);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(114, 24);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description: ";
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(646, 398);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(35, 35);
            this.btnAddOne.TabIndex = 17;
            this.btnAddOne.Text = "&+";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnSubtractOne
            // 
            this.btnSubtractOne.Location = new System.Drawing.Point(605, 398);
            this.btnSubtractOne.Name = "btnSubtractOne";
            this.btnSubtractOne.Size = new System.Drawing.Size(35, 35);
            this.btnSubtractOne.TabIndex = 16;
            this.btnSubtractOne.Text = "&-";
            this.btnSubtractOne.UseVisualStyleBackColor = true;
            this.btnSubtractOne.Click += new System.EventHandler(this.btnSubtractOne_Click);
            // 
            // tbxDiscountCode
            // 
            this.tbxDiscountCode.Location = new System.Drawing.Point(814, 407);
            this.tbxDiscountCode.Name = "tbxDiscountCode";
            this.tbxDiscountCode.Size = new System.Drawing.Size(135, 29);
            this.tbxDiscountCode.TabIndex = 15;
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Location = new System.Drawing.Point(810, 380);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(139, 24);
            this.lblDiscountCode.TabIndex = 21;
            this.lblDiscountCode.Text = "Discount Code:";
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.AutoSize = true;
            this.lblCartTotal.Location = new System.Drawing.Point(507, 398);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(94, 24);
            this.lblCartTotal.TabIndex = 22;
            this.lblCartTotal.Text = "Cart Total:";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(195, 398);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(146, 35);
            this.btnPurchase.TabIndex = 7;
            this.btnPurchase.Text = "&Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Location = new System.Drawing.Point(566, 262);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(378, 24);
            this.lblCreditCardNumber.TabIndex = 24;
            this.lblCreditCardNumber.Text = "Credit Card Number: (####-####-####-####)";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(457, 333);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(244, 24);
            this.lblExpirationDate.TabIndex = 25;
            this.lblExpirationDate.Text = "Expiration Date: (MM/YYYY)";
            // 
            // lblCCV
            // 
            this.lblCCV.AutoSize = true;
            this.lblCCV.Location = new System.Drawing.Point(707, 333);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(101, 24);
            this.lblCCV.TabIndex = 26;
            this.lblCCV.Text = "CCV: (###)";
            // 
            // tbxCreditCardNumber
            // 
            this.tbxCreditCardNumber.Location = new System.Drawing.Point(570, 289);
            this.tbxCreditCardNumber.MaxLength = 19;
            this.tbxCreditCardNumber.Name = "tbxCreditCardNumber";
            this.tbxCreditCardNumber.PasswordChar = '*';
            this.tbxCreditCardNumber.Size = new System.Drawing.Size(192, 29);
            this.tbxCreditCardNumber.TabIndex = 11;
            // 
            // tbxExpirationDate
            // 
            this.tbxExpirationDate.Location = new System.Drawing.Point(461, 360);
            this.tbxExpirationDate.MaxLength = 7;
            this.tbxExpirationDate.Name = "tbxExpirationDate";
            this.tbxExpirationDate.PasswordChar = '*';
            this.tbxExpirationDate.Size = new System.Drawing.Size(99, 29);
            this.tbxExpirationDate.TabIndex = 12;
            // 
            // tbxCCV
            // 
            this.tbxCCV.Location = new System.Drawing.Point(711, 360);
            this.tbxCCV.MaxLength = 3;
            this.tbxCCV.Name = "tbxCCV";
            this.tbxCCV.PasswordChar = '*';
            this.tbxCCV.Size = new System.Drawing.Size(50, 29);
            this.tbxCCV.TabIndex = 13;
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Location = new System.Drawing.Point(422, 261);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(103, 24);
            this.lblCardType.TabIndex = 30;
            this.lblCardType.Text = "Card Type:";
            // 
            // cbxCardType
            // 
            this.cbxCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCardType.FormattingEnabled = true;
            this.cbxCardType.Items.AddRange(new object[] {
            "-",
            "VISA",
            "MASTERCARD"});
            this.cbxCardType.Location = new System.Drawing.Point(426, 289);
            this.cbxCardType.Name = "cbxCardType";
            this.cbxCardType.Size = new System.Drawing.Size(138, 32);
            this.cbxCardType.TabIndex = 10;
            // 
            // btnToggleCreditCardVisibility
            // 
            this.btnToggleCreditCardVisibility.Location = new System.Drawing.Point(814, 313);
            this.btnToggleCreditCardVisibility.Name = "btnToggleCreditCardVisibility";
            this.btnToggleCreditCardVisibility.Size = new System.Drawing.Size(135, 65);
            this.btnToggleCreditCardVisibility.TabIndex = 14;
            this.btnToggleCreditCardVisibility.Text = "T&oggle Credit Card Visibility";
            this.btnToggleCreditCardVisibility.UseVisualStyleBackColor = true;
            this.btnToggleCreditCardVisibility.Click += new System.EventHandler(this.btnToggleCreditCardVisibility_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(243, 357);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 35);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lstShoppingCart
            // 
            this.lstShoppingCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem,
            this.clmQuantity,
            this.clmPrice,
            this.clmTotal});
            this.lstShoppingCart.FullRowSelect = true;
            this.lstShoppingCart.GridLines = true;
            this.lstShoppingCart.HideSelection = false;
            this.lstShoppingCart.Location = new System.Drawing.Point(12, 443);
            this.lstShoppingCart.MultiSelect = false;
            this.lstShoppingCart.Name = "lstShoppingCart";
            this.lstShoppingCart.Size = new System.Drawing.Size(937, 173);
            this.lstShoppingCart.TabIndex = 32;
            this.lstShoppingCart.TabStop = false;
            this.lstShoppingCart.UseCompatibleStateImageBehavior = false;
            this.lstShoppingCart.View = System.Windows.Forms.View.Details;
            this.lstShoppingCart.Click += new System.EventHandler(this.lstShoppingCart_Click);
            // 
            // clmItem
            // 
            this.clmItem.Text = "Item";
            this.clmItem.Width = 698;
            // 
            // clmQuantity
            // 
            this.clmQuantity.Text = "Qty.";
            // 
            // clmPrice
            // 
            this.clmPrice.Text = "Price";
            // 
            // clmTotal
            // 
            this.clmTotal.Text = "Total";
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(355, 398);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(146, 35);
            this.btnClearCart.TabIndex = 9;
            this.btnClearCart.Text = "Clear Ca&rt";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(12, 398);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(175, 35);
            this.btnRemoveSelected.TabIndex = 8;
            this.btnRemoveSelected.Text = "Remo&ve Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // mnsProductsManager
            // 
            this.mnsProductsManager.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsProductsManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsProductsManagerInventory,
            this.mnsProductsManagerDiscounts,
            this.mnsProductsManagerPersonnel,
            this.mnsProductsManagerCustomers,
            this.mnsProductsManagerReports});
            this.mnsProductsManager.Location = new System.Drawing.Point(0, 0);
            this.mnsProductsManager.Name = "mnsProductsManager";
            this.mnsProductsManager.Size = new System.Drawing.Size(1582, 33);
            this.mnsProductsManager.TabIndex = 33;
            this.mnsProductsManager.Text = "menuStrip1";
            // 
            // mnsProductsManagerInventory
            // 
            this.mnsProductsManagerInventory.Name = "mnsProductsManagerInventory";
            this.mnsProductsManagerInventory.Size = new System.Drawing.Size(103, 29);
            this.mnsProductsManagerInventory.Text = "&Inventory";
            this.mnsProductsManagerInventory.Click += new System.EventHandler(this.mnsProductsManagerInventory_Click);
            // 
            // mnsProductsManagerDiscounts
            // 
            this.mnsProductsManagerDiscounts.Name = "mnsProductsManagerDiscounts";
            this.mnsProductsManagerDiscounts.Size = new System.Drawing.Size(106, 29);
            this.mnsProductsManagerDiscounts.Text = "&Discounts";
            this.mnsProductsManagerDiscounts.Click += new System.EventHandler(this.mnsProductsManagerDiscounts_Click);
            // 
            // mnsProductsManagerPersonnel
            // 
            this.mnsProductsManagerPersonnel.Name = "mnsProductsManagerPersonnel";
            this.mnsProductsManagerPersonnel.Size = new System.Drawing.Size(107, 29);
            this.mnsProductsManagerPersonnel.Text = "P&ersonnel";
            this.mnsProductsManagerPersonnel.Click += new System.EventHandler(this.mnsProductsManagerPersonnel_Click);
            // 
            // mnsProductsManagerCustomers
            // 
            this.mnsProductsManagerCustomers.Name = "mnsProductsManagerCustomers";
            this.mnsProductsManagerCustomers.Size = new System.Drawing.Size(113, 29);
            this.mnsProductsManagerCustomers.Text = "C&ustomers";
            this.mnsProductsManagerCustomers.Click += new System.EventHandler(this.mnsProductsManagerCustomers_Click);
            // 
            // mnsProductsManagerReports
            // 
            this.mnsProductsManagerReports.Name = "mnsProductsManagerReports";
            this.mnsProductsManagerReports.Size = new System.Drawing.Size(87, 29);
            this.mnsProductsManagerReports.Text = "Rep&orts";
            this.mnsProductsManagerReports.Click += new System.EventHandler(this.mnsProductsManagerReports_Click);
            // 
            // lblCurrentCustomer
            // 
            this.lblCurrentCustomer.AutoSize = true;
            this.lblCurrentCustomer.Location = new System.Drawing.Point(951, 123);
            this.lblCurrentCustomer.Name = "lblCurrentCustomer";
            this.lblCurrentCustomer.Size = new System.Drawing.Size(163, 24);
            this.lblCurrentCustomer.TabIndex = 34;
            this.lblCurrentCustomer.Text = "Current Customer:";
            // 
            // frmCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSignOut;
            this.ClientSize = new System.Drawing.Size(1582, 813);
            this.Controls.Add(this.lblCurrentCustomer);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.lstShoppingCart);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnToggleCreditCardVisibility);
            this.Controls.Add(this.cbxCardType);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.tbxCCV);
            this.Controls.Add(this.tbxExpirationDate);
            this.Controls.Add(this.tbxCreditCardNumber);
            this.Controls.Add(this.lblCCV);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.lblCreditCardNumber);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblCartTotal);
            this.Controls.Add(this.lblDiscountCode);
            this.Controls.Add(this.tbxDiscountCode);
            this.Controls.Add(this.btnSubtractOne);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.btnSearchByTitle);
            this.Controls.Add(this.tbxSearchByTitle);
            this.Controls.Add(this.lblSearchByTitle);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnSearchByCategory);
            this.Controls.Add(this.lblFilterByCategory);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnPlusOnePage);
            this.Controls.Add(this.btnMinusOnePage);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.dgvCustomerView);
            this.Controls.Add(this.mnsProductsManager);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsProductsManager;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmCustomerView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Activated += new System.EventHandler(this.frmCustomerView_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerView_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerView)).EndInit();
            this.mnsProductsManager.ResumeLayout(false);
            this.mnsProductsManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerView;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnMinusOnePage;
        private System.Windows.Forms.Button btnPlusOnePage;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label lblFilterByCategory;
        private System.Windows.Forms.Button btnSearchByCategory;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label lblSearchByTitle;
        private System.Windows.Forms.TextBox tbxSearchByTitle;
        private System.Windows.Forms.Button btnSearchByTitle;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnSubtractOne;
        private System.Windows.Forms.TextBox tbxDiscountCode;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.Label lblCartTotal;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.TextBox tbxCreditCardNumber;
        private System.Windows.Forms.TextBox tbxExpirationDate;
        private System.Windows.Forms.TextBox tbxCCV;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.ComboBox cbxCardType;
        private System.Windows.Forms.Button btnToggleCreditCardVisibility;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListView lstShoppingCart;
        private System.Windows.Forms.ColumnHeader clmItem;
        private System.Windows.Forms.ColumnHeader clmQuantity;
        private System.Windows.Forms.ColumnHeader clmTotal;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.ColumnHeader clmPrice;
        private System.Windows.Forms.MenuStrip mnsProductsManager;
        private System.Windows.Forms.ToolStripMenuItem mnsProductsManagerInventory;
        private System.Windows.Forms.ToolStripMenuItem mnsProductsManagerDiscounts;
        private System.Windows.Forms.ToolStripMenuItem mnsProductsManagerPersonnel;
        private System.Windows.Forms.ToolStripMenuItem mnsProductsManagerCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnsProductsManagerReports;
        private System.Windows.Forms.Label lblCurrentCustomer;
    }
}