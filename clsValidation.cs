//*******************************************
//*******************************************
// Programmer: Roland Richardson
// Course: INEW 2330.7Z1 (Final Project)
// Program Description: Bookstore application for inventroy management and sales.
//*******************************************
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;
using System;
using System.Text;

namespace FinalProject
{
    internal class clsValidation
    {
        #region Logon Credentials
        //Validate Username
        public static bool ValidateUsername(string strUsername,int messageGivenVar)
        {
            if ((!((strUsername.Length >= 8) && (strUsername.Length <= 20))) || strUsername == "")
            {
                //Only Show this message if messageGivenVar is not 2, this ensures
                //that the invalid username message doesn't show multiple times
                if (messageGivenVar != 2)
                {
                    MessageBox.Show("Invalid Username, must be between " +
                        "8 and 20 characters", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            if ((!(clsSQL.DatabaseCommandPagedAdventuresCheckExistingUsername(strUsername))) && messageGivenVar != 3)
            {
                //Only Show this message if messageGivenVar is not 2, this ensures
                //that the "Username already taken." message doesn't show multiple times
                if (messageGivenVar != 2)
                {
                    MessageBox.Show("Username already taken.", 
                        "Error", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
                    return false; }


            if (!(strUsername.All(char.IsLetterOrDigit)))
            {
                if (messageGivenVar != 2)
                {
                    MessageBox.Show("Username contains forbidden characters.",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                return false; 
            }

                







                return true; // or false;
        }



        //Validate Password
        public static bool ValidatePassword(string strPassword, int messageGivenVar)
        {
            if ((!((strPassword.Length >= 8) && 
                (strPassword.Length <= 20))) || strPassword == "")
            {
                //Only Show this message if messageGivenVar is not 2, this ensures
                //that the invalid password message doesn't show multiple times
                if (messageGivenVar != 2)
                {
                    MessageBox.Show("Invalid Password, Password must be between 8 and 20 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    return false; 
            }
            //Track Password Complexity and ensure minimum complexity
            int intComplexityCounter = 0;
            bool bolHasSpecial = false;
            string strAllowedKeys = "!@#$%^&*()";
            if (strPassword.Any(char.IsUpper))
                intComplexityCounter++;
            if (strPassword.Any(char.IsLower))
                intComplexityCounter++;
            if (strPassword.Any(char.IsDigit))
                intComplexityCounter++;
            foreach (char chLetter in strPassword)
            {
                if (strAllowedKeys.Contains(chLetter.ToString()))
                    bolHasSpecial = true;
            }
            if (bolHasSpecial)
                intComplexityCounter++;
            if (!(intComplexityCounter >= 3))
            {
                //Only Show this message if messageGivenVar is not 2, this ensures
                //that the invalid password message doesn't show multiple times
                if (messageGivenVar != 2)
                {
                    MessageBox.Show("Password must contain 3 of the 4 following characters: " +
                    "LowercaseLetter, Uppercase Letter, number, special Character(!@#$%^&*())", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    return false;
            }



            if (!(Regex.IsMatch(strPassword, @"^[a-zA-Z0-9\!\@\#\$\%\^\&\*\(\)]{8,20}$")))
            {
                if (messageGivenVar != 2)
                {
                    MessageBox.Show("Password contains illegal characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    return false; 
            }


            return true; // or false;
        }
        #endregion
        #region Contact Information
        //Validate Email using RegEx
        public static bool ValidateEmail(string strEmail)
        {
            return (Regex.IsMatch(strEmail, @"^(?!.*[.]{2})([a-zA-Z0-9\""]+)([a-zA-Z0-9_\""\-\.\+]+)([a-zA-Z0-9\""]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9])+)(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,6}|[0-9]{1,3})(\]?)$"));
        }
        //Validate Phone using RegEx
        public static bool ValidatePhone(string strPhone)
        {
            return 
                (Regex.IsMatch(strPhone, @"^(?:(\+1)[ -]?)?\(?(\d{3})\)?([ -])?(\d{3})([ -])?(\d{4})$"));
        }
        //Validate Zipcode using RegEx
        public static bool ValidateZipcode(string strZip)
        {
            return (Regex.IsMatch(strZip, @"^(((\d{5})+)+(-?\d{4})?)$"));
        }
        #endregion
        #region Other Validation Methods
        //Only allow proper keys for Username
        internal static void AllowedKeysUsername(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            { 
                e.Handled = false;
                
            }
            else 
            {
                e.Handled = true;
                
            }
        }
        //Only allow proper keys for Title
        internal static void AllowedKeysTitle(KeyPressEventArgs e)
        {
            if ((char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar)) || char.Equals(e.KeyChar,'.') &&
                (!(char.Equals(e.KeyChar, '\''))) && (!(char.Equals(e.KeyChar, '\"'))))
            {
                e.Handled = false;
                
            }
            else
            {
                e.Handled = true;
                
            }
        }
        //Only allow proper keys for General text fields
        internal static void AllowedKeysGeneral(KeyPressEventArgs e) 
        {
            if ((char.IsLetterOrDigit(e.KeyChar) || char.Equals(e.KeyChar, ' ') || char.IsControl(e.KeyChar)) &&
                (!(char.Equals(e.KeyChar, '\''))) && (!(char.Equals(e.KeyChar, '\"'))))
            {
                e.Handled = false;
                
            }
            else 
            {
                e.Handled = true;
                
            }
        }
        //Validate Discount Date
        internal static bool ValidateDiscountDate(string DiscountDate)
        {
                return (Regex.IsMatch(DiscountDate, @"^[0-9]{1,2}\/[0-9]{1,2}\/[0-9]{4}$"));
        }

        //Only allow proper keys for Address
        internal static void AllowedKeysAddress(KeyPressEventArgs e)
        {
            if ((char.IsLetterOrDigit(e.KeyChar) ||char.Equals(e.KeyChar, ' ')|| char.IsControl(e.KeyChar)) &&
                (!(char.Equals(e.KeyChar, '\''))) && (!(char.Equals(e.KeyChar, '\"'))))
            {
                e.Handled = false;
                
            }
            else
            {
                e.Handled = true;
                
            }
        }
        //Only allow proper keys for ZipCode
        internal static void AllowedKeysZipCode(KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) ||
                char.Equals(e.KeyChar, '-'))
            {
                e.Handled = false;
                
            }
            else
            {
                e.Handled = true;
                
            }
        }
        
        //Only allow proper keys for Email
        internal static void AllowedKeysEmail(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) ||
                char.Equals(e.KeyChar,'@') || char.Equals(e.KeyChar, '.') ||
                 char.Equals(e.KeyChar, '-') ||
                 char.Equals(e.KeyChar, '_') ||
                 char.Equals(e.KeyChar, '+'))
            {
                e.Handled = false;
             
            }
            else
            {
                e.Handled = true;
               
            }
        }

        internal static void AllowedKeysInt(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }
        }
        //Only allow proper keys for Phone
        internal static void AllowedKeysPhone(KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) ||
                char.Equals(e.KeyChar, '(') || char.Equals(e.KeyChar, ')') ||
                 char.Equals(e.KeyChar, '-') || char.Equals(e.KeyChar, '+') ||
                 char.Equals(e.KeyChar, ' '))
            {
                e.Handled = false;
                
            }
            else
            {
                e.Handled = true;
                
            }
        }
        //Only allow proper keys for Password
        internal static void AllowedKeysPassword(KeyPressEventArgs e)
        {
            string allowedSpecialChars = "()!@#$%^&*";
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) ||
                allowedSpecialChars.Contains(e.KeyChar))
            {
                e.Handled = false;
                
            }
            else
            {
                e.Handled = true;
                
            }
        }

        internal static bool ValidateCreditCardNumber(string creditCardVar)
        {
            return (Regex.IsMatch(creditCardVar, @"^[0-9]{4}[- ]?[0-9]{4}[- ]?[0-9]{4}[- ]?[0-9]{4}$"));
            
        }

        internal static bool ValidateCurrency(string currencyVar)
        {
            return (Regex.IsMatch(currencyVar, @"(?=.*\d)^(([1-9]\d{0,2}(\d{3})*)|0)?(\.\d{1,2})?$"));
        }

        

        internal static bool ValidatePercent(string percentVar)
        {
            return (Regex.IsMatch(percentVar, @"(?=.*\d)^(([1-9]\d{0,2}(\d{3})*)|0)?(\.\d{1,4})?$"));
        }



        internal static bool ValidateExpirationDate(string expirationDateVar)
        {
            if ((expirationDateVar.Length == 7))
            {
                if (
                    (((DateTime.Parse(expirationDateVar) - DateTime.Now).TotalDays <= 1825) &&
                    (DateTime.Parse(expirationDateVar) >= DateTime.Now))


                    && (Regex.IsMatch(expirationDateVar, @"^([0-9]{2}\/[0-9]{4})$|([0-9]{2}\/[0-9]{2})$")))
                {


                    //Put code to process order
                    return true;
                    
                }
                else
                {

                    return false;
                }
            }
            else if ((expirationDateVar.Length == 5))
            {
                if ((((DateTime.ParseExact(expirationDateVar, "M/yy", System.Globalization.CultureInfo.InvariantCulture) - DateTime.Now).TotalDays <= 1825)&&
                    (DateTime.ParseExact(expirationDateVar, "M/yy", System.Globalization.CultureInfo.InvariantCulture) >= DateTime.Now)) && 
                    (Regex.IsMatch(expirationDateVar, @"^([0-9]{2}\/[0-9]{4})$|([0-9]{2}\/[0-9]{2})$")))
                {


                    //Put code to process order
                    return true;
                }
                else
                {

                    return false;
                }


            }

            return false;
        }

        internal static bool ValidateCCV(string CCVVar)
        {
            return (Regex.IsMatch(CCVVar, @"^[0-9]{3}$"));    
        }


        internal static bool ValidateIntRegex(string intVar)
        {
            return (Regex.IsMatch(intVar, @"^(\d+)$"));
        }
        





















        #endregion
    }
}
