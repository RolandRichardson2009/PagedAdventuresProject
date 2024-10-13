using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmNewItem : Form
    {
        private static StringBuilder errorMessages = new StringBuilder();
        public frmNewItem()
        {
            InitializeComponent();
        }

        private void frmNewItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Show frmInventory
            var formToShow = Application.OpenForms.Cast<
                Form>().FirstOrDefault(c => c is frmInventory);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try { 
            this.Close();//close New Item Form
            //Show frmInventory
            var formToShow = Application.OpenForms.Cast<
                Form>().FirstOrDefault(c => c is frmInventory);
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

        private void frmNewItem_Load(object sender, EventArgs e)
        {
            cbxCategory = clsSQL.GetCategories(cbxCategory);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            try
            {

                if (tbxName.Text != "" &&
                        cbxCategory.SelectedIndex != 0 &&
                        tbxPrice.Text != "" &&
                        clsValidation.ValidateCurrency(tbxPrice.Text.Substring(1)) &&
                        tbxCost.Text != "" &&
                        clsValidation.ValidateCurrency(tbxCost.Text.Substring(1)) &&
                        tbxRestockThreshold.Text != "" &&
                        tbxQuantity.Text != "" &&
                        rtbDescription.Text != "" &&
                        (clsValidation.ValidateIntRegex(tbxQuantity.Text) &&
                        clsValidation.ValidateIntRegex(tbxRestockThreshold.Text)))
                {
                    MessageBox.Show("BtnAddItem pressed, about to add item.");
                    clsSQL.AddItem(
                        tbxName.Text,
                        cbxCategory.SelectedIndex,
                        tbxPrice.Text,
                        tbxCost.Text,
                        tbxRestockThreshold.Text,
                        tbxQuantity.Text,
                        rtbDescription.Text);

                    //clsSQL.AddItem(
                    //    "Book 1",
                    //    1,
                    //    "11.11",
                    //    "11.10",
                    //    "8",
                    //    "10",
                    //    "Book 1 is good");

                    this.Close();//close New Item Form
                                 //Show frmInventory
                    var formToShow = Application.OpenForms.Cast<
                        Form>().FirstOrDefault(c => c is frmInventory);
                    if (formToShow != null)
                    {
                        formToShow.Show();
                    }
                }
                else if (!clsValidation.ValidateCurrency(tbxPrice.Text.Substring(1)))//Price
                {
                    MessageBox.Show(
                        "Invalid Price.",
                        "Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    tbxPrice.Focus();
                }
                else if (!clsValidation.ValidateCurrency(tbxCost.Text.Substring(1)))//Cost
                {
                    MessageBox.Show(
                        "Invalid Cost.",
                        "Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    tbxCost.Focus();
                }
                else if(!(clsValidation.ValidateCurrency(tbxPrice.Text)))
                    {
                    MessageBox.Show(
                        "Invalid Price.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    tbxPrice.Focus();
                }
                else if (!(clsValidation.ValidateCurrency(tbxCost.Text)))
                {
                    MessageBox.Show(
                        "Invalid Cost.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    tbxCost.Focus();
                }
                else if (!clsValidation.ValidateIntRegex(tbxQuantity.Text))
                {
                    MessageBox.Show(
                        "Invalid Quantity.",
                        "Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    tbxQuantity.Focus();
                }
                else if (!clsValidation.ValidateIntRegex(tbxRestockThreshold.Text))
                {
                    MessageBox.Show(
                        "Invalid RestockThreshold.",
                        "Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    tbxRestockThreshold.Focus();
                }

            }
            //catch (Exception) 
            //{
            //    MessageBox.Show(
            //                "Failed to add Item.",
            //                "Error",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //}
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
