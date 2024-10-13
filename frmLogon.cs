//*******************************************
//*******************************************
// Programmer: Roland Richardson
// Course: INEW 2330.7Z1 (Final Project)
// Program Description: Bookstore application for inventroy management and sales.
//*******************************************
//*******************************************
// Form Purpose: Main menu for application, and log on.
//*******************************************
//*******************************************
using Paged_Adventures;
using System;
using System.Windows.Forms;
namespace FinalProject
{
    public partial class frmLogon : Form
    {
        public static string UserName = "";
        public frmLogon()
        {
            InitializeComponent();
        }
        //User logs in, username and password is checked.
        private void btnLogOn_Click(object sender, EventArgs e)
        {
            //frmCustomerView frmCustomerViewVar = new frmCustomerView();
            //this.Hide();
            //frmCustomerViewVar.ShowDialog();

            //clsSQL.AddItem(
            //            "Book 1",
            //            1,
            //            "11.11",
            //            "11.10",
            //            "8",
            //            "10",
            //            "Book 1 is good");

            try
            {
                if (clsValidation.ValidateUsername(tbxUsername.Text.ToLower(), 3) &&
                    clsValidation.ValidatePassword(tbxPassword.Text, 1))
                {
                    if (clsSQL.LoginToApplication(tbxUsername.Text.ToLower(), tbxPassword.Text))
                    {
                        //Run if the username and password match in the database
                        MessageBox.Show("Username and Password Match!",
                            "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        MessageBox.Show("Position: " +
                            clsSQL.fetchPosition(tbxUsername.Text.ToLower()),
                            "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        UserName = tbxUsername.Text.ToLower();

                        tbxUsername.Text = "";
                        tbxPassword.Text = "";

                        frmCustomerView frmCustomerViewVar = new frmCustomerView();
                        this.Hide();
                        frmCustomerViewVar.ShowDialog();

                    }
                    else
                    {
                        //Run if username and password don't match in the database
                        MessageBox.Show("Username and Password Don't Match!",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

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
        //This button toggles visibility of password
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
        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validate text entered for username    
            clsValidation.AllowedKeysUsername(e);
        }
        //Opens new window for adding a new user.
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            try{
                frmNewUser frmNewUserVar = new
            frmNewUser(tbxUsername.Text.ToLower(),
            tbxPassword.Text);//Create variable to control New User Form
            this.Hide();//Hide main form
            frmNewUserVar.ShowDialog();//Display New User Form
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
        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validate text entered for password
            clsValidation.AllowedKeysPassword(e);
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            try { 
                //Create variable to control new forgot password form
            frmForgotPassword ForgotPasswordFormVar
                = new frmForgotPassword();
            this.Hide();//Hide main menu form
            ForgotPasswordFormVar.ShowDialog();//Show Forgot Password Form   
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
        private void btnHelp_Click(object sender, EventArgs e)
        {
            try
            {
                clsHelp.LoadPDF("frmMain");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}