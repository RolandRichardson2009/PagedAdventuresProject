using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace FinalProject
{
    public partial class frmCustomerView : Form
    {
        //create variable to hold username for functions used later
        //public static string userName = frmLogon.UserName;
        //create variable to hold shopping cart increment or decrement
        public int currentModifierResultsLimiter = 0;
        //create variable to hold current page of product view
        public int currentPageNumber = 1;
        public frmCustomerView()
        {
            InitializeComponent();
        }



        //On Form Load, populate dataGridView
        //with items from Inventory Table, 
        //then format the columns properly
        #region frmCustomerView_Load
        private void frmCustomerView_Load(object sender, EventArgs e)
        {

            //MessageBox.Show("Just Before GetInventory command");
            //Fill DataGridView with items from Inventory Table

            

            clsSQL.GetInventory(dgvCustomerView,
                0,
                cbxCategories.SelectedIndex,
                tbxSearchByTitle.Text);



            dgvCustomerView.Columns[0].Width = 150;//Picture Column
            dgvCustomerView.Columns[1].Width = 250;//Title Column
            dgvCustomerView.Columns[2].Width = 75;//Price Column
            dgvCustomerView.Columns[2].DefaultCellStyle.Format
                = "c";//Format Price Column to currency format


            ((DataGridViewImageColumn)dgvCustomerView.Columns[0]).ImageLayout =
                DataGridViewImageCellLayout.Zoom;//Fit Picture to given area without stretching


            dgvCustomerView.Columns[3].Width = 80;//Quantity Column
            dgvCustomerView.Columns[4].Width = 60;//Row Count Column
            dgvCustomerView.Columns["InventoryID"].Visible = false;//Hide InventoryID from User but keep for use in code.



            //Set up current page number label
            if (((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{(clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
            }
            else
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
            }
            //Fill Combobox
            cbxCategories = clsSQL.GetCategories(cbxCategories);
            //Set current cell to first cell inorder to populate description and shoppingcart total as starting values
            dgvCustomerView.CurrentCell.Equals(dgvCustomerView.Rows[0]);
            //Set description to current cells value at startup
            rtbDescription.Text = clsSQL.GetDescription(int.Parse(dgvCustomerView.Rows[0].Cells["InventoryID"].Value.ToString()));
            if (clsSQL.CheckIfManager(frmLogon.UserName))
            {
                mnsProductsManager.Enabled = true;
                mnsProductsManager.Visible = true;
            }
            else
            {
                mnsProductsManager.Enabled = false;
                mnsProductsManager.Visible = false;
            }

            if (frmCustomers.PersonIDCurrentlySelected != -1)
            {
                lblCurrentCustomer.Text = ("Current Customer: " + frmCustomers.PersonIDCurrentlySelected).ToString();
            }
            else
            {
                lblCurrentCustomer.Text = "";
            }


        }//END frmCustomerView_Load
        #endregion



        //Return to frmLogon when
        //btnSignOut_Click is pressed
        #region btnSignOut_Click
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogon.UserName = "";
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
        }//END btnSignOut_Click
        #endregion



        //Return to frmLogon when
        //frmCustomerView is closed
        #region frmCustomerView_FormClosing
        private void frmCustomerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogon.UserName = "";
            //Show Main Menu Form
            var formToShow = Application.OpenForms.Cast<
                Form>().FirstOrDefault(c => c is frmLogon);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }//END frmCustomerView_FormClosing
        #endregion



        //This button changes view of dataGridView
        //by 1 page backwords if possible
        #region btnMinusOnePage_Click
        private void btnMinusOnePage_Click(object sender, EventArgs e)
        {
            try { //Only run if currentModifier Results Limiter > 0
            if (currentModifierResultsLimiter > 0)
            {
                //Fill datagridview with results based on Category, Title
                clsSQL.GetInventory(dgvCustomerView, currentModifierResultsLimiter -= 10, cbxCategories.SelectedIndex, tbxSearchByTitle.Text);
                //set current page number back 1
                currentPageNumber -= 1;
                //If total results is divisible by 10 with no remainders, display the following
                if (((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
                {
                    lblPageNumber.Text = $"Page {currentPageNumber} of " +
                        $"{(clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
                }
                //If total results is divisible by 10 but has remainders, display the following
                else
                {
                    lblPageNumber.Text = $"Page {currentPageNumber} of " +
                        $"{((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
                }
                //Enable Plus One Button because user was able to go back one page, which indicates they should be able to go forward one page
                btnPlusOnePage.Enabled = true;
                //If current Modifier Results Limiter is 0, disable Minus One Button because you should not be allowed to go less than page 1.
                if (currentModifierResultsLimiter == 0)
                {
                    btnMinusOnePage.Enabled = false;
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
        }//END btnMinusOnePage_Click
        #endregion



        //This button changes view of dataGridView
        //by 1 page forwards if possible
        #region btnPlusOnePage_Click
        private void btnPlusOnePage_Click(object sender, EventArgs e)
        {
            try { 
                //Only run if currentModifier Results Limiter > 0
            if (currentModifierResultsLimiter <
                ((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text) / 10) * 10))
            {
                //Fill datagridview with results based on Category, Title
                clsSQL.GetInventory(dgvCustomerView,
                    currentModifierResultsLimiter += 10, cbxCategories.SelectedIndex, tbxSearchByTitle.Text);
                //set current page number forward 1
                currentPageNumber += 1;
                //If total results is divisible by 10 with no remainders, display the following
                if (((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
                {
                    if (currentPageNumber == (clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10)
                    {
                        btnPlusOnePage.Enabled = false;
                    }
                    else
                    {
                        btnPlusOnePage.Enabled = true;
                    }
                    lblPageNumber.Text = $"Page {currentPageNumber} of " +
                        $"{(clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";

                }
                //If total results is divisible by 10 but has remainders, display the following
                else
                {
                    if (currentPageNumber == ((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1)
                    {
                        btnPlusOnePage.Enabled = false;
                    }
                    else
                    {
                        btnPlusOnePage.Enabled = true;
                    }
                    lblPageNumber.Text = $"Page {currentPageNumber} of " +
                        $"{((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";

                }
                //Enable Minus One Button because user was able to go forward one page, which indicates they should be able to go back one page
                btnMinusOnePage.Enabled = true;
                //If current Modifier Results Limiter is equal to the max number of pages, disable Plus One Button because you should not be allowed to go past last page.
                if (currentModifierResultsLimiter ==
                    ((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text) / 10) * 10))
                {
                    btnPlusOnePage.Enabled = false;
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
        }//END btnPlusOnePage_Click
        #endregion



        //Search products by Title
        #region btnSearch_Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try { 
            //If the category selected is valid, run the following
            if (cbxCategories.SelectedIndex >= 1)
            {
                //Reset current page number to one because you are retrieving a new set of data and starting at the first page
                currentPageNumber = 1;
                //Set currentModifierResultsLimiter to 0 to represent not moving forward or backwords through inventory
                currentModifierResultsLimiter = 0;
                //Fill datagridview with results based on Category, Title
                clsSQL.GetInventory(dgvCustomerView,
                        currentModifierResultsLimiter, cbxCategories.SelectedIndex, tbxSearchByTitle.Text);
                //If total results is divisible by 10 with no remainders, display the following
                if (((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
                {
                    lblPageNumber.Text = $"Page {currentPageNumber} of " +
                        $"{(clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
                }
                //If total results is divisible by 10 but has remainders, display the following
                else
                {
                    lblPageNumber.Text = $"Page {currentPageNumber} of " +
                        $"{((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
                }
                //Disable Minus One Button because you are starting on first page
                btnMinusOnePage.Enabled = false;
                //Only enable Plus One Button if there are more than one page of results.
                if ((((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1) >= 2)
                {
                    btnPlusOnePage.Enabled = true;
                }
                else
                {
                    btnPlusOnePage.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("You must select a category first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }//END btnSearch_Click
        #endregion


        //Clear all filters and return to original product view
        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            try{
                currentPageNumber = 1;
            tbxSearchByTitle.Text = "";
            cbxCategories.SelectedItem = null;
            clsSQL.GetInventory(dgvCustomerView, 0, cbxCategories.SelectedIndex, tbxSearchByTitle.Text);
            //Set up current page number label
            if (((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{(clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
            }
            else
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
            }
            btnPlusOnePage.Enabled = true;
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



        //Search by title and display results
        #region btnSearchByTitle_Click
        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            try { 
            //Reset current Page Number to 1
            currentPageNumber = 1;
            //Set current Modifier Results Limiter to 0
            currentModifierResultsLimiter = 0;
            //Fill DataGridView with items from Inventory Table
            //Filtered by Title
            clsSQL.SearchByTitle(
                tbxSearchByTitle.Text,//String 
                dgvCustomerView,//Datagridview
                        currentModifierResultsLimiter, //Int
                        cbxCategories.SelectedIndex);//Int
            //If Number Of Items is Divisable by 10 with no remainder, run this
            if (((clsSQL.GetTotalNumberOfItems(dgvCustomerView,
                cbxCategories.SelectedIndex,
                tbxSearchByTitle.Text)) % 10) == 0)
            {
                lblPageNumber.Text =
                    $"Page {currentPageNumber} of " +
                    $"{(clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
            }
            //If Number Of Items is Divisable by 10 with remainders left over, run this
            else
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
            }
            //Disable btnMinusOnePage because you are starting at page one.
            btnMinusOnePage.Enabled = false;

            //if there would be more than one page of results, enable btnPlusOnePage
            if ((((clsSQL.GetTotalNumberOfItems(dgvCustomerView, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1) >= 2)
            {
                btnPlusOnePage.Enabled = true;
            }
            //if there is only one page of results, disable btnPlusOnePage
            else
            {
                btnPlusOnePage.Enabled = false;
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
        }//END btnSearchByTitle_Click
        #endregion


        //When specific cell is clicked, update discription and Shopping Cart Quantity Displayed
        private void dgvCustomerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rtbDescription.Text = clsSQL.GetDescription(int.Parse(dgvCustomerView.Rows[dgvCustomerView.CurrentCell.RowIndex].Cells["InventoryID"].Value.ToString()));
            lstShoppingCart.SelectedItems.Clear();
        }



        //Add 1 of Selected Item to cart
        #region btnAddOne_Click
        private void btnAddOne_Click(object sender, EventArgs e)
        {
            try{
                int inventoryID = -1;
            string selectedItem = "";//Set selectedItem as blank for later
            //As long as there is at least 1 item in the listView,
            //Run the following
            if (lstShoppingCart.Items.Count > 0)
            {
                for (int i = 0; i < lstShoppingCart.Items.Count; i++)
                {
                    //Cycle through ListView until Selected Item is Found
                    if (lstShoppingCart.Items[i].Selected)
                    {
                        //If selectedItem has not already be set, set now
                        if (selectedItem == "")
                        {
                            selectedItem = lstShoppingCart.Items[i].Text;
                            break;
                        }
                    }
                }
            }
            //Set selected Quantity to blank for later
            string selectedQuantityVar = "";
            //Run as long as there is at least 1 item in list view
            if (lstShoppingCart.Items.Count > 0)
            {
                for (int i = 0; i < lstShoppingCart.Items.Count; i++)
                {
                    //Cycle through all items in the list view until
                    //the selected quantity is found.
                    if (lstShoppingCart.Items[i].Selected)
                    {
                        //If selected quantity has not been assigned,
                        //Assign now with selected quantity.
                        if (selectedQuantityVar == "")
                        {
                            selectedQuantityVar = lstShoppingCart.Items[i].SubItems[1].Text;
                            break;
                        }
                    }
                }
            }



            //Set quantityAdded to 1
            int quantityAdded = 1;
            //Run if something is selected in the listview but not in the datagridview
            if (dgvCustomerView.SelectedCells.Count == 0 && lstShoppingCart.Items.Count > 0)
            {
                //set inventoryID by searching by itemName
                inventoryID = (clsSQL.GetInventoryID(selectedItem));
                //Run if selectedQuantityVar is less than Quantity on hand,
                //and if inventoryID has been assigned a value other than -1
                if (inventoryID != -1 && (int.Parse(selectedQuantityVar) < clsSQL.GetQuantityOnHand(inventoryID))
                    && (clsSQL.GetQuantityOnHand(inventoryID) != 0))
                {
                    //Update listview with given values
                    lstShoppingCart = clsSQL.UpdateCart(
                        inventoryID,//pass in new inventoryID
                        quantityAdded,//Pass in Quantity Added
                        clsSQL.FindPersonID(frmLogon.UserName),//PersonID
                        lstShoppingCart,//Old ListView 
                        clsSQL.GetQuantityOnHand(inventoryID));//Quantity On Hand
                    lstShoppingCart.Refresh();//Refresh Listview to see updates
                }
            }

            //Run if nothing is selected in the listview 
            //and something is selected in the datagridview
            if (lstShoppingCart.SelectedItems.Count == 0 &&
                dgvCustomerView.SelectedCells.Count > 0)
            {
                //Get selected row and assign to inventoryID Variable
                inventoryID = (int.Parse(dgvCustomerView.
                    Rows[dgvCustomerView.CurrentCell.RowIndex].
                    Cells["InventoryID"].Value.ToString()));
                //only add to listview if quantity on hand is greater than 0,
                //and if inventory ID is not -1
                if (inventoryID != -1 &&
                    (clsSQL.GetQuantityOnHand(inventoryID) != 0))
                {
                    lstShoppingCart =
                        //Run Update cart function and
                        //give result to lstShoppingCart
                        clsSQL.UpdateCart(
                        inventoryID, //Selected inventoryID
                        quantityAdded,//quantity that will be added 
                        clsSQL.FindPersonID(frmLogon.UserName),//PersonID
                        lstShoppingCart,//current version of ListView
                        clsSQL.GetQuantityOnHand(inventoryID));//Current On Hand Quantity
                    lstShoppingCart.Refresh();//Refresh ListView to show new changes
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
        }//END btnAddOne_Click
        #endregion



        //Subtract 1 of Selected Item from cart if greater than 0
        #region btnSubtractOne_Click
        private void btnSubtractOne_Click(object sender, EventArgs e)
        {
            try { 
                //Set inventoryID to -1 to act as a flag
            //signifing that it has not yet recieved
            //a valid value.
            int inventoryID = -1;
            //Set selectedItem blank to prep for later
            string selectedItem = "";
            //Run the following if ListView has at least 1 item
            if (lstShoppingCart.Items.Count > 0)
            {
                //Run the following until all items have been checked
                for (int i = 0; i < lstShoppingCart.Items.Count; i++)
                {
                    //Check if current item is a selected item
                    if (lstShoppingCart.Items[i].Selected)
                    {
                        //if so, set selectedItem variable to
                        //selected cells text
                        if (selectedItem == "")
                        {
                            selectedItem = lstShoppingCart.Items[i].Text;
                            break;
                        }
                    }
                }
            }
            //if nothing is selected in the datagridview, and there is at least 1 item
            //in the listView, run the following
            if (dgvCustomerView.SelectedCells.Count == 0 && lstShoppingCart.Items.Count > 0)
            {
                //Set inventoryID equal to result from function,
                //items name is given as argument.
                inventoryID = (clsSQL.GetInventoryID(selectedItem));
            }

            //If nothing is selected in the listView, and something is selected in the datagridview,
            //run the following
            if (lstShoppingCart.SelectedItems.Count == 0 && dgvCustomerView.SelectedCells.Count > 0)
            {
                //set inventoryID equal to current cells InventoryID value.
                inventoryID = (int.Parse(dgvCustomerView.Rows[dgvCustomerView.CurrentCell.RowIndex].Cells["InventoryID"].Value.ToString()));
            }
            //set quantityAdded to -1 because we are removing 1 item from listView.
            int quantityAdded = -1;

            //As long as inventoryID is not inital value of the placeholder -1, continue
            if (inventoryID != -1)
            {
                //Set listview to new listview created,
                //by UpdateCart function
                lstShoppingCart = clsSQL.UpdateCart(
                    inventoryID,//Pass in new inventoryID 
                    quantityAdded,//Pass in the -1 because we are subtracting 1 
                    clsSQL.FindPersonID(frmLogon.UserName),//Pass in PersonID 
                    lstShoppingCart,//Pass in old listView 
                    clsSQL.GetQuantityOnHand(inventoryID));//Get Quantity on hand
                lstShoppingCart.Refresh();//refresh listview to show new values
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
        }//END btnSubtractOne_Click
        #endregion



        //Display Reciept as long as correct
        //credit card information is entered
        #region btnPurchase_Click
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (lstShoppingCart.Items.Count > 0 && frmCustomers.PersonIDCurrentlySelected != clsSQL.FindPersonID(frmLogon.UserName))
            {
                try
                {
                    //Check if the following are valid before continuing

                    if ((cbxCardType.SelectedIndex == 1 ||     //Check if Visa or MasterCard
                        cbxCardType.SelectedIndex == 2) &&     //Check if Visa or MasterCard
                        clsValidation.ValidateCreditCardNumber(//Check format of CCNumber
                            tbxCreditCardNumber.Text) &&       //Check format of CCNumber
                        clsValidation.ValidateExpirationDate(  //Check format of Exp Date
                            tbxExpirationDate.Text) &&         //Check format of Exp Date
                        clsValidation.ValidateCCV(tbxCCV.Text) //Check format of CCV
                         && (tbxDiscountCode.Text == "" ||     //check if Discount code is blank
                        ((clsSQL.CheckIfDiscountCodeExpired(   //check if discount code expired
                            tbxDiscountCode.Text)) &&          //check if discount code expired
                        clsSQL.CheckIfDiscountCodeHasStarted(  //check if discount code started
                            tbxDiscountCode.Text))))           //check if discount code started

                    {


                        bool isManager = clsSQL.CheckIfManager(frmLogon.UserName);


                        clsHTML.PrintReport(           //Print Reciept
                        clsHTML.GenerateReport(    //Create HTML Reciept
                            "Order Reciept",       //Reciept Title 
                            lstShoppingCart,       //Contents of Reciept 
                            tbxDiscountCode.Text, isManager));//Discount code if used



                        int CurrentPersonID = -1;
                        if (isManager)
                        {
                            CurrentPersonID = frmCustomers.PersonIDCurrentlySelected;
                        }
                        else
                        {
                            CurrentPersonID = clsSQL.FindPersonID(frmLogon.UserName);
                        }


                        int orderIDVar = clsSQL.CreateOrder(//Set orderIDVar to result of CreateOrder
                            tbxCreditCardNumber.Text,       //Pass in CreditCardNumber
                            tbxExpirationDate.Text,         //Pass in ExpirationDate
                            tbxCCV.Text,                    //Pass in CCV
                            tbxDiscountCode.Text,           //Pass in Discount Code
                            CurrentPersonID); //Pass in PersonID

                        //Update on hand quantities and Store Order Details and Order
                        clsSQL.UpdateInventory(
                            lstShoppingCart,     //Pass in current ListView
                            tbxDiscountCode.Text,//Pass in DiscountCode
                            orderIDVar);         //Pass in OrderID

                        MessageBox.Show(                  //Display message to user
                            "Your order has been placed.",//Message Body 
                            "Success",                    //Message Title
                            MessageBoxButtons.OK,         //Message Interaction
                            MessageBoxIcon.Information);  //Message Type

                        lstShoppingCart.Items.Clear();//Empty Listview for next order
                                                      //Fill DataGridView with items from Inventory Table
                        clsSQL.GetInventory(dgvCustomerView,
                            0,
                            cbxCategories.SelectedIndex,
                            tbxSearchByTitle.Text);
                        dgvCustomerView.Refresh();    //Refresh DataGridView with new quantities
                    }
                    else
                    {
                        //This section handles guiding user through their errors in creditcard section.

                        if (!(cbxCardType.SelectedIndex == 1 || //User must select Visa or Mastercard
                            cbxCardType.SelectedIndex == 2))    //User must select Visa or Mastercard
                        {
                            MessageBox.Show(          //Display Message to user.
                                "You must select a " +//Message Body
                                "valid card type.",   //Message Body 
                                "Error",              //Message Title
                                MessageBoxButtons.OK, //Message Interaction
                                MessageBoxIcon.Error);//Message Type

                            cbxCardType.Focus();      //Focus on cbxCardType
                        }
                        else if (!(clsValidation.       //Incorrect CCNumber? Run below.
                            ValidateCreditCardNumber(   //Incorrect CCNumber? Run below.
                            tbxCreditCardNumber.Text))) //Incorrect CCNumber? Run below.
                        {
                            MessageBox.Show(               //Display Message to user.
                                "You must enter a valid " +//Message Body
                                "Credit Card Number.",     //Message Body
                                "Error",                   //Message Title
                                MessageBoxButtons.OK,      //Message Interaction
                                MessageBoxIcon.Error);     //Message Type
                            tbxCreditCardNumber.Focus();   //Focus on CCNumber
                        }
                        else if (!(clsValidation.          //Validate ExpirationDate
                            ValidateExpirationDate(        //Validate ExpirationDate
                            tbxExpirationDate.Text)))      //Validate ExpirationDate
                        {
                            MessageBox.Show(               //Display Message to user.
                                "You must enter a valid " +//Message Body
                                "Expiration Date.",        //Message Body
                                "Error",                   //Message Title
                                MessageBoxButtons.OK,      //Message Interaction
                                MessageBoxIcon.Error);     //Message Type
                            tbxExpirationDate.Focus();     //Focus on Expiration Date
                        }
                        else if (!(clsValidation.          //Validate CCV
                            ValidateCCV(                   //Validate CCV
                            tbxCCV.Text)))                 //Validate CCV
                        {
                            MessageBox.Show(                  //Display Message to user.
                                "You must enter a valid CCV.",//Message Body
                                "Error",                      //Message Title
                                MessageBoxButtons.OK,         //Message Interaction
                                MessageBoxIcon.Error);        //Message Type
                            tbxCCV.Focus();                   //Focus on CCV
                        }
                        else if (!(tbxDiscountCode.Text == "" ||
                        ((clsSQL.CheckIfDiscountCodeExpired(tbxDiscountCode.Text)) &&
                        clsSQL.CheckIfDiscountCodeHasStarted(tbxDiscountCode.Text))
                        ))
                        {
                            MessageBox.Show(                       //Display Message to user.
                                "You must enter a valid Discount " +//Message Body
                                "Code, or leave it blank.",        //Message Body
                                "Error",                           //Message Title
                                MessageBoxButtons.OK,              //Message Interaction
                                MessageBoxIcon.Error);             //Message Type
                            tbxDiscountCode.Focus();               //Focus on Discount Code
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
            else {
                if (frmCustomers.PersonIDCurrentlySelected == clsSQL.FindPersonID(frmLogon.UserName))
                {
                    MessageBox.Show("You must first select a customer to check out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }//END btnPurchase_Click
            #endregion



            //Show or hide Credit Card Info
            #region btnToggleCreditCardVisibility_Click
            private void btnToggleCreditCardVisibility_Click(object sender, EventArgs e)
            {
                try {
                    //if Credit Card Number char is *, change to original value
                    if (tbxCreditCardNumber.PasswordChar == '*')
                    {
                        tbxCreditCardNumber.PasswordChar = '\0';
                    }
                    else
                    {
                        //Changes Credit Card Number characters back to *
                        tbxCreditCardNumber.PasswordChar = '*';
                    }

                    //if tbxExpirationDate char is *, change to original value
                    if (tbxExpirationDate.PasswordChar == '*')
                    {
                        tbxExpirationDate.PasswordChar = '\0';
                    }
                    else
                    {
                        //Changes tbxExpirationDate characters back to *
                        tbxExpirationDate.PasswordChar = '*';
                    }

                    //if tbxCCV char is *, change to original value
                    if (tbxCCV.PasswordChar == '*')
                    {
                        tbxCCV.PasswordChar = '\0';
                    }
                    else
                    {
                        //Changes tbxCCV characters back to *
                        tbxCCV.PasswordChar = '*';
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
            }//END btnToggleCreditCardVisibility_Click
            #endregion



            //Display correct help file
            private void btnHelp_Click(object sender, EventArgs e)
            {
                try {
                    clsHelp.LoadPDF("frmCustomerView");
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

            private void lstShoppingCart_Click(object sender, EventArgs e)
            {
                dgvCustomerView.ClearSelection();
            }

            private void btnClearCart_Click(object sender, EventArgs e)
            {
                try {
                    for (int x = (lstShoppingCart.Items.Count - 1); x >= 0; x--)
                    {

                        lstShoppingCart.Items[x].Remove();

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

            private void btnRemoveSelected_Click(object sender, EventArgs e)
            {
                try {
                    string selectedItem = "";
                    if (lstShoppingCart.Items.Count > 0)
                    {
                        for (int i = 0; i < lstShoppingCart.Items.Count; i++)
                        {
                            if (lstShoppingCart.Items[i].Selected)
                            {
                                if (selectedItem == "")
                                {
                                    //selectedItem = lstShoppingCart.Items[i].Text;
                                    lstShoppingCart.Items[i].Remove();
                                    break;
                                }
                            }
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

            private void mnsProductsManagerInventory_Click(object sender, EventArgs e)
            {
                try {
                    frmInventory frmInventoryVar = new frmInventory();
                    this.Hide();
                    frmInventoryVar.ShowDialog();
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

            private void mnsProductsManagerDiscounts_Click(object sender, EventArgs e)
            {
                try {
                    frmDiscounts frmDiscountsVar = new frmDiscounts();
                    this.Hide();
                    frmDiscountsVar.ShowDialog();
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

            private void mnsProductsManagerPersonnel_Click(object sender, EventArgs e)
            {
                try {
                    frmPersonnel frmPersonnelVar = new frmPersonnel();
                    this.Hide();
                    frmPersonnelVar.ShowDialog();
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

            private void mnsProductsManagerCustomers_Click(object sender, EventArgs e)
            {
                try {
                    frmCustomers frmCustomersVar = new frmCustomers();
                    this.Hide();
                    frmCustomersVar.ShowDialog();
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

            private void mnsProductsManagerReports_Click(object sender, EventArgs e)
            {
                try
                {
                    frmReports frmReportsVar = new frmReports();
                    this.Hide();
                    frmReportsVar.ShowDialog();
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

            private void frmCustomerView_Activated(object sender, EventArgs e)
            {
                if (frmCustomers.PersonIDCurrentlySelected != -1)
                {
                    lblCurrentCustomer.Text = ("Current Customer: " + frmCustomers.PersonIDCurrentlySelected).ToString();
                }
                else
                {
                    lblCurrentCustomer.Text = "";
                }
            if (clsSQL.CheckIfManager(frmLogon.UserName))
            {
                mnsProductsManager.Enabled = true;
                mnsProductsManager.Visible = true;
            }
            else
            {
                mnsProductsManager.Enabled = false;
                mnsProductsManager.Visible = false;
            }
        }
        }
    
}
