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
    public partial class frmCustomers : Form
    {
        public static int PersonIDCurrentlySelected = -1;



        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            dgvCustomers =
               clsSQL.GetCustomers(
                   dgvCustomers);

            ////Set up current page number label
            //if (((clsSQL.GetTotalNumberOfItems(dgvCustomers, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
            //{
            //    lblPageNumber.Text = $"Page {currentPageNumber} of " +
            //        $"{(clsSQL.GetTotalNumberOfItems(dgvCustomers, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
            //}
            //else
            //{
            //    lblPageNumber.Text = $"Page {currentPageNumber} of " +
            //        $"{((clsSQL.GetTotalNumberOfItems(dgvCustomers, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
            //}
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Combox1.SelectedIndex = Combox1.FindStringExact("test1")
            cbxTitle.SelectedIndex =
                cbxTitle.FindStringExact(
                    dgvCustomers.SelectedRows[0].
                    Cells[1].Value.ToString());


            tbxFirstName.Text =

                    dgvCustomers.
                SelectedRows[0].
                Cells[2].
                Value.
                ToString();

            tbxMiddleName.Text =
                    dgvCustomers.
                    SelectedRows[0].
                    Cells[3].Value.
                    ToString();

            tbxLastName.Text =

                    dgvCustomers.
                    SelectedRows[0].
                    Cells[4].
                    Value.
                    ToString();

            cbxSuffix.SelectedIndex =
                cbxSuffix.FindStringExact(
                    dgvCustomers.SelectedRows[0].
                    Cells[5].Value.ToString());


            tbxAddressOne.Text =
                dgvCustomers.
                SelectedRows[0].
                Cells[6].
                Value.
                ToString();

            tbxAddressTwo.Text =
                        dgvCustomers.
                        SelectedRows[0].
                        Cells[7].
                        Value.
                        ToString();

            tbxAddressThree.Text =
                        dgvCustomers.
                        SelectedRows[0].
                        Cells[8].
                        Value.
                        ToString();

            tbxCity.Text =
                        dgvCustomers.
                        SelectedRows[0].
                        Cells[9].
                        Value.
                        ToString();

            tbxZipcode.Text =
                        dgvCustomers.
                        SelectedRows[0].
                        Cells[10].
                        Value.
                        ToString();

            cbxState.SelectedIndex =
                (cbxState.FindStringExact(
                    dgvCustomers.SelectedRows[0].
                    Cells[11].Value.ToString()));

            tbxEmail.Text =
                        dgvCustomers.
                        SelectedRows[0].
                        Cells[12].
                        Value.
                        ToString();

            tbxPrimaryPhone.Text =
                        dgvCustomers.
                        SelectedRows[0].
                        Cells[13].
                        Value.
                        ToString();

            tbxSecondaryPhone.Text =
                        dgvCustomers.
                        SelectedRows[0].
                        Cells[14].
                        Value.
                        ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                    tbxSecondaryPhone.Text == "")                        //Optional
               )
            {


                clsSQL.UpdatePerson(
                    cbxTitle.Text,
                    tbxFirstName.Text,//Mandatory
                    tbxMiddleName.Text,
                    tbxLastName.Text,//Mandatory
                    cbxSuffix.Text,
                    tbxAddressOne.Text,//Mandatory
                    tbxAddressTwo.Text,
                    tbxAddressThree.Text,
                    tbxCity.Text,//Mandatory
                    tbxZipcode.Text,//Mandatory
                    cbxState.Text,//Mandatory
                    tbxEmail.Text,
                    tbxPrimaryPhone.Text,
                    tbxSecondaryPhone.Text,
                    dgvCustomers.SelectedRows[0].Cells[0].Value.ToString());

                dgvCustomers =
               clsSQL.GetCustomers(
                   dgvCustomers);
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

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            dgvCustomers =
               clsSQL.GetCustomers(
                   dgvCustomers);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(
                dgvCustomers.SelectedRows[0].
                Cells[0].Value.ToString());
            clsSQL.DeletePerson(PersonID);

            dgvCustomers =
               clsSQL.GetCustomers(
                   dgvCustomers);
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer frmNewCustomerVar = new frmNewCustomer();
            this.Hide();
            frmNewCustomerVar.ShowDialog();
        }

        private void btnDisableAccount_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString());

            clsSQL.ToggleDisableAccout(PersonID, true);

            dgvCustomers =
               clsSQL.GetCustomers(
                   dgvCustomers);
        }

        private void btnEnableAccount_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString());

            clsSQL.ToggleDisableAccout(PersonID, false);

            dgvCustomers =
               clsSQL.GetCustomers(
                   dgvCustomers);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCustomers =
               clsSQL.SearchCustomers(
                   dgvCustomers,tbxSearchPrimaryPhone.Text,tbxSearchEmail.Text,tbxSearchLastName.Text,tbxSearchFirstName.Text);
        }

        private void btnAddSelectedCustomerToPOSScreen_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                PersonIDCurrentlySelected = int.Parse(dgvCustomers.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
