//*******************************************
//*******************************************
// Programmer: Roland Richardson
// Course: INEW 2330.7Z1 (Final Project)
// Program Description: Bookstore application for inventroy management and sales.
//*******************************************
using Paged_Adventures;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace FinalProject
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                //Close current form and return to main menu
                this.Close();
                var formToShow = Application.OpenForms.Cast<
                    Form>().FirstOrDefault(c => c is frmLogon);
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
        private void btnShowSecurityQuestions_Click(object sender, EventArgs e)
        {
            try { 
                //Check if username exists in database
            if (!(clsSQL.DatabaseCommandPagedAdventuresCheckExistingUsername(tbxUsername.Text.ToLower())))
            {
                //fill in security questions
                lblSecurityQuestion1.Text =  clsSQL.GetSecurityQuestions("FirstChallengeQuestion", tbxUsername.Text.ToLower());
                lblSecurityQuestion2.Text = clsSQL.GetSecurityQuestions("SecondChallengeQuestion", tbxUsername.Text.ToLower());
                lblSecurityQuestion3.Text = clsSQL.GetSecurityQuestions("ThirdChallengeQuestion", tbxUsername.Text.ToLower());
                //Disable controls
                tbxUsername.Enabled = false;
                btnShowSecurityQuestions.Enabled = false;
                //Enable Controls
                btnCheckAnswers.Enabled = true;
                tbxAnswer1.Enabled = true;
                tbxAnswer2.Enabled = true;
                tbxAnswer3.Enabled = true;
                //Change Accept button to new appropriate value
                this.AcceptButton = btnCheckAnswers;
                //Focus on next important field
                tbxAnswer1.Focus();
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
        private void btnCheckAnswers_Click(object sender, EventArgs e)
        {
            try { //Check if all security answers are correct
            if (
            clsSQL.GetSecurityAnswers("FirstChallengeAnswer", tbxUsername.Text.ToLower(), tbxAnswer1.Text.ToLower()) &&
            clsSQL.GetSecurityAnswers("SecondChallengeAnswer", tbxUsername.Text.ToLower(), tbxAnswer2.Text.ToLower()) &&
            clsSQL.GetSecurityAnswers("ThirdChallengeAnswer", tbxUsername.Text.ToLower(), tbxAnswer3.Text.ToLower()))
            {
                MessageBox.Show("All Answers are correct. You may now change your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Enable next appropriate controls
                btnChange.Enabled = true;
                btnTogglePasswordVisibility.Enabled = true;
                tbxNewPassword.Enabled = true;
                //Disable previous controls
                btnCheckAnswers.Enabled = false;
                tbxAnswer1.Enabled = false;
                tbxAnswer2.Enabled = false;
                tbxAnswer3.Enabled = false;
                //Change accept button to next appropriate value
                this.AcceptButton = btnChange;
                //Focus on next important field
                tbxNewPassword.Focus();
            }
            else 
            {
                MessageBox.Show("Answers are incorrect, try again.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnChange_Click(object sender, EventArgs e)
        {
            try { 
            //If password is in proper format, continue
            if (clsValidation.ValidatePassword(tbxNewPassword.Text,1))
            {
                MessageBox.Show("Execute password change query", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Update users password in database
                clsSQL.UpdatePassword(tbxNewPassword.Text, tbxUsername.Text.ToLower());
                //Disable appropriate controls
                btnChange.Enabled = false;
                btnTogglePasswordVisibility.Enabled = false;
                tbxNewPassword.Enabled = false;
                //Change acceptbutton to appropriate value
                this.AcceptButton = btnBack;



                //Return to Logon Form
                //Close current form and return to main menu
                this.Close();
                var formToShow = Application.OpenForms.Cast<
                    Form>().FirstOrDefault(c => c is frmLogon);
                if (formToShow != null)
                {
                    formToShow.Show();
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
        private void tbxNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow valid keys for Password
            clsValidation.AllowedKeysPassword(e);
        }
        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow valid keys for Username
            clsValidation.AllowedKeysUsername(e);
        }
        private void tbxAnswer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow valid keys for Answer1
            clsValidation.AllowedKeysGeneral(e);
        }
        private void tbxAnswer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow valid keys for Answer2
            clsValidation.AllowedKeysGeneral(e);
        }
        private void tbxAnswer3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow valid keys for Answer3
            clsValidation.AllowedKeysGeneral(e);
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            try{
                clsHelp.LoadPDF("frmForgotPassword");
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

        private void frmForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
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
            if (tbxNewPassword.PasswordChar == '*')
            {
                tbxNewPassword.PasswordChar = '\0';
            }
            else
            {
                //Changes password characters back to *
                tbxNewPassword.PasswordChar = '*';
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
