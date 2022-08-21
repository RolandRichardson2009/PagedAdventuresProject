using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();//close Form
                             //Show Main Menu Form
                var formToShow = Application.OpenForms.Cast<
                    Form>().FirstOrDefault(c => c is frmCustomerView);
                if (formToShow != null)
                {
                    formToShow.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Connection Timed Out... Please check you network connection.",
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<
                    Form>().FirstOrDefault(c => c is frmCustomerView);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void btnCreateSalesReport_Click(object sender, EventArgs e)
        {
            ListView QueryResultsListView = new ListView();
            string title;
            int RadioIndex = -1;

            if (rdoDaily.Checked == true)
            {
                RadioIndex = 1;
            }
            if (rdoWeekly.Checked == true)
            {
                RadioIndex = 2;
            }
            if (rdoMonthly.Checked == true)
            {
                RadioIndex = 3;
            }

            /*
                                 tbxStartDate.Text =
                 dgvDiscounts.
                 SelectedRows[0].
                 Cells[8].//Start Date Column
                 Value.
                 ToString().Substring(0, dgvDiscounts.
                 SelectedRows[0].
                 Cells[8].//Start Date Column
                 Value.
                 ToString().IndexOf(" "))
             */

            switch (RadioIndex)
            {
                case 1:
                    title = "Daily Sales Report";
                    QueryResultsListView = clsSQL.GetSalesTotals(QueryResultsListView, dtpStart.Value, dtpStart.Value);
                    clsHTML.PrintReport(clsHTML.GenerateSalesReport(title, QueryResultsListView, dtpStart.Value, dtpStart.Value));

                    break;
                case 2:
                    title = "Weekly Sales Report";
                    //txtweek.Text=  (1+(dateTimePicker1.Value.Day / 7)).ToString("0");
                    //MessageBox.Show((1 + (dtpStart.Value.Day / 7)).ToString(""));
                    string dayOfWeek = dtpStart.Value.DayOfWeek.ToString();

                    //DateTime startAtSunday = DateTime.Now.AddDays(DayOfWeek.Sunday - DateTime.Now.DayOfWeek);











                    DateTime startAtSunday = //Always gets Beginning of week successfully!!!!!!!!!
                        dtpStart.Value.AddDays(
                            DayOfWeek.Sunday - 
                            dtpStart.Value.DayOfWeek);

                    DateTime endAtSaturday = //Always gets Beginning of week successfully!!!!!!!!!
                        dtpStart.Value.AddDays(
                            DayOfWeek.Saturday -
                            dtpStart.Value.DayOfWeek);




                    QueryResultsListView = clsSQL.GetSalesTotals(QueryResultsListView, startAtSunday, endAtSaturday);
                    clsHTML.PrintReport(clsHTML.GenerateSalesReport(title, QueryResultsListView, startAtSunday, endAtSaturday));









                    //MessageBox.Show("Date Given is: " + dtpStart.Value.ToString().Substring(0, dtpStart.Value.ToString().IndexOf(" ")));
                    //MessageBox.Show("Sunday is: " + startAtSunday.ToString().Substring(0, startAtSunday.ToString().IndexOf(" ")));
                    //MessageBox.Show("Saturday is: " + endAtSaturday.ToString().Substring(0, endAtSaturday.ToString().IndexOf(" ")));
                    break;
                case 3:
                    title = "Monthly Sales Report";
                    
                    DateTime StartOfMonth = new DateTime(dtpStart.Value.Year, dtpStart.Value.Month,1);
                    int DaysInMonth = DateTime.DaysInMonth(dtpStart.Value.Year, dtpStart.Value.Month);
                    DateTime EndOfMonth = new DateTime(dtpStart.Value.Year, dtpStart.Value.Month, DaysInMonth);
                    QueryResultsListView = clsSQL.GetSalesTotals(QueryResultsListView,StartOfMonth,EndOfMonth);
                    clsHTML.PrintReport(clsHTML.GenerateSalesReport(title, QueryResultsListView, StartOfMonth, EndOfMonth));
                        
                        
                        
                     
                    

                    break;
                default:
                    break;
            }
            
            
            //clsHTML.GenerateSalesReport();
        }

        private void btnCreateInventoryReport_Click(object sender, EventArgs e)
        {
            ListView QueryResultsListView = new ListView();
            string title;
            int RadioIndex = -1;

            if (rdoAvailableForSale.Checked == true)
            {
                RadioIndex = 1;
            }
            if (rdoNeedsRestocking.Checked == true)
            {
                RadioIndex = 2;
            }
            if (rdoAllItems.Checked == true)
            {
                RadioIndex = 3;
            }

            switch (RadioIndex)
            {
                case 1:
                    title = "Available For Sale Report";
                    QueryResultsListView = clsSQL.InventoryReportAvailableForSale(QueryResultsListView);
                    clsHTML.PrintReport(clsHTML.GenerateInventoryReport(title, QueryResultsListView));

                    break;
                case 2:
                    title = "Needs Restocking Report";
                    QueryResultsListView = clsSQL.InventoryReportNeedsRestocking(QueryResultsListView);
                    clsHTML.PrintReport(clsHTML.GenerateInventoryReport(title, QueryResultsListView));

                    break;
                case 3:
                    title = "All Items Report";
                    QueryResultsListView = clsSQL.InventoryReportAllItems(QueryResultsListView);
                    clsHTML.PrintReport(clsHTML.GenerateInventoryReport(title, QueryResultsListView));
                    break;
                default:
                    break;
            }
        }
    }
}
