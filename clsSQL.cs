//*******************************************
//*******************************************
// Programmer: Roland Richardson
// Course: INEW 2330.7Z1 (Final Project)
// Program Description: Bookstore application for inventroy management and sales.
//*******************************************
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace FinalProject
{
    internal class clsSQL
    {
        //Variable for clsSQL
        #region variables
        //connection string to Paged Adventures database
        private const string CONNECT_STRING =
        @"Server=cstnt.tstc.edu;" +
         "Database=inew2332su22;" +
         "User Id=RichardsonR22Su2332;" +
         "password=Password!2009";
        ////build a connection to PagedAdventures database
        private static SqlConnection _cntPagedAdventuresDatabase = new SqlConnection(@"Server=cstnt.tstc.edu;" +
         "Database=inew2332su22;" +
         "User Id=;" +
         "password=");
        //add the command object
        private static SqlCommand _sqlPagedAdventuresCommand;
        //add the data adapter
        private static SqlDataAdapter _daPagedAdventures = new SqlDataAdapter();
        //add the data table
        private static DataTable _dtPagedAdventuresTable = new DataTable();
        private static StringBuilder errorMessages = new StringBuilder();//add the data table
        #endregion

        internal static ListView GetSalesTotals(ListView tempListView, DateTime startDate, DateTime endDate)
        {
            try
            {
                //MessageBox.Show("Start Date: "+startDate + " End Date: "+endDate);
                OpenDatabasePagedAdventures();
                //statement for the command string
                string sqlStatement =
                "SELECT OrderDetails.Quantity, Orders.OrderDate, Inventory.RetailPrice " +
                "FROM((OrderDetails " +
                "INNER JOIN Orders ON Orders.OrderID = OrderDetails.OrderID) " +
                "INNER JOIN Inventory ON Inventory.InventoryID = OrderDetails.InventoryID) " +
                $"WHERE Orders.OrderDate >= '{startDate}' AND " +
                $"Orders.OrderDate <= '{endDate}';";
                /*
                    SELECT OrderDetails.Quantity, Orders.OrderDate, Inventory.RetailPrice
                    FROM ((OrderDetails
                    INNER JOIN Orders ON Orders.OrderID = OrderDetails.OrderID)
                    INNER JOIN Inventory ON Inventory.InventoryID = OrderDetails.InventoryID);
                 */


                //Join OrderDetails, Orders, Inventory




                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlStatement,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);
                //tempListView.DataSource =
                //_dtPagedAdventuresTable;
                CloseDisposeDatabasePagedAdventures();
                tempListView.Columns.Add("Quantity");
                tempListView.Columns.Add("OrderDate");
                tempListView.Columns.Add("RetailPrice");



                ListViewItem item4;
                for (int x = 0; x < _dtPagedAdventuresTable.Rows.Count; x++)
                {
                    item4 = tempListView.Items.Add((String)_dtPagedAdventuresTable.Rows[x][0].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][1].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][2].ToString());
                }
                
                return tempListView;




                //tempListView.Items[0].SubItems[0].Text = "";
                //tempListView.Columns[0][0].ToString();
                //return tempListView;
            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                                            "Error on DatabaseCommand",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
            }
            return tempListView;

        }

        internal static DataGridView GetPersonnel(DataGridView dgvPersonnel)
        {
            try
            {
                OpenDatabasePagedAdventures();
                //statement for the command string
                string sqlStatement =
                    "SELECT * " +
                "FROM Person " +
                $"WHERE PositionID = {1002};";
                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlStatement,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);
                dgvPersonnel.DataSource =
                _dtPagedAdventuresTable;
                CloseDisposeDatabasePagedAdventures();
                
                return dgvPersonnel;
            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                                            "Error on DatabaseCommand",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
            }
            return dgvPersonnel;
        }

        internal static ListView InventoryReportAvailableForSale(ListView queryResultsListView)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlQuery =
                "SELECT " +
                "InventoryID AS 'ItemID', " +
                "ItemName AS 'Name', " +
                "RetailPrice AS 'Price', " +
                "Cost, " +
                "Quantity AS 'Quantity On Hand', " +
                "RestockThreshold AS 'Restock Threshold', " +
                "Discontinued AS 'Availability' " +
                "FROM Inventory " +
                "WHERE (Discontinued = 0 OR Discontinued IS NULL);";

                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlQuery,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);
                //tempListView.DataSource =
                //_dtPagedAdventuresTable;


                queryResultsListView.Columns.Add("ItemID");
                queryResultsListView.Columns.Add("Name");
                queryResultsListView.Columns.Add("Price");
                queryResultsListView.Columns.Add("Cost");
                queryResultsListView.Columns.Add("Quantity On Hand");
                queryResultsListView.Columns.Add("Restock Threshold");
                queryResultsListView.Columns.Add("Availability");



                ListViewItem item4;
                for (int x = 0; x < _dtPagedAdventuresTable.Rows.Count; x++)
                {
                    item4 = queryResultsListView.Items.Add((String)_dtPagedAdventuresTable.Rows[x][0].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][1].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][2].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][3].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][4].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][5].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][6].ToString());
                }


                CloseDisposeDatabasePagedAdventures();
                return queryResultsListView;
            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                                            "Error on DatabaseCommand",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                return queryResultsListView;
            }
        }






        internal static ListView InventoryReportNeedsRestocking(ListView queryResultsListView)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlQuery =
                "SELECT " +
                "InventoryID AS 'ItemID', " +
                "ItemName AS 'Name', " +
                "RetailPrice AS 'Price', " +
                "Cost, " +
                "Quantity AS 'Quantity On Hand', " +
                "RestockThreshold AS 'Restock Threshold', " +
                "Discontinued AS 'Availability' " +
                "FROM Inventory " +
                "WHERE (Discontinued = 0 OR Discontinued IS NULL) AND " +
                "Quantity <= RestockThreshold;";

                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlQuery,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);
                //tempListView.DataSource =
                //_dtPagedAdventuresTable;


                queryResultsListView.Columns.Add("ItemID");
                queryResultsListView.Columns.Add("Name");
                queryResultsListView.Columns.Add("Price");
                queryResultsListView.Columns.Add("Cost");
                queryResultsListView.Columns.Add("Quantity On Hand");
                queryResultsListView.Columns.Add("Restock Threshold");
                queryResultsListView.Columns.Add("Availability");



                ListViewItem item4;
                for (int x = 0; x < _dtPagedAdventuresTable.Rows.Count; x++)
                {
                    item4 = queryResultsListView.Items.Add((String)_dtPagedAdventuresTable.Rows[x][0].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][1].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][2].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][3].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][4].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][5].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][6].ToString());
                }


                CloseDisposeDatabasePagedAdventures();
                return queryResultsListView;
            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                                            "Error on DatabaseCommand",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                return queryResultsListView;
            }
        }



        internal static ListView InventoryReportAllItems(ListView queryResultsListView)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlQuery =
                "SELECT " +
                "InventoryID AS 'ItemID', " +
                "ItemName AS 'Name', " +
                "RetailPrice AS 'Price', " +
                "Cost, " +
                "Quantity AS 'Quantity On Hand', " +
                "RestockThreshold AS 'Restock Threshold', " +
                "Discontinued AS 'Availability' " +
                "FROM Inventory;";
                

                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlQuery,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);
                //tempListView.DataSource =
                //_dtPagedAdventuresTable;


                queryResultsListView.Columns.Add("ItemID");
                queryResultsListView.Columns.Add("Name");
                queryResultsListView.Columns.Add("Price");
                queryResultsListView.Columns.Add("Cost");
                queryResultsListView.Columns.Add("Quantity On Hand");
                queryResultsListView.Columns.Add("Restock Threshold");
                queryResultsListView.Columns.Add("Availability");



                ListViewItem item4;
                for (int x = 0; x < _dtPagedAdventuresTable.Rows.Count; x++)
                {
                    item4 = queryResultsListView.Items.Add((String)_dtPagedAdventuresTable.Rows[x][0].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][1].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][2].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][3].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][4].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][5].ToString());
                    item4.SubItems.Add((String)_dtPagedAdventuresTable.Rows[x][6].ToString());
                }


                CloseDisposeDatabasePagedAdventures();
                return queryResultsListView;
            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                                            "Error on DatabaseCommand",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                return queryResultsListView;
            }
        }





        internal static void AddNewDiscount(
    string DiscountCode,
    string Description,
    string DiscountLevel,
    string InventoryID,
    string DiscountType,
    string DiscountPercentage,
    string DiscountDollarAmount,
    string StartDate,
    string ExpirationDate)
        {
            try
            {
                OpenDatabasePagedAdventures();
                //InventoryID - Can Be NULL
                string InventoryIDArgumentTop = "";
                string InventoryIDArgumentBottom = "";
                if (InventoryID != "")
                {
                    InventoryIDArgumentTop = "InventoryID, ";
                    InventoryIDArgumentBottom = $"{int.Parse(InventoryID)}, ";
                }
                //DiscountPercentage - Can Be NULL
                string DiscountPercentageArgumentTop = "";
                string DiscountPercentageArgumentBottom = "";
                if (DiscountPercentage != "")
                {
                    DiscountPercentageArgumentTop = "DiscountPercentage, ";
                    DiscountPercentageArgumentBottom = $"{decimal.Parse(DiscountPercentage)}, ";
                }
                //DiscountDollarAmount - Can Be NULL
                string DiscountDollarAmountArgumentTop = "";
                string DiscountDollarAmountArgumentBottom = "";
                if (DiscountDollarAmount != "")
                {
                    DiscountDollarAmountArgumentTop = "DiscountDollarAmount, ";
                    DiscountDollarAmountArgumentBottom = $"{decimal.Parse(DiscountDollarAmount)}, ";
                }
                //StartDate - Can Be NULL
                string StartDateArgumentTop = "";
                string StartDateArgumentBottom = "";
                if (StartDate != "")
                {
                    StartDateArgumentTop = "StartDate, ";
                    StartDateArgumentBottom = $"'{SqlDateTime.Parse(StartDate)}', ";
                }




                string sqlString = "INSERT INTO Discounts " +
                "(DiscountCode, " +
                "Description, " +
                "DiscountLevel, " +
                InventoryIDArgumentTop +//Possible NULL
                "DiscountType, " +
                DiscountPercentageArgumentTop +//Possible NULL
                DiscountDollarAmountArgumentTop +//Possible NULL
                StartDateArgumentTop +//Possible NULL
                "ExpirationDate) " +
                $"VALUES ('{DiscountCode}', " +
                $"'{Description}', " +
                $"{int.Parse(DiscountLevel)}, " +
                InventoryIDArgumentBottom +//Possible NULL
                $"{int.Parse(DiscountType)}, " +
                DiscountPercentageArgumentBottom +//Possible NULL
                DiscountDollarAmountArgumentBottom +//Possible NULL
                StartDateArgumentBottom +//Possible NULL
                $"'{SqlDateTime.Parse(ExpirationDate)}');";

                SqlCommand insertCmd =
                    new SqlCommand(
                        sqlString,
                        _cntPagedAdventuresDatabase);
                insertCmd.ExecuteNonQuery();
                CloseDisposeDatabasePagedAdventures();
                MessageBox.Show("Successfully added a new Discount.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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

        internal static void AddPerson(
            string Title,
            string FirstName,
            string MiddleName,
            string LastName,
            string Suffix,
            string AddressOne,
            string AddressTwo,
            string AddressThree,
            string City,
            string Zipcode,
            string State,
            string Email,
            string PrimaryPhone,
            string SecondaryPhone,
            int PositionID)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlString = "INSERT INTO Person " +
               "(Title, " +
               "NameFirst, " +
               "NameMiddle, " +
               "NameLast, " +
               "Suffix, " +
               "Address1, " +
               "Address2, " +
               "Address3, " +
               "City, " +
               "Zipcode, " +
               "State, " +
               "Email, " +
               "PhonePrimary, " +
               "PhoneSecondary, " +
               "PositionID) " +
               $"VALUES " +
               $"('{Title}', " +
               $"'{FirstName}', " +
               $"'{MiddleName}', " +
               $"'{LastName}', " +
               $"'{Suffix}', " +
               $"'{AddressOne}', " +
               $"'{AddressTwo}', " +
               $"'{AddressThree}', " +
               $"'{City}', " +
               $"'{Zipcode}', " +
               $"'{State}', " +
               $"'{Email}', " +
               $"'{PrimaryPhone}', " +
               $"'{SecondaryPhone}', " +
               $"{PositionID})";
                SqlCommand insertCmd = new SqlCommand(sqlString, _cntPagedAdventuresDatabase);
                insertCmd.ExecuteNonQuery();
                CloseDisposeDatabasePagedAdventures();
                MessageBox.Show("Successfully added a new item.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        internal static string GetNameOfManager(string userName)
        {
            try
            {
                int PersonID = clsSQL.FindPersonID(userName);

                OpenDatabasePagedAdventures();
                string sqlIntVar = "SELECT NameFirst " +
                    $"FROM Person " +
                    $"WHERE PersonID = {PersonID}";

                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlIntVar, _cntPagedAdventuresDatabase);
                string FirstNameResult = (string)_sqlPagedAdventuresCommand.ExecuteScalar();
                CloseDisposeDatabasePagedAdventures();



                

                OpenDatabasePagedAdventures();
                string sqlIntVar2 = "SELECT NameLast " +
                    $"FROM Person " +
                    $"WHERE PersonID = {PersonID}";

                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlIntVar2, _cntPagedAdventuresDatabase);
                string LastNameResult = (string)_sqlPagedAdventuresCommand.ExecuteScalar();
                CloseDisposeDatabasePagedAdventures();






                return FirstNameResult + " " + LastNameResult;
            }
            catch (Exception)
            { return ""; }
        }

        internal static void UpdatePerson(
            string Title, 
            string FirstName, 
            string MiddleName, 
            string LastName, 
            string Suffix, 
            string AddressOne, 
            string AddressTwo, 
            string AddressThree,
            string City, 
            string Zipcode, 
            string State, 
            string Email, 
            string PrimaryPhone, 
            string SecondaryPhone, 
            string PersonID)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement2 = "UPDATE Person " +
                 $"SET " +
                 $"Title = '{Title}', " +
                 $"NameFirst = '{FirstName}', " +
                 $"NameMiddle = '{MiddleName}', " +
                 $"NameLast = '{LastName}', " +
                 $"Suffix = '{Suffix}', " +
                 $"Address1 = '{AddressOne}', " +
                 $"Address2 = '{AddressTwo}', " +
                 $"Address3 = '{AddressThree}', " +
                 $"City = '{City}', " +
                 $"Zipcode = '{Zipcode}', " +
                 $"State = '{State}', " +
                 $"Email = '{Email}', " +
                 $"PhonePrimary = '{PrimaryPhone}', " +
                 $"PhoneSecondary = '{SecondaryPhone}' " +
                 $"WHERE PersonID = {int.Parse(PersonID)};";

                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                _sqlPagedAdventuresCommand.ExecuteNonQuery();

                CloseDisposeDatabasePagedAdventures();
                MessageBox.Show("Update Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                CloseDisposeDatabasePagedAdventures();
            }
        }

        internal static void ToggleDisableAccout(int PersonID, bool Result)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement2 = "UPDATE Logon " +
                 $"SET " +
                 $"AccountDisabled = '{Result}' " +
                 $"WHERE PersonID = {PersonID};";

                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                _sqlPagedAdventuresCommand.ExecuteNonQuery();

                CloseDisposeDatabasePagedAdventures();
                MessageBox.Show("Update Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                CloseDisposeDatabasePagedAdventures();
            }
        }

        internal static void DeletePerson(int PersonID)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement2 = $"DELETE Person " +
                $"WHERE PersonID = {PersonID}";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                _sqlPagedAdventuresCommand.ExecuteNonQuery();

                CloseDisposeDatabasePagedAdventures();
            }
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
                CloseDisposeDatabasePagedAdventures();
            }
        }

        internal static DataGridView GetCustomers(DataGridView dgvCustomers)
        {
            try
            {
                OpenDatabasePagedAdventures();
                //statement for the command string
                string sqlStatement =
                    "SELECT * " +
                "FROM Person " +
                $"WHERE PositionID = {1000};";
                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlStatement,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);
                dgvCustomers.DataSource =
                _dtPagedAdventuresTable;
                CloseDisposeDatabasePagedAdventures();
                return dgvCustomers;
            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                                            "Error on DatabaseCommand",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
            }
            return dgvCustomers;
        }







        internal static DataGridView SearchCustomers(
            DataGridView dgvCustomers, 
            string PrimaryPhone,
            string Email,
            string LastName,
            string FirstName)
        {
            try
            {
                OpenDatabasePagedAdventures();
                //statement for the command string
                string sqlStatement =
                    "SELECT * " +
                "FROM Person " +
                $"WHERE PositionID = {1000} AND " +
                $"(PhonePrimary LIKE '%{PrimaryPhone}%' OR PhonePrimary IS NULL) AND " +
                $"(Email LIKE '%{Email}%' OR Email IS NULL ) AND " +
                $"NameLast LIKE '%{LastName}%' AND " +
                $"NameFirst LIKE '%{FirstName}%';";
                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlStatement,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);
                dgvCustomers.DataSource =
                _dtPagedAdventuresTable;
                CloseDisposeDatabasePagedAdventures();
                return dgvCustomers;
            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                                            "Error on DatabaseCommand",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
            }
            return dgvCustomers;
        }














        //Check if connection is open
        private static bool DBConnectionStatus()
        {
            try
            {
                using (SqlConnection sqlConn =
                    new SqlConnection(CONNECT_STRING))
                {
                    sqlConn.Open();
                    return (sqlConn.State == ConnectionState.Open);
                }
            }
            catch (SqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal static DataGridView GetDiscounts(DataGridView dgvDiscounts)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement =
                        "SELECT * " +
                    "FROM Discounts;";
                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlStatement,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);
                dgvDiscounts.DataSource =
                    _dtPagedAdventuresTable;
                CloseDisposeDatabasePagedAdventures();
                return dgvDiscounts;
            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                    return dgvDiscounts;
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                    return dgvDiscounts;
                }
                CloseDisposeDatabasePagedAdventures();
                return dgvDiscounts;
            }
        }

        internal static void DeleteDiscountCode(int DiscountID)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement2 = $"DELETE Discounts " +
                $"WHERE DiscountID = {DiscountID}";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                _sqlPagedAdventuresCommand.ExecuteNonQuery();

                CloseDisposeDatabasePagedAdventures();
            }
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
                CloseDisposeDatabasePagedAdventures();
            }
        }

        internal static void UpdateSelectedDiscount(
            string DiscountID,
            string DiscountCode,
            string Description,
            string DiscountLevel,
            string InventoryID,
            string DiscountType,
            string DiscountPercentage,
            string DiscountDollarAmount,
            string StartDate,
            string ExpirationDate)
        {
            try
            {
                OpenDatabasePagedAdventures();

                string InventoryIDArgument = "";
                if (InventoryID != "")
                {
                    InventoryIDArgument = $"InventoryID = {int.Parse(InventoryID)}, ";//int - Can be NULL
                }

                string DiscountPercentageArgument = "";
                if (DiscountPercentage != "")
                {
                    DiscountPercentageArgument = $"DiscountPercentage = {decimal.Parse(DiscountPercentage)}, ";
                }

                string DiscountDollarAmountArgument = "";
                if (DiscountDollarAmount != "")
                {
                    DiscountDollarAmountArgument = $"DiscountDollarAmount = {decimal.Parse(DiscountDollarAmount)}, ";
                }

                string StartDateArgument = "";
                if (StartDate != "")
                {
                    StartDateArgument = $"StartDate = '{SqlDateTime.Parse(StartDate)}', ";
                }
                string sqlStatement2 = "UPDATE Discounts " +
                 $"SET DiscountCode = '{DiscountCode}', " +             //String
                 $"Description= '{Description}', " +                    //String
                 $"DiscountLevel = {int.Parse(DiscountLevel)}, " +      //int
                 InventoryIDArgument +                                  //int - Can Be NULL
                 $"DiscountType = {int.Parse(DiscountType)}, " +        //int
                 DiscountPercentageArgument +                           //decimal - Can be NULL
                 DiscountDollarAmountArgument +                         //decimal - Can be NULL
                 StartDateArgument +                                    //date - Can be NULL
                 $"ExpirationDate = '{SqlDateTime.Parse(ExpirationDate)}' " +//date
                 $" WHERE DiscountID = {int.Parse(DiscountID)};";        //int

                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                _sqlPagedAdventuresCommand.ExecuteNonQuery();

                CloseDisposeDatabasePagedAdventures();
                MessageBox.Show("Update Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                CloseDisposeDatabasePagedAdventures();
            }









        }

        internal static void AddItem(
            string Name,
            int selectedIndexCategory,
            string Price,
            string Cost,
            string RestockThreshold,
            string Quantity,
            string Description)
        {
            try
            {
                OpenDatabasePagedAdventures();
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




                    string sqlString = "INSERT INTO Inventory " +
           "(ItemName, CategoryID, RetailPrice, " +
           "Cost, RestockThreshold, Quantity, ItemDescription,ItemImage) " +
           $"VALUES ('{Name}', {selectedIndexCategory}, " +
           $"{decimal.Parse(Price)}, " +
           $"{decimal.Parse(Cost)}, " +
           $"{int.Parse(RestockThreshold)}, " +
           $"{int.Parse(Quantity)}, " +
           $"'{Description}', " +
           $"(@Image));";
                    SqlCommand insertCmd = new SqlCommand(sqlString, _cntPagedAdventuresDatabase);
                    SqlParameter sqlParams = insertCmd.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
                    sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file

                    insertCmd.ExecuteNonQuery();
                    CloseDisposeDatabasePagedAdventures();
                    MessageBox.Show("Successfully added a new item.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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




        //Login to application
        internal static bool LoginToApplication(string UsernameVar, string PasswordVar)
        {
            OpenDatabasePagedAdventures();
            try
            {
                string sqlStatement2 = $"SELECT Password FROM Logon WHERE " +
             $"LogonName = '{UsernameVar}' AND " +
             $"Password = '{PasswordVar}'";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                string result = (string)_sqlPagedAdventuresCommand.ExecuteScalar();
                if (result == PasswordVar)
                {
                    CloseDisposeDatabasePagedAdventures();
                    return true;
                }

                CloseDisposeDatabasePagedAdventures();
                return false;
            }
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
                return false;
            }
        }

        internal static void LowInventoryWarning()
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement =
                    "SELECT ItemName, " +
                    "Quantity, " +
                    "RestockThreshold " +
                    "FROM Inventory;";
                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlStatement,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);


                //string tempString = _dtPagedAdventuresTable.Rows[0][0].ToString();
                CloseDisposeDatabasePagedAdventures();
                string warningString = "";
                //MessageBox.Show(tempDGV.Rows[0].Cells[0].Value.ToString());
                for (int x = 0; x < _dtPagedAdventuresTable.Rows.Count; x++)
                {
                    if (int.Parse(_dtPagedAdventuresTable.Rows[x][1].ToString()) <
                        int.Parse(_dtPagedAdventuresTable.Rows[x][2].ToString()))
                    {
                        warningString +=
                            "Title: " +
                            _dtPagedAdventuresTable.Rows[x][0].ToString() +
                            "\n" +
                            "Quantity: " +
                            _dtPagedAdventuresTable.Rows[x][1].ToString() +
                            "\n" +
                            "Restock Threshold: " +
                            _dtPagedAdventuresTable.Rows[x][2].ToString() +
                            "\n" +
                            "------------------------------------------------" +
                            "\n";
                    }

                }

                MessageBox.Show(
                    warningString,
                    "Low Quantity",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);


            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        internal static bool CheckIfManager(string UserName)
        {
            OpenDatabasePagedAdventures();
            try
            {
                string sqlStatement2 = $"SELECT PositionTitle " +
                "FROM Logon WHERE " +
                $"LogonName = '{UserName}';";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                string result = (string)_sqlPagedAdventuresCommand.ExecuteScalar();
                if (result == "Manager")
                {
                    CloseDisposeDatabasePagedAdventures();
                    return true;
                }

                CloseDisposeDatabasePagedAdventures();
                return false;
            }
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
                return false;
            }





        }


        //Get Discount Percentage
        //using Discount Code
        #region GetDiscountPercentage
        internal static double GetDiscountPercentage(string discountCodeVar)
        {
            try
            {
                OpenDatabasePagedAdventures();         //Open Connection

                string sqlStatementDiscountPercentage =//SQL Statement
                    "SELECT DiscountPercentage " +     //SQL Statement
                    "FROM Discounts " +                //SQL Statement
                    "WHERE DiscountCode = " +          //SQL Statement
                   $"'{discountCodeVar}';";            //SQL Statement

                _sqlPagedAdventuresCommand =           //establish command object
                    new SqlCommand(                    //establish command object
                        sqlStatementDiscountPercentage,//establish command object
                        _cntPagedAdventuresDatabase);  //establish command object

                double resultDiscountPercentage =      //Store result of query
                    double.Parse(                      //Store result of query
                        _sqlPagedAdventuresCommand.    //Store result of query
                        ExecuteScalar().ToString());   //Store result of query

                CloseDisposeDatabasePagedAdventures(); //Close Database Connection
                return resultDiscountPercentage;
            }
            catch (Exception)
            {
                CloseDisposeDatabasePagedAdventures();//Close Database Connection
                return 0.00;
            }
        }//END GetDiscountPercentage
        #endregion


        //Check if Discount Code is Expired
        internal static bool CheckIfDiscountCodeExpired(string discountCodeVar)
        {
            if (discountCodeVar != null)
            {
                try
                {
                    OpenDatabasePagedAdventures();
                    string sqlStatement1 = "SELECT ExpirationDate " +
                                $"FROM Discounts " +
                                $"WHERE DiscountCode = '{discountCodeVar}';";
                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement1, _cntPagedAdventuresDatabase);
                    DateTime result1 = DateTime.Parse(_sqlPagedAdventuresCommand.ExecuteScalar().ToString());
                    CloseDisposeDatabasePagedAdventures();
                    if (result1 > DateTime.Now)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    CloseDisposeDatabasePagedAdventures();
                    return false;
                }

            }




            return true;
        }


        //Check if Discount Code Has Started
        internal static bool CheckIfDiscountCodeHasStarted(string discountCodeVar)
        {

            if (discountCodeVar != null)
            {
                try
                {
                    OpenDatabasePagedAdventures();
                    string sqlStatement1 = "SELECT StartDate " +
                                $"FROM Discounts " +
                                $"WHERE DiscountCode = '{discountCodeVar}';";
                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement1, _cntPagedAdventuresDatabase);
                    DateTime result1 = DateTime.Parse(_sqlPagedAdventuresCommand.ExecuteScalar().ToString());
                    CloseDisposeDatabasePagedAdventures();



                    if (result1 < DateTime.Now)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    CloseDisposeDatabasePagedAdventures();
                    return false;
                }
            }



            return true;
        }


        //return new DataGridView
        //with correct items
        #region GetInventory
        internal static DataGridView GetInventory(
            DataGridView dgvCustomerView,
            int pageModifier,
            int cbxSelectedIndexVar,
            string searchStringVar)
        {
            try
            {
                string cbxFilterVar;
                string tbxSearchVar;
                int whereCounter = 0;
                string wherePlacer = "";
                string andPlacer = "";
                string andPlacer2ndArgument = "";
                if (cbxSelectedIndexVar >= 1)
                {
                    whereCounter += 1;
                    wherePlacer = "WHERE ";
                    cbxFilterVar = "CategoryID = " +
                        $"{cbxSelectedIndexVar}";
                    andPlacer2ndArgument = "CategoryID = " +
                        $"{cbxSelectedIndexVar} AND ";
                }
                else
                {
                    cbxFilterVar = "";
                }
                if (searchStringVar != "")
                {
                    whereCounter += 1;
                    wherePlacer = "WHERE ";
                    tbxSearchVar = "ItemName LIKE " +
                        $"'%{searchStringVar}%'";
                }
                else
                {
                    tbxSearchVar = "";
                }
                if (whereCounter >= 2)
                {
                    andPlacer = "AND ";
                }
                int totalEntriesInDatabase =
                    GetTotalNumberOfItems(
                        dgvCustomerView,
                        cbxSelectedIndexVar,
                        searchStringVar);
                OpenDatabasePagedAdventures();
                dgvCustomerView.Refresh();
                //statement for the command string
                string sqlStatement =
                    "SELECT ItemImage AS 'Image', " +
                    "ItemName AS 'Name', " +
                    "RetailPrice AS 'Price', " +
                    "Quantity AS 'Qty.', " +
                    $"{pageModifier + 1} - 1 + " +
                    "ROW_NUMBER() OVER(ORDER " +
                    "BY ItemName) AS '#', " +
                    "InventoryID " +
                "FROM " +
                "(SELECT ItemImage, " +
                "ItemName, " +
                "RetailPrice, " +
                "Quantity, " +
                "CategoryID, " +
                "ROW_NUMBER() OVER(ORDER " +
                "BY ItemName) AS 'ItemRank', " +
                "InventoryID " +
                "FROM Inventory " +
                wherePlacer +//Only add if 1 or more
                             //WHERE Statements Exist.

                cbxFilterVar +//Only add if a Category
                              //was selected from Combo Box.

                andPlacer +//Only add an AND if 2 or more
                           //WHERE Statements exist.

                tbxSearchVar +//Only add if text is in
                              //search textbox.

                ") AS ItemsWithRowNumber " +
                "WHERE " +
                andPlacer2ndArgument + // Add if cbxCategory is 1 or greater
                $"ItemRank BETWEEN {1 + pageModifier} " +
                $"AND {10 + pageModifier};";
                //establish command object
                _sqlPagedAdventuresCommand =
                    new SqlCommand(sqlStatement,
                    _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand =
                    _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(
                    _dtPagedAdventuresTable);
                dgvCustomerView.DataSource =
                    _dtPagedAdventuresTable;
                CloseDisposeDatabasePagedAdventures();
            }
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
                    MessageBox.Show(
                        errorMessages.ToString(),
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(
                        ex.Message,
                        "Error on DatabaseCommand",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
            }
            return dgvCustomerView;
        }//END GetInventory

        internal static Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private static readonly ImageConverter _imageConverter = new ImageConverter();

        internal static void UpdateInventoryManager(
            string Name,
            int CategoryID,
            string Price,
            string Cost,
            string RestockThreshold,
            string Quantity,
            string Discontinued,
            string InventoryID,
            string Description)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement2 = "UPDATE Inventory " +
                 $"SET ItemName = '{Name}', " +
                 $"CategoryID= {CategoryID}, " +
                 $"RetailPrice = {decimal.Parse(Price.Substring(1))}, " +
                 $"Cost = {decimal.Parse(Cost.Substring(1))}, " +
                 $"RestockThreshold = {int.Parse(RestockThreshold)}, " +
                 $"Quantity = {int.Parse(Quantity)}, " +
                 $"Discontinued = '{bool.Parse(Discontinued)}', " +
                 $"ItemDescription = '{Description}' " +
                 $"WHERE InventoryID = {int.Parse(InventoryID)};";

                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                _sqlPagedAdventuresCommand.ExecuteNonQuery();

                CloseDisposeDatabasePagedAdventures();
                MessageBox.Show("Update Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                CloseDisposeDatabasePagedAdventures();
            }



        }

        public static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                // Correct a strange glitch that has been observed in the test program when converting 
                //  from a PNG file image created by CopyImageToByteArray() - the dpi value "drifts" 
                //  slightly away from the nominal integer value
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }

        internal static Image ConvertByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        internal static void AddImageToDatabase(byte[] image, int Inventory)
        {
            try
            {
                OpenDatabasePagedAdventures();
                //TODO: Change(Image) to the name of your image column[e.g(ProductImages)]
                string insertQuery = "UPDATE Inventory " +
                    "SET ItemImage=(@Image) " +// @Image is a parameter we will fill in later
                    $"WHERE InventoryID = {Inventory}";
                SqlCommand insertCmd = new SqlCommand(insertQuery, _cntPagedAdventuresDatabase);
                SqlParameter sqlParams = insertCmd.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
                sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file
                insertCmd.ExecuteNonQuery();
                _cntPagedAdventuresDatabase.Close();
                MessageBox.Show("File was successfully added to the database.", "File Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CloseDisposeDatabasePagedAdventures();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error During Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDisposeDatabasePagedAdventures();
            }
        }

        //internal static Image GetImage(int InventoryIDVar)
        //{
        //    try
        //    {
        //        OpenDatabasePagedAdventures();
        //        string sqlStatement1 = "SELECT ItemImage " +
        //                    $"FROM Inventory " +
        //                    $"WHERE InventoryID = {InventoryIDVar};";
        //        //establish command object
        //        _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement1, _cntPagedAdventuresDatabase);
        //        //var utf8 = new UTF8Encoding();
        //        //byte[] pass = utf8.GetBytes(_sqlPagedAdventuresCommand.ExecuteScalar().ToString());
        //        //Image result1 = Image.FromStream(new MemoryStream(pass));
        //        string tempPicture = _sqlPagedAdventuresCommand.ExecuteScalar().ToString();
        //        System.IO.StreamWriter sw = new StreamWriter(tempPicture);
        //        //Image result1 = ConvertByteArrayToImage(tempPicture);
        //        CloseDisposeDatabasePagedAdventures();

        //        return result1;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        CloseDisposeDatabasePagedAdventures();
        //        return null;
        //    }
        //}
        #endregion

        #region InventoryManager
        internal static DataGridView GetInventory(
DataGridView dgvCustomerView,
int pageModifier,
int cbxSelectedIndexVar,
string searchStringVar, bool isManager)
        {
            if (isManager)
            {
                try
                {
                    //dgvCustomerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    string cbxFilterVar;
                    string tbxSearchVar;
                    int whereCounter = 0;
                    string wherePlacer = "";
                    string andPlacer = "";
                    string andPlacer2ndArgument = "";
                    if (cbxSelectedIndexVar >= 1)
                    {
                        whereCounter += 1;
                        wherePlacer = "WHERE ";
                        cbxFilterVar = "CategoryID = " +
                            $"{cbxSelectedIndexVar}";
                        andPlacer2ndArgument = "CategoryID = " +
                            $"{cbxSelectedIndexVar} AND ";
                    }
                    else
                    {
                        cbxFilterVar = "";
                    }
                    if (searchStringVar != "")
                    {
                        whereCounter += 1;
                        wherePlacer = "WHERE ";
                        tbxSearchVar = "ItemName LIKE " +
                            $"'%{searchStringVar}%'";
                    }
                    else
                    {
                        tbxSearchVar = "";
                    }
                    if (whereCounter >= 2)
                    {
                        andPlacer = "AND ";
                    }
                    int totalEntriesInDatabase =
                        GetTotalNumberOfItems(
                            dgvCustomerView,
                            cbxSelectedIndexVar,
                            searchStringVar);
                    OpenDatabasePagedAdventures();
                    dgvCustomerView.Refresh();
                    //statement for the command string
                    string sqlStatement =
                        "SELECT " +
                        "ItemName AS 'Name', " +
                        "CategoryID AS 'Categ- ory ID', " +
                        "RetailPrice AS 'Price', " +
                        "Cost, " +
                        "RestockThreshold AS 'Restock Threshold', " +
                        "Quantity AS 'Qty.', " +
                        "Discontinued AS 'Discon- tinued', " +
                        $"{pageModifier + 1} - 1 + " +
                        "ROW_NUMBER() OVER(ORDER " +
                        "BY ItemName) AS '#', " +
                        "InventoryID AS 'Invent- ory ID', " +
                        "ItemImage AS 'Item Image'" +
                    "FROM " +
                    "(SELECT " +
                        "ItemName, " +
                        "CategoryID, " +
                        "RetailPrice, " +
                        "Cost, " +
                        "RestockThreshold, " +
                        "Quantity, " +
                        "Discontinued, " +
                    "ROW_NUMBER() OVER(ORDER " +
                    "BY ItemName) AS 'ItemRank', " +
                    "InventoryID, " +
                    "ItemImage " +
                    "FROM Inventory " +
                    wherePlacer +//Only add if 1 or more
                                 //WHERE Statements Exist.

                    cbxFilterVar +//Only add if a Category
                                  //was selected from Combo Box.

                    andPlacer +//Only add an AND if 2 or more
                               //WHERE Statements exist.

                    tbxSearchVar +//Only add if text is in
                                  //search textbox.

                    ") AS ItemsWithRowNumber " +
                    "WHERE " +
                    andPlacer2ndArgument + // Add if cbxCategory is 1 or greater
                    $"ItemRank BETWEEN {1 + pageModifier} " +
                    $"AND {10 + pageModifier};";
                    //establish command object
                    _sqlPagedAdventuresCommand =
                        new SqlCommand(sqlStatement,
                        _cntPagedAdventuresDatabase);
                    //Reset Data Adapter
                    _daPagedAdventures.Dispose();
                    _daPagedAdventures = new SqlDataAdapter();
                    //establish data adapter
                    _daPagedAdventures.SelectCommand =
                        _sqlPagedAdventuresCommand;
                    //Reset Data Table
                    _dtPagedAdventuresTable.Dispose();
                    _dtPagedAdventuresTable = new DataTable();
                    _dtPagedAdventuresTable.Clear();
                    //fill data table
                    _daPagedAdventures.Fill(
                        _dtPagedAdventuresTable);
                    dgvCustomerView.DataSource =
                        _dtPagedAdventuresTable;
                    CloseDisposeDatabasePagedAdventures();
                }
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
                        MessageBox.Show(
                            errorMessages.ToString(),
                            "Error on DatabaseCommand",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        CloseDisposeDatabasePagedAdventures();
                    }
                    else
                    {//handles generic ones here
                        MessageBox.Show(
                            ex.Message,
                            "Error on DatabaseCommand",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        CloseDisposeDatabasePagedAdventures();
                    }
                }
            }
            return dgvCustomerView;
        }//END GetInventory
        #endregion
        internal static void DeleteItem(int inventoryID)
        {

            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement2 = $"DELETE Inventory " +
                $"WHERE InventoryID = {inventoryID}";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                _sqlPagedAdventuresCommand.ExecuteNonQuery();

                CloseDisposeDatabasePagedAdventures();
            }
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
                CloseDisposeDatabasePagedAdventures();
            }
        }


        internal static void SearchByTitle(string searchStringVar, DataGridView dgvCustomerView,
                        int currentModifierResultsLimiter, int categorySelectedIndexVar)
        {
            clsSQL.GetInventory(dgvCustomerView,
                        currentModifierResultsLimiter, categorySelectedIndexVar, searchStringVar, true);
        }



        internal static string GetDescription(int itemID)
        {
            OpenDatabasePagedAdventures();
            try
            {
                string sqlStatement2 = $"SELECT ItemDescription FROM Inventory WHERE " +
             $"InventoryID = {itemID}";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                string result = (string)_sqlPagedAdventuresCommand.ExecuteScalar();

                CloseDisposeDatabasePagedAdventures();
                return result;
            }
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
                return "";
            }
        }



        //get categories for combo box
        internal static ComboBox GetCategories(ComboBox cbxCategories)
        {


            try
            {

                OpenDatabasePagedAdventures();
                //dgvCustomerView.Refresh();
                //statement for the command string
                string sqlStatement = "SELECT CategoryName " +
                "FROM Categories";



                /*
                 
                 string Sql = "select company_name from JO.dbo.Comp";
                 SqlConnection conn = new SqlConnection(connString);
                 conn.Open();
                 SqlCommand cmd = new SqlCommand(Sql, conn);
                 SqlDataReader DR = cmd.ExecuteReader();

                 while (DR.Read())
                 {
                    combobox1.Items.Add(DR[0]);

                 }
                 
                 */




                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement, _cntPagedAdventuresDatabase);
                //int result = (int)_sqlPagedAdventuresCommand.ExecuteScalar();




                SqlDataReader DR = _sqlPagedAdventuresCommand.ExecuteReader();
                cbxCategories.Items.Add("-");
                while (DR.Read())
                {
                    cbxCategories.Items.Add(DR[0]);

                }

                CloseDisposeDatabasePagedAdventures();
                return cbxCategories;
            }
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
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
            }


            return cbxCategories;
        }



        internal static int GetInventoryID(string itemNameVar)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement1 = "SELECT InventoryID " +
                            $"FROM Inventory " +
                            $"WHERE ItemName LIKE '{itemNameVar}';";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement1, _cntPagedAdventuresDatabase);
                int result1 = (int)_sqlPagedAdventuresCommand.ExecuteScalar();
                CloseDisposeDatabasePagedAdventures();


                return result1;
            }
            catch (Exception)
            {
                MessageBox.Show("Network Connection Error, Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return -1;
            }
        }



        internal static void UpdateInventory(ListView shoppingCartListVar,
            string DiscountCodeVar, int orderIDVar2
            )
        {

            try
            {
                if (shoppingCartListVar.Items.Count > 0)
                {
                    for (int i = 0; i < shoppingCartListVar.Items.Count; i++)
                    {
                        int inventoryIDVar = FindInventoryID(shoppingCartListVar.Items[i].SubItems[0].Text);
                        //Find Quantity of given Item.
                        int oldQuantityVar = GetQuantityOnHand(inventoryIDVar);
                        int newInventoryQuantity = (oldQuantityVar - int.Parse(shoppingCartListVar.Items[i].SubItems[1].Text));
                        OpenDatabasePagedAdventures();
                        //Update Inventory after user buys items.
                        string sqlQueryVar =
                        "UPDATE Inventory " +
                        $"SET Quantity = {newInventoryQuantity} " +
                        $"WHERE InventoryID = {inventoryIDVar};";//establish command object
                        _sqlPagedAdventuresCommand = new SqlCommand(sqlQueryVar, _cntPagedAdventuresDatabase);
                        OpenDatabasePagedAdventures();
                        _sqlPagedAdventuresCommand.BeginExecuteNonQuery();
                        CloseDisposeDatabasePagedAdventures();



                        CreateOrderDetails(orderIDVar2, inventoryIDVar, int.Parse(shoppingCartListVar.Items[i].SubItems[1].Text), DiscountCodeVar);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Updating Store Inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        internal static int GetQuantityOnHand(int InventoryIDVar)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string queryString =
                "SELECT Quantity " +
                "FROM Inventory " +
                $"WHERE InventoryID = {InventoryIDVar};";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(queryString, _cntPagedAdventuresDatabase);
                int quantityVar = (int)_sqlPagedAdventuresCommand.ExecuteScalar();
                CloseDisposeDatabasePagedAdventures();
                return quantityVar;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Inventory ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDisposeDatabasePagedAdventures();
                return 0;
            }
        }



        private static int FindInventoryID(string strItem)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string queryString =
                "SELECT InventoryID " +
                "FROM Inventory " +
                $"WHERE ItemName = @bookTitleParameter;";//Replace'{strItem}' with @bookTitleParameter


                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(queryString, _cntPagedAdventuresDatabase);
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@bookTitleParameter", strItem);
                _sqlPagedAdventuresCommand.Parameters.Add(param[0]);
                int resultItemID = (int)_sqlPagedAdventuresCommand.ExecuteScalar();
                CloseDisposeDatabasePagedAdventures();

                return resultItemID;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseDisposeDatabasePagedAdventures();
                return -1;
            }
        }



        internal static void CreateOrderDetails(int OrderIDVar, int InventoryIDVar, int QuantityOrdered, string DiscountCodeVar)
        {
            try
            {
                int DiscountID = GetDiscountID(DiscountCodeVar);


                if (DiscountID != 0)
                {
                    OpenDatabasePagedAdventures();
                    string sqlStringVar2 = "INSERT INTO OrderDetails(OrderID,InventoryID, DiscountID, Quantity) " +
                        $"VALUES({OrderIDVar}, {InventoryIDVar}, {DiscountID}, {QuantityOrdered});";

                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStringVar2, _cntPagedAdventuresDatabase);
                    _sqlPagedAdventuresCommand.ExecuteNonQuery();
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {
                    OpenDatabasePagedAdventures();
                    string sqlStringVar2 = "INSERT INTO OrderDetails(OrderID,InventoryID, Quantity) " +
                        $"VALUES({OrderIDVar}, {InventoryIDVar}, {QuantityOrdered});";

                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStringVar2, _cntPagedAdventuresDatabase);
                    _sqlPagedAdventuresCommand.ExecuteNonQuery();
                    CloseDisposeDatabasePagedAdventures();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Network Connection Error, Please try again.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }



        internal static int CreateOrder(string CC_NumberVar, string ExpDateVar, string CCVVar, string DiscountCodeVar, int PersonIDVar)
        {



            try
            {
                int DiscountID = GetDiscountID(DiscountCodeVar);
                if (DiscountID != 0)
                {

                    OpenDatabasePagedAdventures();
                    string sqlStringVar = "INSERT INTO Orders " +
                    "(CC_Number, ExpDate, CCV, DiscountID, OrderDate, PersonID) " +
                    $"VALUES('{CC_NumberVar}', '{ExpDateVar}', '{CCVVar}', {DiscountID}, GETDATE(), {PersonIDVar});";
                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStringVar, _cntPagedAdventuresDatabase);
                    _sqlPagedAdventuresCommand.ExecuteNonQuery();
                    CloseDisposeDatabasePagedAdventures();



                    OpenDatabasePagedAdventures();
                    string sqlStatement4 = "SELECT MAX(OrderID) " +
                                         $"FROM Orders WHERE " +
                                         $"PersonID = {PersonIDVar};";
                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement4, _cntPagedAdventuresDatabase);
                    int result2 = (int)_sqlPagedAdventuresCommand.ExecuteScalar();
                    CloseDisposeDatabasePagedAdventures();



                    OpenDatabasePagedAdventures();
                    string sqlStatement3 = "SELECT OrderID " +
                         $"FROM Orders WHERE " +
                         $"PersonID = {PersonIDVar} " +
                         $"AND OrderID = {result2};";
                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement3, _cntPagedAdventuresDatabase);
                    int result4 = (int)_sqlPagedAdventuresCommand.ExecuteScalar();
                    CloseDisposeDatabasePagedAdventures();
                    return result4;
                }
                else
                {

                    OpenDatabasePagedAdventures();
                    string sqlStringVar = "INSERT INTO Orders " +
                    "(CC_Number, ExpDate, CCV, OrderDate, PersonID) " +
                    $"VALUES('{CC_NumberVar}', '{ExpDateVar}', '{CCVVar}', GETDATE(), {PersonIDVar});";
                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStringVar, _cntPagedAdventuresDatabase);
                    _sqlPagedAdventuresCommand.ExecuteNonQuery();
                    CloseDisposeDatabasePagedAdventures();




                    OpenDatabasePagedAdventures();
                    string sqlStatement4 = "SELECT MAX(OrderID) " +
                         $"FROM Orders WHERE " +
                         $"PersonID = {PersonIDVar};";
                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement4, _cntPagedAdventuresDatabase);
                    int result2 = (int)_sqlPagedAdventuresCommand.ExecuteScalar();
                    CloseDisposeDatabasePagedAdventures();





                    OpenDatabasePagedAdventures();
                    string sqlStatement3 = "SELECT OrderID " +
                         $"FROM Orders WHERE " +
                         $"PersonID = {PersonIDVar} " +
                         $"AND OrderID = {result2};";
                    //establish command object
                    _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement3, _cntPagedAdventuresDatabase);
                    int result4 = (int)_sqlPagedAdventuresCommand.ExecuteScalar();
                    CloseDisposeDatabasePagedAdventures();
                    return result4;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Network Connection Error, Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return -1;
            }





        }



        private static int GetDiscountID(string discountCodeVar)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlIntVar = "SELECT DiscountID " +
                    $"FROM Discounts " +
                    $"WHERE DiscountCode = '{discountCodeVar}'";

                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlIntVar, _cntPagedAdventuresDatabase);
                int discountIDVar = (int)_sqlPagedAdventuresCommand.ExecuteScalar();
                CloseDisposeDatabasePagedAdventures();
                return discountIDVar;
            }
            catch (Exception)
            { return 0; }
        }



        internal static ListView UpdateCart(int inventoryID, int quantityAdded, int PersonID, ListView lstShoppingCartVar, int quantityOnHandVar)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement1 = "SELECT ItemName " +
                    $"FROM Inventory WHERE " +
                    $"InventoryID = {inventoryID};";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement1, _cntPagedAdventuresDatabase);
                String resultItemName = (String)_sqlPagedAdventuresCommand.ExecuteScalar();
                CloseDisposeDatabasePagedAdventures();

                if (quantityAdded == 1)
                {

                    if (lstShoppingCartVar.Items.Count == 0)
                    {
                        ListViewItem item4;
                        item4 = lstShoppingCartVar.Items.Add(resultItemName);
                        item4.SubItems.Add("1");
                        item4.SubItems.Add(GetItemValue(inventoryID).ToString("C"));
                        item4.SubItems.Add(((GetItemValue(inventoryID) * 1)).ToString("C"));
                        return lstShoppingCartVar;
                    }


                    for (int x = 0; x < lstShoppingCartVar.Items.Count; x++)
                    {
                        if (lstShoppingCartVar.Items[x].SubItems[0].Text == resultItemName)
                        {
                            if (int.Parse(lstShoppingCartVar.Items[x].SubItems[1].Text) < quantityOnHandVar)
                            {
                                lstShoppingCartVar.Items[x].SubItems[1].Text = (int.Parse(lstShoppingCartVar.Items[x].SubItems[1].Text) + 1).ToString();
                                lstShoppingCartVar.Items[x].SubItems[2].Text = (GetItemValue(inventoryID).ToString("C"));
                                lstShoppingCartVar.Items[x].SubItems[3].Text = (((GetItemValue(inventoryID) * (int.Parse(lstShoppingCartVar.Items[x].SubItems[1].Text))).ToString("C")));
                            }
                            //Add price and total
                            return lstShoppingCartVar;
                        }

                    }



                    ListViewItem item3;
                    item3 = lstShoppingCartVar.Items.Add(resultItemName);
                    item3.SubItems.Add("1");
                    item3.SubItems.Add((GetItemValue(inventoryID).ToString("C")));
                    item3.SubItems.Add(((GetItemValue(inventoryID) * 1)).ToString("C"));


                    return lstShoppingCartVar;
                }


                if (quantityAdded == -1)
                {
                    for (int x = 0; x < (lstShoppingCartVar.Items.Count); x++)
                    {
                        if (lstShoppingCartVar.Items[x].SubItems[0].Text == resultItemName)
                        {
                            lstShoppingCartVar.Items[x].SubItems[1].Text = (int.Parse(lstShoppingCartVar.Items[x].SubItems[1].Text) - 1).ToString();
                            lstShoppingCartVar.Items[x].SubItems[3].Text = (((GetItemValue(inventoryID) * (int.Parse(lstShoppingCartVar.Items[x].SubItems[1].Text))).ToString("C")));
                        }
                    }


                    for (int x = (lstShoppingCartVar.Items.Count - 1); x >= 0; x--)
                    {
                        if (lstShoppingCartVar.Items[x].SubItems[1].Text == "0")
                        {
                            lstShoppingCartVar.Items[x].Remove();

                        }
                    }

                    return lstShoppingCartVar;
                }
                return lstShoppingCartVar;
            }
            catch (Exception)
            {
                return lstShoppingCartVar;
            }
        }



        private static decimal GetItemValue(int inventoryID)
        {
            OpenDatabasePagedAdventures();
            try
            {

                string sqlStatement2 = $"SELECT " +
                    $"RetailPrice FROM " +
                    $"Inventory " +
                    $"WHERE InventoryID = {inventoryID};";

                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                decimal result = (decimal)_sqlPagedAdventuresCommand.ExecuteScalar();

                CloseDisposeDatabasePagedAdventures();

                return result;
            }
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
                CloseDisposeDatabasePagedAdventures();
                return 1.00M;
            }
        }



        //Get total number of items in given query.
        internal static int GetTotalNumberOfItems(DataGridView dgvCustomerView, int cbxCategoriesVar, string tbxSearchByTitleVar)
        {
            try
            {
                string cbxFilterVar;
                string tbxSearchVar;
                int whereCounter = 0;
                string wherePlacer = "";
                string andPlacer = "";
                if (cbxCategoriesVar >= 1)
                {
                    whereCounter += 1;
                    wherePlacer = " WHERE ";
                    cbxFilterVar = $"CategoryID = {cbxCategoriesVar}";
                }
                else
                {
                    cbxFilterVar = "";
                }
                if (tbxSearchByTitleVar != "")
                {
                    whereCounter += 1;
                    wherePlacer = " WHERE ";
                    tbxSearchVar = $"ItemName LIKE '%{tbxSearchByTitleVar}%'";
                }
                else
                {
                    tbxSearchVar = "";
                }
                if (whereCounter >= 2)
                {
                    andPlacer = "AND ";
                }
                OpenDatabasePagedAdventures();
                dgvCustomerView.Refresh();
                //statement for the command string
                string sqlStatement = "SELECT COUNT(*) " +
                "FROM Inventory" +
                wherePlacer +
                tbxSearchVar +
                andPlacer +
                cbxFilterVar;
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement, _cntPagedAdventuresDatabase);
                int result = (int)_sqlPagedAdventuresCommand.ExecuteScalar();

                CloseDisposeDatabasePagedAdventures();
                return result;
            }
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
                    CloseDisposeDatabasePagedAdventures();
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseDisposeDatabasePagedAdventures();
                }
            }
            return 0;
        }



        //Update user password in database
        public static void UpdatePassword(string newPassword, string username)
        {
            OpenDatabasePagedAdventures();
            try
            {
                //statement for the command string
                string sqlStatement = $"UPDATE Logon " +
                    $"SET Password = '{newPassword}' " +
                    $"WHERE LogonName = '{username}'";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement, _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand = _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(_dtPagedAdventuresTable);
            }
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
            CloseDisposeDatabasePagedAdventures();
        }



        //Get security answers
        public static bool GetSecurityAnswers(string challengeAnswerVar, string LogonNameVar, string userAnswer)
        {
            OpenDatabasePagedAdventures();
            try
            {

                string sqlStatement2 = $"SELECT " +
                    $"{challengeAnswerVar} FROM " +
                    $"Logon " +
                    $"WHERE LogonName = '{LogonNameVar}'";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                string result = (string)_sqlPagedAdventuresCommand.ExecuteScalar();
                if (result == userAnswer)
                {
                    CloseDisposeDatabasePagedAdventures();
                    return true;
                }
                CloseDisposeDatabasePagedAdventures();
                return false;
            }
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
                CloseDisposeDatabasePagedAdventures();
                return false;
            }
        }



        //Get Security Questions
        public static string GetSecurityQuestions(string questionTitle, string LogonNameVar)
        {
            OpenDatabasePagedAdventures();
            try
            {

                string sqlStatement2 = $"SELECT " +
                    $"SecurityQuestions.QuestionPrompt FROM " +
                    $"SecurityQuestions INNER JOIN " +
                    $"Logon ON Logon.{questionTitle}=SecurityQuestions.QuestionID " +
                    $"WHERE Logon.LogonName = '{LogonNameVar}' AND " +
                    $"Logon.{questionTitle}=SecurityQuestions.QuestionID";

                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                string result = (string)_sqlPagedAdventuresCommand.ExecuteScalar();

                CloseDisposeDatabasePagedAdventures();
                return result;
            }
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
                CloseDisposeDatabasePagedAdventures();
                return "";
            }
        }



        //Add new user to the database
        #region AddNewUser
        public static void AddNewUser(String Username, String Password, String Email,
                    String ZipCode, String PrimaryPhone, String SecondaryPhone,
                    String Title, String FirstName, String MiddleName,
                    String LastName, String Suffix, String City,
                    String State, String Address1,
                    String Address2, String Address3, int FirstChallengeQuestion,
                    String FirstChallengeAnswer, int SecondChallengeQuestion,
                    String SecondChallengeAnswer, int ThirdChallengeQuestion,
                    String ThirdChallengeAnswer)
        {
            OpenDatabasePagedAdventures();
            if (DatabaseCommandPagedAdventuresCheckExistingUsername(Username))
            {
                DatabaseCommandPagedAdventuresAddToPersonTable(Email,
                        ZipCode, PrimaryPhone, SecondaryPhone,
                        Title, FirstName, MiddleName,
                        LastName, Suffix, City,
                        State, Address1,
                        Address2, Address3);
                int result = FindPersonID(
                        ZipCode,
                        FirstName,
                        LastName, City,
                        State, Address1);

                DatabaseCommandPagedAdventuresAddToLogonTable(
                    Username, Password,
                    FirstChallengeQuestion,
                    FirstChallengeAnswer, SecondChallengeQuestion,
                    SecondChallengeAnswer, ThirdChallengeQuestion,
                    ThirdChallengeAnswer, result);
            }
            else
            {
                MessageBox.Show(
                    "Username already exists.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            CloseDisposeDatabasePagedAdventures();
        }//END AddNewUser
        #endregion


        //Get position of user(Customer, Employee, Manager)
        public static string fetchPosition(string userName)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement2 = $"SELECT PositionTitle FROM Logon WHERE " +
             $"LogonName = '{userName}'";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                string result = (string)_sqlPagedAdventuresCommand.ExecuteScalar();
                CloseDisposeDatabasePagedAdventures();
                return result;
            }
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
                CloseDisposeDatabasePagedAdventures();
                return "";
            }
        }



        //Close Database Connection
        private static void CloseDisposeDatabasePagedAdventures()
        {
            //method to close database and dispose of the connection object
            try
            {
                //close connection
                _cntPagedAdventuresDatabase.Close();
                //dispose of the sql objects
                _cntPagedAdventuresDatabase.Dispose();
                _daPagedAdventures.Dispose();
                _dtPagedAdventuresTable.Dispose();
            }
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
                    MessageBox.Show(errorMessages.ToString(), "Error on Close", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on Close", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //Open Database Connection
        private static void OpenDatabasePagedAdventures()
        {
            //method to open database
            try
            {
                if (_cntPagedAdventuresDatabase != null)
                    _cntPagedAdventuresDatabase = new SqlConnection(CONNECT_STRING);
                if (DBConnectionStatus())
                {
                    //open the connection to MovieStore database
                    _cntPagedAdventuresDatabase.Open();
                }
            }
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
                    MessageBox.Show(errorMessages.ToString(), "Error on Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message, "Error on Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //Check if username exists
        public static bool DatabaseCommandPagedAdventuresCheckExistingUsername(String Username)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement2 = $"SELECT LogonName FROM Logon WHERE " +
             $"LogonName = '{Username}'";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                string result = (string)_sqlPagedAdventuresCommand.ExecuteScalar();
                if (result != Username)
                    return true;

                CloseDisposeDatabasePagedAdventures();
                return false;
            }
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
                CloseDisposeDatabasePagedAdventures();
                return false;
            }
        }



        //Add user to person table
        public static void DatabaseCommandPagedAdventuresAddToPersonTable(String Email,
                    String ZipCode, String PrimaryPhone, String SecondaryPhone,
                    String Title, String FirstName, String MiddleName,
                    String LastName, String Suffix, String City,
                    String State, String Address1,
                    String Address2, String Address3)
        {
            try
            {
                if (Title == "")
                    Title = "NULL";
                else
                    Title = "'" + Title + "'";

                if (MiddleName == "")
                    MiddleName = "NULL";
                else
                    MiddleName = "'" + MiddleName + "'";

                if (Suffix == "")
                    Suffix = "NULL";
                else
                    Suffix = "'" + Suffix + "'";

                if (Address2 == "")
                    Address2 = "NULL";
                else
                    Address2 = "'" + Address2 + "'";

                if (Address3 == "")
                    Address3 = "NULL";
                else
                    Address3 = "'" + Address3 + "'";

                if (Email == "")
                    Email = "NULL";
                else
                    Email = "'" + Email + "'";

                if (PrimaryPhone == "")
                    PrimaryPhone = "NULL";
                else
                    PrimaryPhone = "'" + PrimaryPhone + "'";

                if (SecondaryPhone == "")
                    SecondaryPhone = "NULL";
                else
                    SecondaryPhone = "'" + SecondaryPhone + "'";

                //statement for the command string
                string sqlStatement = $"INSERT INTO Person (Title,NameFirst,NameMiddle,NameLast,Suffix,Address1,Address2,Address3,City,Zipcode,State,Email,PhonePrimary,PhoneSecondary,PositionID) " +
                $"VALUES({Title}, '{FirstName}', {MiddleName}, '{LastName}', {Suffix}, '{Address1}', {Address2}, {Address3}, '{City}', '{ZipCode}', '{State}', {Email}, {PrimaryPhone}, {SecondaryPhone}, 1000)";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement, _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand = _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(_dtPagedAdventuresTable);
            }
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


        //Get PersonID using UserName
        public static int FindPersonID(string UserName)
        {
            try
            {
                OpenDatabasePagedAdventures();
                string sqlStatement2 = $"SELECT PersonID FROM Logon WHERE " +
                 $"LogonName = '{UserName}';";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                int result = (int)_sqlPagedAdventuresCommand.ExecuteScalar();

                CloseDisposeDatabasePagedAdventures();
                return result;
            }
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
                CloseDisposeDatabasePagedAdventures();
                return -1;
            }
        }



        //Find personID in database
        public static int FindPersonID(
                    String ZipCode,
                    String FirstName,
                    String LastName, String City,
                    String State, String Address1)
        {
            try
            {
                string sqlStatement2 = $"SELECT PersonID FROM Person WHERE " +
             $"NameFirst = '{FirstName}' AND " +
                    $"NameLast = '{LastName}' AND " +
                    $"Address1 = '{Address1}' AND " +
                    $"City = '{City}' AND " +
                    $"Zipcode = '{ZipCode}' AND " +
                    $"State = '{State}' AND " +
                    $"PositionID = 1000";
                //establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement2, _cntPagedAdventuresDatabase);
                int result = (int)_sqlPagedAdventuresCommand.ExecuteScalar();

                return result;
            }
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
                return 0;
            }
        }



        //Add user to logon table
        public static void DatabaseCommandPagedAdventuresAddToLogonTable(
                    String Username, String Password,
                    int FirstChallengeQuestion,
                    String FirstChallengeAnswer, int SecondChallengeQuestion,
                    String SecondChallengeAnswer, int ThirdChallengeQuestion,
                    String ThirdChallengeAnswer, int result)
        {
            try
            {
                if (FirstChallengeQuestion == 0)
                    FirstChallengeQuestion = 100;
                else if (FirstChallengeQuestion == 1)
                    FirstChallengeQuestion = 101;
                else if (FirstChallengeQuestion == 2)
                    FirstChallengeQuestion = 102;
                if (SecondChallengeQuestion == 0)
                    SecondChallengeQuestion = 103;
                else if (SecondChallengeQuestion == 1)
                    SecondChallengeQuestion = 104;
                else if (SecondChallengeQuestion == 2)
                    SecondChallengeQuestion = 105;
                if (ThirdChallengeQuestion == 0)
                    ThirdChallengeQuestion = 106;
                else if (ThirdChallengeQuestion == 1)
                    ThirdChallengeQuestion = 107;
                else if (ThirdChallengeQuestion == 2)
                    ThirdChallengeQuestion = 108;
                string sqlStatement3 = $"INSERT INTO Logon (PersonID, LogonName, Password,FirstChallengeQuestion,FirstChallengeAnswer,SecondChallengeQuestion,SecondChallengeAnswer,ThirdChallengeQuestion,ThirdChallengeAnswer,PositionTitle) " +
                $"VALUES({result}, '{Username}', '{Password}',{FirstChallengeQuestion},'{FirstChallengeAnswer}',{SecondChallengeQuestion},'{SecondChallengeAnswer}',{ThirdChallengeQuestion},'{ThirdChallengeAnswer}','Customer')";
                ////establish command object
                _sqlPagedAdventuresCommand = new SqlCommand(sqlStatement3, _cntPagedAdventuresDatabase);
                //Reset Data Adapter
                _daPagedAdventures.Dispose();
                _daPagedAdventures = new SqlDataAdapter();
                //establish data adapter
                _daPagedAdventures.SelectCommand = _sqlPagedAdventuresCommand;
                //Reset Data Table
                _dtPagedAdventuresTable.Dispose();
                _dtPagedAdventuresTable = new DataTable();
                _dtPagedAdventuresTable.Clear();
                //fill data table
                _daPagedAdventures.Fill(_dtPagedAdventuresTable);
                MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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















