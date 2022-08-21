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
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void frmNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Show Main Menu Form
            var formToShow = Application.OpenForms.Cast<
                Form>().FirstOrDefault(c => c is frmCustomers);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();//close Form
                var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is frmCustomers);
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {

                if
                    (
                    tbxFirstName.Text != "" &&//Mandatory
                   tbxLastName.Text != "" &&//Mandatory
                   tbxAddressOne.Text != "" &&//Mandatory
                   tbxCity.Text != "" &&//Mandatory
                   tbxZipcode.Text != "" &&//Mandatory
                   cbxState.Text != "" &&//Mandatory
                   (clsValidation.ValidateZipcode(tbxZipcode.Text)) &&//Mandatory
                   (clsValidation.ValidateEmail(tbxEmail.Text) || tbxEmail.Text == "") && //Optional
                   (clsValidation.ValidatePhone(tbxPrimaryPhone.Text) ||   //Optional
                    tbxPrimaryPhone.Text == "") &&                          //Optional
                    ((clsValidation.ValidatePhone(tbxSecondaryPhone.Text) &&
                    clsValidation.ValidatePhone(tbxPrimaryPhone.Text)) || //Optional
                    tbxSecondaryPhone.Text == "")                   //Optional
                    )
                {
                    clsSQL.AddPerson
                        (
                        cbxTitle.Text,
                    tbxFirstName.Text,
                    tbxMiddleName.Text,
                    tbxLastName.Text,
                    cbxSuffix.Text,
                    tbxAddressOne.Text,
                    tbxAddressTwo.Text,
                    tbxAddressThree.Text,
                    tbxCity.Text,
                    tbxZipcode.Text,
                    cbxState.Text,
                    tbxEmail.Text,
                    tbxPrimaryPhone.Text,
                    tbxSecondaryPhone.Text,
                    1000
                        );

                    this.Close();//close Form

                    var formToShow = Application.OpenForms.Cast<
                        Form>().FirstOrDefault(c => c is frmCustomers);
                    if (formToShow != null)
                    {
                        formToShow.Show();
                    }
                }
                else if (!(clsValidation.ValidateZipcode(tbxZipcode.Text)))
                {
                    MessageBox.Show(
                        "Invalid Zipcode.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    tbxZipcode.Focus();
                }
                else if (!(clsValidation.ValidateEmail(tbxEmail.Text.ToLower())) &&
                        (tbxEmail.Text != ""))
                {
                    MessageBox.Show(
                        "Invalid Email.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    tbxEmail.Focus();
                }
                else
                        if (!(clsValidation.ValidatePhone(tbxPrimaryPhone.Text)) &&
                            tbxPrimaryPhone.Text != "")
                {
                    //If Primary Phone is invalid, focus on Primary Phone Textbox
                    MessageBox.Show("Invalid Primary Phone", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPrimaryPhone.Focus();
                }
                else
                        if (tbxSecondaryPhone.Text != "" &&
                            tbxPrimaryPhone.Text == "")
                {
                    MessageBox.Show("Must have a primary phone before a secondary " +
                        "can be added.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    tbxPrimaryPhone.Focus();
                }
                else
                        if (!(clsValidation.ValidatePhone(tbxSecondaryPhone.Text)) &&
                            tbxSecondaryPhone.Text != "")

                {

                    if ((clsValidation.ValidatePhone(tbxPrimaryPhone.Text)))
                    {
                        //If Secondary Phone is invalid, focus on Secondary Phone Textbox
                        MessageBox.Show("Invalid Secondary Phone", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxSecondaryPhone.Focus();
                    }

                }
                else
                    //first name
                    if (tbxFirstName.Text == "")
                {
                    //If First Name is invalid, focus on First Name Textbox
                    MessageBox.Show("Invalid First Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxFirstName.Focus();
                }
                else
                    //last name
                    if (tbxLastName.Text == "")
                {
                    //If Last Name is invalid, focus on Last Name Textbox
                    MessageBox.Show("Invalid Last Name", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxLastName.Focus();
                }
                else
                    //city
                    if (tbxCity.Text == "")
                {
                    //If City is invalid, focus on City Textbox
                    MessageBox.Show("Invalid City", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxCity.Focus();
                }
                else
                    //state
                    if (cbxState.SelectedIndex == -1)
                {
                    //If State is invalid, focus on State Textbox
                    MessageBox.Show("Invalid State", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxState.Focus();
                }
                else
                    //address 1
                    if (tbxAddressOne.Text == "")
                {
                    //If Address1 is invalid, focus on Address1 Textbox
                    MessageBox.Show("Invalid Address1", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxAddressOne.Focus();
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
    }
}
