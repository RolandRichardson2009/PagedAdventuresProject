using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject

{
    public partial class frmInventory : Form
    {

        //create variable to hold shopping cart increment or decrement
        public int currentModifierResultsLimiter = 0;
        //create variable to hold current page of product view
        public int currentPageNumber = 1;
        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Show Main Menu Form
            var formToShow = Application.OpenForms.Cast<
                Form>().FirstOrDefault(c => c is frmCustomerView);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            dgvInventoryManager =
                clsSQL.GetInventory(
                    dgvInventoryManager,
                    0,
                    cbxCategories.SelectedIndex,
                    tbxSearchByTitle.Text,
                    true);

            //Set up current page number label
            if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
            }
            else
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
            }
            //Fill Combobox
            cbxCategories = clsSQL.GetCategories(cbxCategories);
            cbxCategory = clsSQL.GetCategories(cbxCategory);
            ((DataGridViewImageColumn)dgvInventoryManager.Columns[9]).ImageLayout =
                DataGridViewImageCellLayout.Zoom;//Fit Picture to given area without stretching
            dgvInventoryManager.Columns[0].Width = 120;//Name
            dgvInventoryManager.Columns[0].DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInventoryManager.Columns[1].Width = 70;//CategoryID
            dgvInventoryManager.Columns[1].DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInventoryManager.Columns[2].Width = 80;//Price
            dgvInventoryManager.Columns[2].DefaultCellStyle.Format = "c";
            dgvInventoryManager.Columns[3].Width = 80;//Cost
            dgvInventoryManager.Columns[3].DefaultCellStyle.Format = "c";
            dgvInventoryManager.Columns[4].Width = 90;//Restock Threshold
            dgvInventoryManager.Columns[4].DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInventoryManager.Columns[5].Width = 40;//Qty
            dgvInventoryManager.Columns[6].Width = 80;//Discontinued
            dgvInventoryManager.Columns[6].DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInventoryManager.Columns[7].Width = 30;//Row Number
            dgvInventoryManager.Columns[7].DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInventoryManager.Columns[8].Width = 80;//InventoryID
            dgvInventoryManager.Columns[8].DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvInventoryManager.Columns[9].Width = 180;//Picture Column


            //Warn Manager of items that are below restock threshold.
            clsSQL.LowInventoryWarning();
        }

        private void btnPlusOnePage_Click(object sender, EventArgs e)
        {
            try
            {
                //Only run if currentModifier Results Limiter > 0
                if (currentModifierResultsLimiter <
                    ((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text) / 10) * 10))
                {
                    //Fill datagridview with results based on Category, Title
                    clsSQL.GetInventory(
                        dgvInventoryManager,
                        currentModifierResultsLimiter += 10,
                        cbxCategories.SelectedIndex,
                        tbxSearchByTitle.Text,
                        true);
                    //set current page number forward 1
                    currentPageNumber += 1;
                    //If total results is divisible by 10 with no remainders, display the following
                    if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
                    {
                        if (currentPageNumber == (clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10)
                        {
                            btnPlusOnePage.Enabled = false;
                        }
                        else
                        {
                            btnPlusOnePage.Enabled = true;
                        }
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";

                    }
                    //If total results is divisible by 10 but has remainders, display the following
                    else
                    {
                        if (currentPageNumber == ((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1)
                        {
                            btnPlusOnePage.Enabled = false;
                        }
                        else
                        {
                            btnPlusOnePage.Enabled = true;
                        }
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";

                    }
                    //Enable Minus One Button because user was able to go forward one page, which indicates they should be able to go back one page
                    btnMinusOnePage.Enabled = true;
                    //If current Modifier Results Limiter is equal to the max number of pages, disable Plus One Button because you should not be allowed to go past last page.
                    if (currentModifierResultsLimiter ==
                        ((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text) / 10) * 10))
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
        }

        private void btnMinusOnePage_Click(object sender, EventArgs e)
        {
            try
            {
                //Only run if currentModifier Results Limiter > 0
                if (currentModifierResultsLimiter > 0)
                {
                    //Fill datagridview with results based on Category, Title
                    clsSQL.GetInventory(
                        dgvInventoryManager,
                        currentModifierResultsLimiter -= 10,
                        cbxCategories.SelectedIndex,
                        tbxSearchByTitle.Text,
                        true);
                    //set current page number back 1
                    currentPageNumber -= 1;
                    //If total results is divisible by 10 with no remainders, display the following
                    if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
                    {
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
                    }
                    //If total results is divisible by 10 but has remainders, display the following
                    else
                    {
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
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
        }

        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            try
            {
                //If the category selected is valid, run the following
                if (cbxCategories.SelectedIndex >= 1)
                {
                    //Reset current page number to one because you are retrieving a new set of data and starting at the first page
                    currentPageNumber = 1;
                    //Set currentModifierResultsLimiter to 0 to represent not moving forward or backwords through inventory
                    currentModifierResultsLimiter = 0;
                    //Fill datagridview with results based on Category, Title
                    clsSQL.GetInventory(dgvInventoryManager,
                            currentModifierResultsLimiter,
                            cbxCategories.SelectedIndex,
                            tbxSearchByTitle.Text,
                            true);
                    //If total results is divisible by 10 with no remainders, display the following
                    if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager,
                        cbxCategories.SelectedIndex,
                        tbxSearchByTitle.Text)) % 10) == 0)
                    {
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
                    }
                    //If total results is divisible by 10 but has remainders, display the following
                    else
                    {
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
                    }
                    //Disable Minus One Button because you are starting on first page
                    btnMinusOnePage.Enabled = false;
                    //Only enable Plus One Button if there are more than one page of results.
                    if ((((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1) >= 2)
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
        }

        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            try
            {
                //Reset current Page Number to 1
                currentPageNumber = 1;
                //Set current Modifier Results Limiter to 0
                currentModifierResultsLimiter = 0;
                //Fill DataGridView with items from Inventory Table
                //Filtered by Title
                clsSQL.SearchByTitle(
                    tbxSearchByTitle.Text,//String 
                    dgvInventoryManager,//Datagridview
                            currentModifierResultsLimiter, //Int
                            cbxCategories.SelectedIndex);//Int
                                                         //If Number Of Items is Divisable by 10 with no remainder, run this
                if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager,
                    cbxCategories.SelectedIndex,
                    tbxSearchByTitle.Text)) % 10) == 0)
                {
                    lblPageNumber.Text =
                        $"Page {currentPageNumber} of " +
                        $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
                }
                //If Number Of Items is Divisable by 10 with remainders left over, run this
                else
                {
                    lblPageNumber.Text = $"Page {currentPageNumber} of " +
                        $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
                }
                //Disable btnMinusOnePage because you are starting at page one.
                btnMinusOnePage.Enabled = false;

                //if there would be more than one page of results, enable btnPlusOnePage
                if ((((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1) >= 2)
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
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            try
            {
                currentPageNumber = 1;
                tbxSearchByTitle.Text = "";
                cbxCategories.SelectedItem = null;
                clsSQL.GetInventory(
                    dgvInventoryManager,
                    0,
                    cbxCategories.SelectedIndex,
                    tbxSearchByTitle.Text,
                    true);
                //Set up current page number label
                if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
                {
                    lblPageNumber.Text = $"Page {currentPageNumber} of " +
                        $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
                }
                else
                {
                    lblPageNumber.Text = $"Page {currentPageNumber} of " +
                        $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
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

        private void dgvInventoryManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text =
                dgvInventoryManager.
                SelectedRows[0].
                Cells[0].
                Value.
                ToString();

            cbxCategory.SelectedIndex =
                int.Parse(
                    dgvInventoryManager.
                SelectedRows[0].
                Cells[1].
                Value.
                ToString());

            tbxPrice.Text =
                ((Decimal.Parse(
                    dgvInventoryManager.
                    SelectedRows[0].
                    Cells[2].Value.
                    ToString()).
                    ToString("C")));

            tbxCost.Text =
                ((Decimal.Parse(
                    dgvInventoryManager.
                    SelectedRows[0].
                    Cells[3].
                    Value.
                    ToString()).
                    ToString("C")));

            tbxRestockThreshold.Text =
                dgvInventoryManager.
                SelectedRows[0].
                Cells[4].
                Value.
                ToString();

            tbxQuantity.Text =
                dgvInventoryManager.
                SelectedRows[0].
                Cells[5].
                Value.
                ToString();

            rtbDescription.Text =
                clsSQL.
                GetDescription(
                    clsSQL.
                    GetInventoryID(
                        dgvInventoryManager.
                        SelectedRows[0].
                        Cells[0].
                        Value.
                        ToString()));

        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                        (clsValidation.ValidateIntRegex(tbxQuantity.Text) &&
                        clsValidation.ValidateIntRegex(tbxRestockThreshold.Text)) &&
                        dgvInventoryManager.SelectedRows.Count > 0 &&
                        rtbDescription.Text != "")
                {


                    clsSQL.UpdateInventoryManager(
                        tbxName.Text,
                        cbxCategory.SelectedIndex,
                        tbxPrice.Text,
                        tbxCost.Text,
                        tbxRestockThreshold.Text,
                        tbxQuantity.Text,
                        ckbDiscontinued.Checked.ToString(),
                        dgvInventoryManager.SelectedRows[0].Cells[8].Value.ToString(),
                        rtbDescription.Text);



                    currentPageNumber = 1;
                    tbxSearchByTitle.Text = "";
                    cbxCategories.SelectedItem = null;
                    clsSQL.GetInventory(
                        dgvInventoryManager,
                        0,
                        cbxCategories.SelectedIndex,
                        tbxSearchByTitle.Text,
                        true);
                    //Set up current page number label
                    if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
                    {
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
                    }
                    else
                    {
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
                    }
                    btnPlusOnePage.Enabled = true;

                    tbxName.Text = dgvInventoryManager.SelectedRows[0].Cells[0].Value.ToString();
                    cbxCategory.SelectedIndex = int.Parse(dgvInventoryManager.SelectedRows[0].Cells[1].Value.ToString());

                    tbxPrice.Text = ((Decimal.Parse(dgvInventoryManager.SelectedRows[0].Cells[2].Value.ToString()).ToString("C")));
                    tbxCost.Text = ((Decimal.Parse(dgvInventoryManager.SelectedRows[0].Cells[3].Value.ToString()).ToString("C")));
                    tbxRestockThreshold.Text = dgvInventoryManager.SelectedRows[0].Cells[4].Value.ToString();
                    tbxQuantity.Text = dgvInventoryManager.SelectedRows[0].Cells[5].Value.ToString();



                    rtbDescription.Text = clsSQL.GetDescription(clsSQL.GetInventoryID(dgvInventoryManager.SelectedRows[0].Cells[0].Value.ToString()));




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
            catch (Exception)
            {
                MessageBox.Show(
                    "Connection Timed Out... Please check you network connection.",
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }




        }

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventoryManager.SelectedRows.Count > 0)
                {
                    //TODO: Add some validation to make sure the file is an image.

                    //OpenFileDialog Properties------------------------------------------
                    OpenFileDialog openFile = new OpenFileDialog(); //New instance
                    openFile.ValidateNames = true; //Prevent illegal characters
                    openFile.AddExtension = false; //Auto fixes file extension problems
                    openFile.Filter = "Image File|*.png|Image File|*.jpg"; //Allow types
                    openFile.Title = "File to Upload"; //Title of dialog box
                                                       //-------------------------------------------------------------------

                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        //TODO: Add some validation to make sure the file is an image.

                        byte[] image = File.ReadAllBytes(openFile.FileName); //Convert image into a byte array
                        image = File.ReadAllBytes(openFile.FileName); //Convert image into a byte array

                        clsSQL.AddImageToDatabase(image, int.Parse(dgvInventoryManager.SelectedRows[0].Cells[8].Value.ToString()));

                    }



                    currentPageNumber = 1;
                    tbxSearchByTitle.Text = "";
                    cbxCategories.SelectedItem = null;
                    clsSQL.GetInventory(
                        dgvInventoryManager,
                        0,
                        cbxCategories.SelectedIndex,
                        tbxSearchByTitle.Text,
                        true);
                    //Set up current page number label
                    if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
                    {
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
                    }
                    else
                    {
                        lblPageNumber.Text = $"Page {currentPageNumber} of " +
                            $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
                    }
                    btnPlusOnePage.Enabled = true;

                    tbxName.Text = dgvInventoryManager.SelectedRows[0].Cells[0].Value.ToString();
                    cbxCategory.SelectedIndex = int.Parse(dgvInventoryManager.SelectedRows[0].Cells[1].Value.ToString());

                    tbxPrice.Text = ((Decimal.Parse(dgvInventoryManager.SelectedRows[0].Cells[2].Value.ToString()).ToString("C")));
                    tbxCost.Text = ((Decimal.Parse(dgvInventoryManager.SelectedRows[0].Cells[3].Value.ToString()).ToString("C")));
                    tbxRestockThreshold.Text = dgvInventoryManager.SelectedRows[0].Cells[4].Value.ToString();
                    tbxQuantity.Text = dgvInventoryManager.SelectedRows[0].Cells[5].Value.ToString();



                    rtbDescription.Text = clsSQL.GetDescription(clsSQL.GetInventoryID(dgvInventoryManager.SelectedRows[0].Cells[0].Value.ToString()));

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

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int InventoryID = int.Parse(
                dgvInventoryManager.SelectedRows[0].
                Cells[8].Value.ToString());
            clsSQL.DeleteItem(InventoryID);
            currentPageNumber = 1;
            tbxSearchByTitle.Text = "";
            cbxCategories.SelectedItem = null;
            clsSQL.GetInventory(
                dgvInventoryManager,
                0,
                cbxCategories.SelectedIndex,
                tbxSearchByTitle.Text,
                true);
            //Set up current page number label
            if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
            }
            else
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
            }
            btnPlusOnePage.Enabled = true;
            tbxName.Text = dgvInventoryManager.SelectedRows[0].Cells[0].Value.ToString();
            cbxCategory.SelectedIndex = int.Parse(dgvInventoryManager.SelectedRows[0].Cells[1].Value.ToString());
            tbxPrice.Text = ((Decimal.Parse(dgvInventoryManager.SelectedRows[0].Cells[2].Value.ToString()).ToString("C")));
            tbxCost.Text = ((Decimal.Parse(dgvInventoryManager.SelectedRows[0].Cells[3].Value.ToString()).ToString("C")));
            tbxRestockThreshold.Text = dgvInventoryManager.SelectedRows[0].Cells[4].Value.ToString();
            tbxQuantity.Text = dgvInventoryManager.SelectedRows[0].Cells[5].Value.ToString();
            rtbDescription.Text = clsSQL.GetDescription(clsSQL.GetInventoryID(dgvInventoryManager.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            frmNewItem frmNewItemVar = new frmNewItem();
            this.Hide();
            frmNewItemVar.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();//close Form
                             //Show Main Menu Form
                var formToShow = Application.OpenForms.Cast<
                    Form>().FirstOrDefault(c => c is frmCustomerView);
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

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.AllowedKeysInt(e);
        }

        private void tbxRestockThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.AllowedKeysInt(e);
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            currentPageNumber = 1;
            tbxSearchByTitle.Text = "";
            cbxCategories.SelectedItem = null;
            clsSQL.GetInventory(
                dgvInventoryManager,
                0,
                cbxCategories.SelectedIndex,
                tbxSearchByTitle.Text,
                true);
            //Set up current page number label
            if (((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) % 10) == 0)
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{(clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10}";
            }
            else
            {
                lblPageNumber.Text = $"Page {currentPageNumber} of " +
                    $"{((clsSQL.GetTotalNumberOfItems(dgvInventoryManager, cbxCategories.SelectedIndex, tbxSearchByTitle.Text)) / 10) + 1}";
            }
            btnPlusOnePage.Enabled = true;
            tbxName.Text = dgvInventoryManager.SelectedRows[0].Cells[0].Value.ToString();
            cbxCategory.SelectedIndex = int.Parse(dgvInventoryManager.SelectedRows[0].Cells[1].Value.ToString());
            tbxPrice.Text = ((Decimal.Parse(dgvInventoryManager.SelectedRows[0].Cells[2].Value.ToString()).ToString("C")));
            tbxCost.Text = ((Decimal.Parse(dgvInventoryManager.SelectedRows[0].Cells[3].Value.ToString()).ToString("C")));
            tbxRestockThreshold.Text = dgvInventoryManager.SelectedRows[0].Cells[4].Value.ToString();
            tbxQuantity.Text = dgvInventoryManager.SelectedRows[0].Cells[5].Value.ToString();
            rtbDescription.Text = clsSQL.GetDescription(clsSQL.GetInventoryID(dgvInventoryManager.SelectedRows[0].Cells[0].Value.ToString()));
        }
    }
}
