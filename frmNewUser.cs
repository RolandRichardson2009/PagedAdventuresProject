//*******************************************
//*******************************************
// Programmer: Roland Richardson
// Course: INEW 2330.7Z1 (Final Project)
// Program Description: Bookstore application for inventroy management and sales.
//*******************************************
using Paged_Adventures;
using System;
using System.Windows.Forms;
using System.Linq;
namespace FinalProject
{
    public partial class frmNewUser : Form
    {
        public frmNewUser(string LogonUserName, string LogonPassword)
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try{
                this.Close();//close New User Form
            //Create variable to check if main form exists
            var formToShow = Application.OpenForms.Cast<Form>()
            .FirstOrDefault(c => c is frmLogon);
            
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
        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if keys are allowed for Username
            clsValidation.AllowedKeysUsername(e);
        }
        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if keys are allowed for Password
            clsValidation.AllowedKeysPassword(e);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsValidation.ValidateUsername(tbxUsername.Text.ToLower(), 1) &&  //Required
                    clsValidation.ValidatePassword(tbxPassword.Text, 1) &&  //Required
                    (clsValidation.ValidateEmail(tbxEmail.Text.ToLower()) ||          //Optional
                    tbxEmail.Text == "") &&                                 //Optional
                    clsValidation.ValidateZipcode(tbxZipCode.Text) &&       //Required
                    (clsValidation.ValidatePhone(tbxPrimaryPhone.Text) ||   //Optional
                    tbxPrimaryPhone.Text == "") &&                          //Optional
                    ((clsValidation.ValidatePhone(tbxSecondaryPhone.Text) &&
                    clsValidation.ValidatePhone(tbxPrimaryPhone.Text)) || //Optional
                    tbxSecondaryPhone.Text == "") &&                        //Optional
                    tbxFirstName.Text != "" &&                              //Required
                    tbxLastName.Text != "" &&                               //Required
                    tbxCity.Text != "" &&                                   //Required
                    cbxState.SelectedIndex != -1 &&                         //Required
                    tbxAddress1.Text != "" &&                               //Required
                    cbxFirstChallengeQuestion.SelectedIndex != -1 &&        //Required
                    tbxFirstChallengeAnswer.Text != "" &&                   //Required
                    cbxSecondChallengeQuestion.SelectedIndex != -1 &&       //Required
                    tbxSecondChallengeAnswer.Text != "" &&                  //Required
                    cbxThirdChallengeQuestion.SelectedIndex != -1 &&        //Required
                    tbxThirdChallengeAnswer.Text != "")                     //Required
                {
                    string titleVar;
                    string suffixVar;

                    if (cbxTitle.SelectedIndex != -1)
                    {
                        titleVar = cbxTitle.SelectedItem.ToString();
                    }
                    else
                    {
                        titleVar = "";
                    }

                    if (cbxSuffix.SelectedIndex != -1)
                    {
                        suffixVar = cbxSuffix.SelectedItem.ToString();
                    }
                    else
                    {
                        suffixVar = "";
                    }


                    //Add user to database
                    clsSQL.AddNewUser(tbxUsername.Text.ToLower(), tbxPassword.Text, tbxEmail.Text.ToLower(),
                        tbxZipCode.Text, tbxPrimaryPhone.Text, tbxSecondaryPhone.Text,
                        titleVar, tbxFirstName.Text, tbxMiddleName.Text,
                        tbxLastName.Text, suffixVar, tbxCity.Text,
                        cbxState.SelectedItem.ToString(), tbxAddress1.Text,
                        tbxAddress2.Text, tbxAddress3.Text, cbxFirstChallengeQuestion.SelectedIndex,
                        tbxFirstChallengeAnswer.Text.ToLower(), cbxSecondChallengeQuestion.SelectedIndex,
                        tbxSecondChallengeAnswer.Text.ToLower(), cbxThirdChallengeQuestion.SelectedIndex,
                        tbxThirdChallengeAnswer.Text.ToLower());

                    //Return to logon form
                    this.Close();//close New User Form
                                 //Create variable to check if main form exists
                    var formToShow = Application.OpenForms.Cast<Form>()
                    .FirstOrDefault(c => c is frmLogon);

                    //if main form exists, show form
                    if (formToShow != null)
                    {
                        formToShow.Show();
                    }
                }
                else
                {
                    if (!(clsValidation.ValidateUsername(tbxUsername.Text.ToLower(), 2)))
                    {
                        //If Username is invalid, focus on Username Textbox
                        tbxUsername.Focus();
                    }
                    else
                    if (!(clsValidation.ValidatePassword(tbxPassword.Text, 2)))
                    {
                        //If Password is invalid, focus on Password Textbox
                        tbxPassword.Focus();
                    }
                    else
                    if (!(clsValidation.ValidateEmail(tbxEmail.Text.ToLower())) &&
                        (tbxEmail.Text != ""))
                    {
                        //If Email is invalid, focus on Email Textbox
                        MessageBox.Show("Invalid Email", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxEmail.Focus();
                    }
                    else
                    if (!(clsValidation.ValidateZipcode(tbxZipCode.Text)))
                    {
                        //If Zipcode is invalid, focus on Zipcode Textbox
                        MessageBox.Show("Invalid Zipcode", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxZipCode.Focus();
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
                    if (tbxAddress1.Text == "")
                    {
                        //If Address1 is invalid, focus on Address1 Textbox
                        MessageBox.Show("Invalid Address1", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxAddress1.Focus();
                    }
                    else
                    //Q1
                    if (cbxFirstChallengeQuestion.SelectedIndex == -1)
                    {
                        //If First Challenge Question is invalid,
                        //focus on First Challenge Question Textbox
                        MessageBox.Show("Invalid First Challenge Question", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbxFirstChallengeQuestion.Focus();
                    }
                    else
                    //A1
                    if (tbxFirstChallengeAnswer.Text == "")
                    {
                        //If First Challenge Answer is invalid,
                        //focus on First Challenge Answer Textbox
                        MessageBox.Show("Invalid First Challenge Answer", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxFirstChallengeAnswer.Focus();
                    }
                    else
                    //Q2
                    if (cbxSecondChallengeQuestion.SelectedIndex == -1)
                    {
                        //If Second Challenge Question is invalid,
                        //focus on Second Challenge Question Textbox
                        MessageBox.Show("Invalid Second Challenge Question", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbxSecondChallengeQuestion.Focus();
                    }
                    else
                    //A2
                    if (tbxSecondChallengeAnswer.Text == "")
                    {
                        //If Second Challenge Answer is invalid,
                        //focus on Second Challenge Answer Textbox
                        MessageBox.Show("Invalid Second Challenge Answer", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxSecondChallengeAnswer.Focus();
                    }
                    else
                    //Q3
                    if (cbxThirdChallengeQuestion.SelectedIndex == -1)
                    {
                        //If Third Challenge Question is invalid,
                        //focus on Third Challenge Question Textbox
                        MessageBox.Show("Invalid Third Challenge Question", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbxThirdChallengeQuestion.Focus();
                    }
                    else
                    //A3
                    if (tbxThirdChallengeAnswer.Text == "")
                    {
                        //If Third Challenge Answer is invalid,
                        //focus on Third Challenge Answer Textbox
                        MessageBox.Show("Invalid Third Challenge Answer", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxThirdChallengeAnswer.Focus();
                    }
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



        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if keys are allowed for Email
            clsValidation.AllowedKeysEmail(e);
        }
        private void tbxPrimaryPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if keys are allowed for Primary Phone
            clsValidation.AllowedKeysPhone(e);
        }
        private void tbxSecondaryPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if keys are allowed for Secondary Phone
            clsValidation.AllowedKeysPhone(e);
        }
        private void tbxZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check if keys are allowed for ZipCode
            clsValidation.AllowedKeysZipCode(e);
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            try{
                clsHelp.LoadPDF("frmNewUser");
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
        private void frmNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Show Main Menu Form
            var formToShow = Application.OpenForms.Cast<
                Form>().FirstOrDefault(c => c is frmLogon);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void btnTogglePasswordVisibility_Click(object sender, EventArgs e)
        {
            try { 
                //if password char is *, change to original value
            if (tbxPassword.PasswordChar == '*')
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                //Changes password characters back to *
                tbxPassword.PasswordChar = '*';
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

        private void frmNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
