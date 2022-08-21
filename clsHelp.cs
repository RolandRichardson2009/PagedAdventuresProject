//*******************************************
//*******************************************
// Programmer: Roland Richardson
// Course: INEW 2330.7Z1 (Final Project)
// Program Description: Bookstore application for inventroy management and sales.
//*******************************************
using System;
using System.Windows.Forms;

namespace FinalProject
{
    internal class clsHelp
    {
        //Loads proper help file based on previous form
        internal static void LoadPDF(string helpFileVar)
        {

            



                switch (helpFileVar)
                {
                    case "frmMain":
                    try
                    {

                        #if DEBUG
                        System.Diagnostics.Process.Start(@"C:\Users\RD\Desktop\22SU-FinalProject-RichardsonRoland\HelpFiles\Help - Logon Form.pdf");
#else
                        System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\HelpFiles\Help - Logon Form.pdf");
#endif
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("I am unable to open this help file at this time.", "Help File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case "frmNewUser":
                    try
                    {

                        #if DEBUG
                        System.Diagnostics.Process.Start(@"C:\Users\RD\Desktop\22SU-FinalProject-RichardsonRoland\HelpFiles\Help - New User.pdf");
#else
                        System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\HelpFiles\Help - New User.pdf");
#endif
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("I am unable to open this help file at this time.", "Help File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case "frmForgotPassword":
                    try
                    {

                        #if DEBUG
                        System.Diagnostics.Process.Start(@"C:\Users\RD\Desktop\22SU-FinalProject-RichardsonRoland\HelpFiles\Help - Forgot Password.pdf");
#else
                        System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\HelpFiles\Help - Forgot Password.pdf");
#endif
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("I am unable to open this help file at this time.", "Help File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case "frmCustomerView":
                    try
                    {
                        //sslMessages.Text = "Help File Opened - Look for it in a Browser Window";
                        #if DEBUG
                        System.Diagnostics.Process.Start(@"C:\Users\RD\Desktop\22SU-FinalProject-RichardsonRoland\HelpFiles\Help - Customer View Form.pdf");
#else
                        System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\HelpFiles\Help - Customer View Form.pdf");
#endif
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("I am unable to open this help file at this time.", "Help File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
