namespace FinalProject
{
    partial class frmNewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewItem));
            this.btnBack = new System.Windows.Forms.Button();
            this.ckbDiscontinued = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.lblRestockThreshold = new System.Windows.Forms.Label();
            this.tbxRestockThreshold = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(419, 277);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 42);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ckbDiscontinued
            // 
            this.ckbDiscontinued.AutoSize = true;
            this.ckbDiscontinued.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbDiscontinued.Location = new System.Drawing.Point(155, 8);
            this.ckbDiscontinued.Name = "ckbDiscontinued";
            this.ckbDiscontinued.Size = new System.Drawing.Size(144, 28);
            this.ckbDiscontinued.TabIndex = 0;
            this.ckbDiscontinued.Text = "Discontinued:";
            this.ckbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 298);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(109, 24);
            this.lblDescription.TabIndex = 54;
            this.lblDescription.Text = "Description:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(12, 325);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(493, 339);
            this.rtbDescription.TabIndex = 9;
            this.rtbDescription.Text = "";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(189, 45);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 24);
            this.lblCategory.TabIndex = 52;
            this.lblCategory.Text = "Category:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(285, 42);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(215, 32);
            this.cbxCategory.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(221, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPrice.TabIndex = 50;
            this.lblPrice.Text = "Price:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(285, 115);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(215, 29);
            this.tbxPrice.TabIndex = 3;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(227, 150);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(52, 24);
            this.lblCost.TabIndex = 48;
            this.lblCost.Text = "Cost:";
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(285, 150);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(215, 29);
            this.tbxCost.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(196, 185);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 24);
            this.lblQuantity.TabIndex = 46;
            this.lblQuantity.Text = "Quantity:";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(285, 185);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(215, 29);
            this.tbxQuantity.TabIndex = 5;
            // 
            // lblRestockThreshold
            // 
            this.lblRestockThreshold.AutoSize = true;
            this.lblRestockThreshold.Location = new System.Drawing.Point(106, 220);
            this.lblRestockThreshold.Name = "lblRestockThreshold";
            this.lblRestockThreshold.Size = new System.Drawing.Size(173, 24);
            this.lblRestockThreshold.TabIndex = 44;
            this.lblRestockThreshold.Text = "Restock Threshold:";
            // 
            // tbxRestockThreshold
            // 
            this.tbxRestockThreshold.Location = new System.Drawing.Point(285, 220);
            this.tbxRestockThreshold.Name = "tbxRestockThreshold";
            this.tbxRestockThreshold.Size = new System.Drawing.Size(215, 29);
            this.tbxRestockThreshold.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(213, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 24);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(285, 80);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(215, 29);
            this.tbxName.TabIndex = 2;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(320, 277);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(93, 39);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "&Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // frmNewItem
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(513, 675);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.ckbDiscontinued);
            this.Controls.Add(this.lblDescription);
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
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmNewItem";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewItem_FormClosing);
            this.Load += new System.EventHandler(this.frmNewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox ckbDiscontinued;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label lblRestockThreshold;
        private System.Windows.Forms.TextBox tbxRestockThreshold;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAddItem;
    }
}