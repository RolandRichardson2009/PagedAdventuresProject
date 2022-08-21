namespace FinalProject
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.rdoDaily = new System.Windows.Forms.RadioButton();
            this.rdoWeekly = new System.Windows.Forms.RadioButton();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.gbxSalesTotalsReport = new System.Windows.Forms.GroupBox();
            this.btnCreateSalesReport = new System.Windows.Forms.Button();
            this.gbxInventoryReport = new System.Windows.Forms.GroupBox();
            this.btnCreateInventoryReport = new System.Windows.Forms.Button();
            this.rdoAvailableForSale = new System.Windows.Forms.RadioButton();
            this.rdoAllItems = new System.Windows.Forms.RadioButton();
            this.rdoNeedsRestocking = new System.Windows.Forms.RadioButton();
            this.gbxSalesTotalsReport.SuspendLayout();
            this.gbxInventoryReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(335, 47);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 37);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(79, 12);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(328, 29);
            this.dtpStart.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(13, 16);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(51, 24);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start:";
            // 
            // rdoDaily
            // 
            this.rdoDaily.AutoSize = true;
            this.rdoDaily.Checked = true;
            this.rdoDaily.Location = new System.Drawing.Point(204, 30);
            this.rdoDaily.Name = "rdoDaily";
            this.rdoDaily.Size = new System.Drawing.Size(68, 28);
            this.rdoDaily.TabIndex = 3;
            this.rdoDaily.TabStop = true;
            this.rdoDaily.Text = "Daily";
            this.rdoDaily.UseVisualStyleBackColor = true;
            // 
            // rdoWeekly
            // 
            this.rdoWeekly.AutoSize = true;
            this.rdoWeekly.Location = new System.Drawing.Point(204, 64);
            this.rdoWeekly.Name = "rdoWeekly";
            this.rdoWeekly.Size = new System.Drawing.Size(90, 28);
            this.rdoWeekly.TabIndex = 4;
            this.rdoWeekly.Text = "Weekly";
            this.rdoWeekly.UseVisualStyleBackColor = true;
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Location = new System.Drawing.Point(204, 98);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(94, 28);
            this.rdoMonthly.TabIndex = 5;
            this.rdoMonthly.Text = "Monthly";
            this.rdoMonthly.UseVisualStyleBackColor = true;
            // 
            // gbxSalesTotalsReport
            // 
            this.gbxSalesTotalsReport.Controls.Add(this.btnCreateSalesReport);
            this.gbxSalesTotalsReport.Controls.Add(this.rdoDaily);
            this.gbxSalesTotalsReport.Controls.Add(this.rdoMonthly);
            this.gbxSalesTotalsReport.Controls.Add(this.rdoWeekly);
            this.gbxSalesTotalsReport.Location = new System.Drawing.Point(17, 47);
            this.gbxSalesTotalsReport.Name = "gbxSalesTotalsReport";
            this.gbxSalesTotalsReport.Size = new System.Drawing.Size(312, 145);
            this.gbxSalesTotalsReport.TabIndex = 8;
            this.gbxSalesTotalsReport.TabStop = false;
            this.gbxSalesTotalsReport.Text = "Sales Totals Report";
            // 
            // btnCreateSalesReport
            // 
            this.btnCreateSalesReport.Location = new System.Drawing.Point(28, 28);
            this.btnCreateSalesReport.Name = "btnCreateSalesReport";
            this.btnCreateSalesReport.Size = new System.Drawing.Size(109, 100);
            this.btnCreateSalesReport.TabIndex = 2;
            this.btnCreateSalesReport.Text = "Create &Sales Report";
            this.btnCreateSalesReport.UseVisualStyleBackColor = true;
            this.btnCreateSalesReport.Click += new System.EventHandler(this.btnCreateSalesReport_Click);
            // 
            // gbxInventoryReport
            // 
            this.gbxInventoryReport.Controls.Add(this.btnCreateInventoryReport);
            this.gbxInventoryReport.Controls.Add(this.rdoAvailableForSale);
            this.gbxInventoryReport.Controls.Add(this.rdoAllItems);
            this.gbxInventoryReport.Controls.Add(this.rdoNeedsRestocking);
            this.gbxInventoryReport.Location = new System.Drawing.Point(17, 198);
            this.gbxInventoryReport.Name = "gbxInventoryReport";
            this.gbxInventoryReport.Size = new System.Drawing.Size(405, 151);
            this.gbxInventoryReport.TabIndex = 9;
            this.gbxInventoryReport.TabStop = false;
            this.gbxInventoryReport.Text = "Inventory Report";
            // 
            // btnCreateInventoryReport
            // 
            this.btnCreateInventoryReport.Location = new System.Drawing.Point(28, 32);
            this.btnCreateInventoryReport.Name = "btnCreateInventoryReport";
            this.btnCreateInventoryReport.Size = new System.Drawing.Size(109, 96);
            this.btnCreateInventoryReport.TabIndex = 6;
            this.btnCreateInventoryReport.Text = "Create &Inventory Report";
            this.btnCreateInventoryReport.UseVisualStyleBackColor = true;
            this.btnCreateInventoryReport.Click += new System.EventHandler(this.btnCreateInventoryReport_Click);
            // 
            // rdoAvailableForSale
            // 
            this.rdoAvailableForSale.AutoSize = true;
            this.rdoAvailableForSale.Checked = true;
            this.rdoAvailableForSale.Location = new System.Drawing.Point(204, 32);
            this.rdoAvailableForSale.Name = "rdoAvailableForSale";
            this.rdoAvailableForSale.Size = new System.Drawing.Size(180, 28);
            this.rdoAvailableForSale.TabIndex = 7;
            this.rdoAvailableForSale.TabStop = true;
            this.rdoAvailableForSale.Text = "Available For Sale";
            this.rdoAvailableForSale.UseVisualStyleBackColor = true;
            // 
            // rdoAllItems
            // 
            this.rdoAllItems.AutoSize = true;
            this.rdoAllItems.Location = new System.Drawing.Point(204, 100);
            this.rdoAllItems.Name = "rdoAllItems";
            this.rdoAllItems.Size = new System.Drawing.Size(98, 28);
            this.rdoAllItems.TabIndex = 9;
            this.rdoAllItems.Text = "All Items";
            this.rdoAllItems.UseVisualStyleBackColor = true;
            // 
            // rdoNeedsRestocking
            // 
            this.rdoNeedsRestocking.AutoSize = true;
            this.rdoNeedsRestocking.Location = new System.Drawing.Point(204, 66);
            this.rdoNeedsRestocking.Name = "rdoNeedsRestocking";
            this.rdoNeedsRestocking.Size = new System.Drawing.Size(182, 28);
            this.rdoNeedsRestocking.TabIndex = 8;
            this.rdoNeedsRestocking.Text = "Needs Restocking";
            this.rdoNeedsRestocking.UseVisualStyleBackColor = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 361);
            this.Controls.Add(this.gbxInventoryReport);
            this.Controls.Add(this.gbxSalesTotalsReport);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmReports";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReports_FormClosing);
            this.gbxSalesTotalsReport.ResumeLayout(false);
            this.gbxSalesTotalsReport.PerformLayout();
            this.gbxInventoryReport.ResumeLayout(false);
            this.gbxInventoryReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.RadioButton rdoDaily;
        private System.Windows.Forms.RadioButton rdoWeekly;
        private System.Windows.Forms.RadioButton rdoMonthly;
        private System.Windows.Forms.GroupBox gbxSalesTotalsReport;
        private System.Windows.Forms.Button btnCreateSalesReport;
        private System.Windows.Forms.GroupBox gbxInventoryReport;
        private System.Windows.Forms.Button btnCreateInventoryReport;
        private System.Windows.Forms.RadioButton rdoAvailableForSale;
        private System.Windows.Forms.RadioButton rdoAllItems;
        private System.Windows.Forms.RadioButton rdoNeedsRestocking;
    }
}