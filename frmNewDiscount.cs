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
    public partial class frmNewDiscount : Form
    {
        public frmNewDiscount()
        {
            InitializeComponent();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            try
            {

                if
                    (
                        tbxDiscountCode.Text != "" &&       //Required
                        tbxDescription.Text != "" &&        //Required
                        tbxDiscountLevel.Text != "" &&      //Required
                        tbxDiscountType.Text != "" &&       //Required
                        tbxExpirationDate.Text != "" &&     //Required
                                                clsValidation.ValidateIntRegex(tbxDiscountLevel.Text) &&
                        (clsValidation.ValidateIntRegex(tbxInventoryID.Text) || tbxInventoryID.Text == "") &&
                        clsValidation.ValidateIntRegex(tbxDiscountType.Text) &&
                        (clsValidation.ValidatePercent(tbxDiscountPercentage.Text) || tbxDiscountPercentage.Text == "") &&
                        (clsValidation.ValidateCurrency(tbxDiscountDollarAmount.Text) || tbxDiscountDollarAmount.Text == "") &&
                        (clsValidation.ValidateDiscountDate(tbxStartDate.Text) || tbxStartDate.Text == "") &&
                        clsValidation.ValidateDiscountDate(tbxExpirationDate.Text)
                    )
                {
                    clsSQL.AddNewDiscount(
                        tbxDiscountCode.Text,
                        tbxDescription.Text,
                        tbxDiscountLevel.Text,
                        tbxInventoryID.Text,
                        tbxDiscountType.Text,
                        tbxDiscountPercentage.Text,
                        tbxDiscountDollarAmount.Text,
                        tbxStartDate.Text,
                        tbxExpirationDate.Text);

                    this.Close();//close Form
                    //Show frmDiscounts
                    var formToShow = Application.OpenForms.Cast<
                        Form>().FirstOrDefault(c => c is frmDiscounts);
                    if (formToShow != null)
                    {
                        formToShow.Show();
                    }
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
                } else if (!(clsValidation.ValidateIntRegex(    
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
                            "Failed to add Item.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();//close Form
                             //Show frmDiscounts
                var formToShow = Application.OpenForms.Cast<
                    Form>().FirstOrDefault(c => c is frmDiscounts);
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
    }
}
