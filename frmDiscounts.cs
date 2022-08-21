using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmDiscounts : Form
    {
        public frmDiscounts()
        {
            InitializeComponent();
        }

        private void frmDiscounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Show Main Menu Form
            var formToShow = Application.OpenForms.Cast<
                Form>().FirstOrDefault(c => c is frmCustomerView);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();//close New User Form
                             //Create variable to check if main form exists
                var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is frmCustomerView);
                //if main form exists, show form
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

        private void frmDiscounts_Load(object sender, EventArgs e)
        {
            dgvDiscounts =
               clsSQL.GetDiscounts(
                   dgvDiscounts);
        }

        private void dgvDiscounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbxDiscountCode.Text =
                    dgvDiscounts.
                    SelectedRows[0].
                    Cells[1].//Discount Code Column
                    Value.
                    ToString();

                tbxDescription.Text =
                    dgvDiscounts.
                    SelectedRows[0].
                    Cells[2].//Description Column
                    Value.
                    ToString();

                tbxDiscountLevel.Text =
                    dgvDiscounts.
                    SelectedRows[0].
                    Cells[3].//Discount Level Column
                    Value.
                    ToString();


                if (dgvDiscounts.
                        SelectedRows[0].
                        Cells[4].//InventoryID Column
                        Value.
                        ToString() != "") {
                    tbxInventoryID.Text =
                        dgvDiscounts.
                        SelectedRows[0].
                        Cells[4].//InventoryID Column
                        Value.
                        ToString();
                }
                else 
                {
                    tbxInventoryID.Text = "";
                }


                tbxDiscountType.Text =
                    dgvDiscounts.
                    SelectedRows[0].
                    Cells[5].//Discount Type Column
                    Value.
                    ToString();


                if (dgvDiscounts.
                        SelectedRows[0].
                        Cells[6].//Discount Percentage Column
                        Value.
                        ToString() != "") {
                    tbxDiscountPercentage.Text =
                        dgvDiscounts.
                        SelectedRows[0].
                        Cells[6].//Discount Percentage Column
                        Value.
                        ToString();
                }
                else 
                {
                    tbxDiscountPercentage.Text = "";
                }


                if (dgvDiscounts.
                        SelectedRows[0].
                        Cells[7].//Discount Dollar Amount Column
                        Value.
                        ToString() != "")
                {
                    tbxDiscountDollarAmount.Text =
                        dgvDiscounts.
                        SelectedRows[0].
                        Cells[7].//Discount Dollar Amount Column
                        Value.
                        ToString();
                }
                else 
                {
                    tbxDiscountDollarAmount.Text = "";
                }

                if (dgvDiscounts.
                        SelectedRows[0].
                        Cells[8].//Start Date Column
                        Value.
                        ToString() != "")
                {
                    tbxStartDate.Text =
                 dgvDiscounts.
                 SelectedRows[0].
                 Cells[8].//Start Date Column
                 Value.
                 ToString().Substring(0, dgvDiscounts.
                 SelectedRows[0].
                 Cells[8].//Start Date Column
                 Value.
                 ToString().IndexOf(" "));
                }
                else 
                {
                    tbxStartDate.Text = "";
                }



                tbxExpirationDate.Text =
                 dgvDiscounts.
                 SelectedRows[0].
                 Cells[9].//Start Date Column
                 Value.
                 ToString().Substring(0, dgvDiscounts.
                 SelectedRows[0].
                 Cells[9].//Start Date Column
                 Value.
                 ToString().IndexOf(" "));
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if 
                    (
                        tbxDiscountCode.Text != "" &&
                        tbxDescription.Text != "" &&
                        tbxDiscountLevel.Text != "" &&
                        tbxDiscountType.Text != "" &&
                        tbxExpirationDate.Text != "" &&
                        clsValidation.ValidateIntRegex(tbxDiscountLevel.Text) &&
                        (clsValidation.ValidateIntRegex(tbxInventoryID.Text) || tbxInventoryID.Text == "") &&
                        clsValidation.ValidateIntRegex(tbxDiscountType.Text) &&
                        (clsValidation.ValidatePercent(tbxDiscountPercentage.Text) || tbxDiscountPercentage.Text == "") &&
                        (clsValidation.ValidateCurrency(tbxDiscountDollarAmount.Text) || tbxDiscountDollarAmount.Text == "") &&
                        (clsValidation.ValidateDiscountDate(tbxStartDate.Text) ||tbxStartDate.Text == "") &&
                        clsValidation.ValidateDiscountDate(tbxExpirationDate.Text)
                    )
                {


                    clsSQL.UpdateSelectedDiscount(
                        dgvDiscounts.SelectedRows[0].Cells[0].Value.ToString(),//DiscountID
                        tbxDiscountCode.Text,
                        tbxDescription.Text,
                        tbxDiscountLevel.Text,
                        tbxInventoryID.Text,
                        tbxDiscountType.Text,
                        tbxDiscountPercentage.Text,
                        tbxDiscountDollarAmount.Text,
                        tbxStartDate.Text,
                        tbxExpirationDate.Text);



                    dgvDiscounts =
               clsSQL.GetDiscounts(
                   dgvDiscounts);//Re-Pull DGV from Database with updates




                    //}
                    //else if (!clsValidation.ValidateIntRegex(tbxQuantity.Text))
                    //{
                    //    MessageBox.Show(
                    //        "Invalid Quantity.",
                    //        "Connection Error",
                    //        MessageBoxButtons.OK,
                    //        MessageBoxIcon.Error);
                    //    tbxQuantity.Focus();
                    //}
                    //else if (!clsValidation.ValidateIntRegex(tbxRestockThreshold.Text))
                    //{
                    //    MessageBox.Show(
                    //        "Invalid RestockThreshold.",
                    //        "Connection Error",
                    //        MessageBoxButtons.OK,
                    //        MessageBoxIcon.Error);
                    //    tbxRestockThreshold.Focus();
                }
                else if (tbxDiscountCode.Text == "")
                {
                    MessageBox.Show(
                                "Must have a Discount Code.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    tbxDiscountCode.Focus();
                }
                else if (tbxDescription.Text == "")
                {
                    MessageBox.Show(
                                "Must have a Description.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    tbxDescription.Focus();
                }
                else if (!(clsValidation.ValidateIntRegex(
                            tbxDiscountLevel.Text)))
                {
                    MessageBox.Show(
                                "Invalid Discount Level, use a whole positive number.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    tbxDiscountLevel.Focus();
                }
                else if (!(clsValidation.ValidateIntRegex(
                            tbxInventoryID.Text)) &&
                            (tbxInventoryID.Text != ""))
                {
                    MessageBox.Show(
                                    "Invalid InventoryID, use a whole positive number.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    tbxInventoryID.Focus();
                }
                else if (!(clsValidation.ValidateIntRegex(
                            tbxDiscountType.Text)))
                {
                    MessageBox.Show(
                                    "Invalid Discount Type, use a whole positive number.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    tbxDiscountType.Focus();
                }
                else if (!(clsValidation.ValidatePercent(tbxDiscountPercentage.Text)) &&
                            (tbxDiscountPercentage.Text != ""))
                {
                    MessageBox.Show(
                                    "Invalid Discount Percentage, use a decimal Value.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    tbxDiscountPercentage.Focus();
                }
                else if (!(clsValidation.ValidateCurrency(tbxDiscountDollarAmount.Text)) &&
                            (tbxDiscountDollarAmount.Text != ""))
                {
                    MessageBox.Show(
                                    "Invalid Discount Dollar Amount, use a decimal Value.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    tbxDiscountDollarAmount.Focus();
                }
                else if (!(clsValidation.ValidateDiscountDate(tbxStartDate.Text)) &&
                    (tbxStartDate.Text != ""))
                {
                    MessageBox.Show(
                                    "Invalid Start Date, use (mm/dd/yyyy).",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    tbxStartDate.Focus();
                }
                else if (!(clsValidation.ValidateDiscountDate(tbxExpirationDate.Text)))
                {
                    MessageBox.Show(
                                    "Invalid Expiration Date, use (mm/dd/yyyy).",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    tbxExpirationDate.Focus();
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmNewDiscount frmNewDiscountVar = new frmNewDiscount();
            this.Hide();
            frmNewDiscountVar.ShowDialog();
        }

        private void btnDeleteCode_Click(object sender, EventArgs e)
        {
            int DiscountID = int.Parse(
            dgvDiscounts.SelectedRows[0].
            Cells[0].Value.ToString());
            clsSQL.DeleteDiscountCode(DiscountID);

            dgvDiscounts =
               clsSQL.GetDiscounts(
                   dgvDiscounts);
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            dgvDiscounts =
               clsSQL.GetDiscounts(
                   dgvDiscounts);
        }
    }
}
