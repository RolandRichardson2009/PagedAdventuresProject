using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    internal class clsHTML
    {


        internal static StringBuilder GenerateInventoryReport(string title,
            ListView lstShoppingCartVar)
        {
            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();

            // CSS is a way to style the HTML page. Each HTML tag can be customized.
            // In this example, the H1 and TD tags are customized.
            // Refer to this website for examples: https://www.w3schools.com/Css/css_syntax.asp

            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-align:center; font-weight: bold; text-align: center;}");
            css.AppendLine("h1 {color: blue;}");
            css.AppendLine("</style>");

            // HTML is used to format the layout of a webpage. This will be the frame
            // we use to place our data in. CSS is used to style the page to look a
            // certain way.

            // The <HTML> and </HTML> tags are the start and end of a webpage.
            // The <HEAD> and </HEAD> tags gives information about the webpage
            // such as the title and if there is any CSS styles being used.
            // The text between the <TITLE> and </TITLE> tags are used by the
            // browser to display the name of the page.
            // <BODY> and </BODY> is where the data of the page is stored
            // <H1> and </H1> is the largest font size for headings. These
            // can be from H1 to H6. H6 is the smallest font. https://www.w3schools.com/tags/tag_hn.asp

            html.AppendLine("<html>");
            html.AppendLine($"<head>{css}<title>{title}</title></head>");
            html.AppendLine("<body>");

            html.AppendLine($"<h1>{title}</h1>");

            // Create table of data
            // <TABLE> and </TABLE> is the start and end of a table of rows and data.
            // <TR> and </TR> is one row of data. They contain <TD> and </TD> tags.
            // <TD> and </TD> represents the data inside of the table in a particular row.
            // https://www.w3schools.com/tags/tag_table.asp

            // I used an <HR /> tag which is a "horizontal rule" as table data.
            // You can "span" it across multiple columns of data.
            html.AppendLine("<table>");
            /*
             "InventoryID AS 'ItemID', " +
                "ItemName AS '', " +
                "RetailPrice AS '', " +
                ", " +
                "Quantity AS '', " +
                "RestockThreshold AS '', " +
                "Discontinued AS '' " +
             */
            html.AppendLine("<tr><td>ItemID</td><td>Name</td><td>Price</td><td>Cost</td><td>Quantity On Hand</td><td>Restock Threshold</td><td>Availability</td></tr>");
            html.AppendLine("<tr><td colspan=8><hr /></td></tr>");
            //decimal totalPriceVar = 0.00M;
            //This section is for the individual items
            foreach (ListViewItem item in lstShoppingCartVar.Items)
            {
                html.Append("<tr>");
                html.Append($"<td>{item.SubItems[0].Text}</td>");
                html.Append($"<td>{item.SubItems[1].Text}</td>");
                html.Append($"<td>${item.SubItems[2].Text}</td>");
                html.Append($"<td>${item.SubItems[3].Text}</td>");
                html.Append($"<td>x{item.SubItems[4].Text}</td>");
                html.Append($"<td>x{item.SubItems[5].Text}</td>");




                if (item.SubItems[6].Text != "True")
                {
                    html.Append($"<td>{"Available"}</td>");
                }
                else 
                {
                    html.Append($"<td>{"Not Available"}</td>");
                }
                






                //totalPriceVar += (decimal.Parse(item.SubItems[3].Text.ToString()));
                html.Append("</tr>");
                html.AppendLine("<tr><td colspan=8><hr /></td></tr>");
            }
            ////This section is for the subtotal
            //html.Append("<tr>");
            //html.Append($"<td></td>");
            //html.Append($"<td></td>");
            //html.Append($"<td>Subtotal:</td>");
            //html.Append($"<td>${totalPriceVar}</td>");
            //html.Append("</tr>");
            //html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            //////////////////////////////////////////////////////////////////////////
            ////Add discount section if discount code is valid
            //if ((clsSQL.GetDiscountPercentage(discountCodeVar)) > 0.00)
            //{
            //    //This section is for the discount amount
            //    html.Append("<tr>");
            //    html.Append($"<td>Discount</td>");
            //    html.Append($"<td></td>");
            //    html.Append($"<td>{(clsSQL.GetDiscountPercentage(discountCodeVar) * 100).ToString("#.##")}%</td>");
            //    decimal discountPercentageVar2 = decimal.Parse(clsSQL.GetDiscountPercentage(discountCodeVar).ToString());
            //    html.Append($"<td>-({(totalPriceVar * discountPercentageVar2).ToString("C")})</td>");
            //    html.Append("</tr>");
            //    html.AppendLine("<tr><td colspan=5><hr /></td></tr>");

            //    //This section is for the total after discount
            //    html.Append("<tr>");
            //    html.Append($"<td></td>");
            //    html.Append($"<td></td>");
            //    html.Append($"<td>Discounted Subtotal </td>");
            //    html.Append($"<td>{(totalPriceVar - (totalPriceVar * discountPercentageVar2)).ToString("C")}</td>");
            //    html.Append("</tr>");
            //    html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            //}
            //////////////////////////////////////////////////////////////////////////
            ////Tax (8.25%):
            ////This section is for the tax
            //html.Append("<tr>");
            //html.Append($"<td></td>");
            //html.Append($"<td></td>");
            //html.Append($"<td>Tax (8.25%):</td>");
            //decimal discountPercentageVar = decimal.Parse(clsSQL.GetDiscountPercentage(discountCodeVar).ToString());
            //html.Append($"<td>{((totalPriceVar - (totalPriceVar * discountPercentageVar)) * 0.0825M).ToString("C")}</td>");
            //html.Append("</tr>");
            //html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            ////Total:Total:
            ////This section is for the Total after Tax
            //html.Append("<tr>");
            //html.Append($"<td></td>");
            //html.Append($"<td></td>");
            //html.Append($"<td>Total:</td>");
            //html.Append($"<td>{(((totalPriceVar - (totalPriceVar * discountPercentageVar)) * 0.0825M) + (((totalPriceVar - (totalPriceVar * discountPercentageVar))))).ToString("C")}</td>");
            //html.Append("</tr>");
            //html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            //html.AppendLine("</table>");
            //html.AppendLine("</body></html>");
            return html; // The returned value has all the HTML and CSS code to represent a webpage
        }



        internal static StringBuilder GenerateSalesReport(
            string title,
            ListView QueryResultsList,
            DateTime startDate,
            DateTime endDate)
        {
            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();

            // CSS is a way to style the HTML page. Each HTML tag can be customized.
            // In this example, the H1 and TD tags are customized.
            // Refer to this website for examples: https://www.w3schools.com/Css/css_syntax.asp

            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-align:center; font-weight: bold; text-align: center;}");
            css.AppendLine("h1 {color: blue;}");
            css.AppendLine("</style>");

            // HTML is used to format the layout of a webpage. This will be the frame
            // we use to place our data in. CSS is used to style the page to look a
            // certain way.

            // The <HTML> and </HTML> tags are the start and end of a webpage.
            // The <HEAD> and </HEAD> tags gives information about the webpage
            // such as the title and if there is any CSS styles being used.
            // The text between the <TITLE> and </TITLE> tags are used by the
            // browser to display the name of the page.
            // <BODY> and </BODY> is where the data of the page is stored
            // <H1> and </H1> is the largest font size for headings. These
            // can be from H1 to H6. H6 is the smallest font. https://www.w3schools.com/tags/tag_hn.asp

            html.AppendLine("<html>");
            html.AppendLine($"<head>{css}<title>{title}</title></head>");
            html.AppendLine("<body>");

            html.AppendLine($"<h1>{title}</h1>");

            // Create table of data
            // <TABLE> and </TABLE> is the start and end of a table of rows and data.
            // <TR> and </TR> is one row of data. They contain <TD> and </TD> tags.
            // <TD> and </TD> represents the data inside of the table in a particular row.
            // https://www.w3schools.com/tags/tag_table.asp

            // I used an <HR /> tag which is a "horizontal rule" as table data.
            // You can "span" it across multiple columns of data.
            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Quantity</td><td>Order Date</td><td>Price Per Item</td><td>Total Sales</td></tr>");
            html.AppendLine("<tr><td colspan=4><hr /></td></tr>");
            decimal totalPriceVar = 0.00M;
            //This section is for the individual items
            foreach (ListViewItem item in QueryResultsList.Items)
            {
                html.Append("<tr>");
                html.Append($"<td>{item.SubItems[0].Text}</td>");//Quantity
                html.Append($"<td>{item.SubItems[1].Text.Substring(0, item.SubItems[1].Text.IndexOf(" "))}</td>");//Date
                html.Append($"<td>${item.SubItems[2].Text}</td>");//Price Per Item
                html.Append($"<td>${(int.Parse(item.SubItems[0].Text) *decimal.Parse(item.SubItems[2].Text))}</td>");//Price Per Item

                //html.Append($"<td>${item.SubItems[3].Text}</td>");//Total Price
                totalPriceVar += (int.Parse(item.SubItems[0].Text) * decimal.Parse(item.SubItems[2].Text));
                html.Append("</tr>");
                html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            }
            //This section is for the subtotal
            html.Append("<tr>");
            html.Append($"<td></td>");
            html.Append($"<td></td>");
            html.Append($"<td>Subtotal:</td>");
            html.Append($"<td>${totalPriceVar}</td>");
            html.Append("</tr>");
            html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            ////////////////////////////////////////////////////////////////////////
            //Add discount section if discount code is valid
            //if ((clsSQL.GetDiscountPercentage(discountCodeVar)) > 0.00)
            //{
            //    //This section is for the discount amount
            //    html.Append("<tr>");
            //    html.Append($"<td>Discount</td>");
            //    html.Append($"<td></td>");
            //    html.Append($"<td>{(clsSQL.GetDiscountPercentage(discountCodeVar) * 100).ToString("#.##")}%</td>");
            //    decimal discountPercentageVar2 = decimal.Parse(clsSQL.GetDiscountPercentage(discountCodeVar).ToString());
            //    html.Append($"<td>-({(totalPriceVar * discountPercentageVar2).ToString("C")})</td>");
            //    html.Append("</tr>");
            //    html.AppendLine("<tr><td colspan=5><hr /></td></tr>");

            //    //This section is for the total after discount
            //    html.Append("<tr>");
            //    html.Append($"<td></td>");
            //    html.Append($"<td></td>");
            //    html.Append($"<td>Discounted Subtotal </td>");
            //    html.Append($"<td>{(totalPriceVar - (totalPriceVar * discountPercentageVar2)).ToString("C")}</td>");
            //    html.Append("</tr>");
            //    html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            //}
            //////////////////////////////////////////////////////////////////////////
            ////Tax (8.25%):
            ////This section is for the tax
            //html.Append("<tr>");
            //html.Append($"<td></td>");
            //html.Append($"<td></td>");
            //html.Append($"<td>Tax (8.25%):</td>");
            ////decimal discountPercentageVar = decimal.Parse(clsSQL.GetDiscountPercentage(discountCodeVar).ToString());
            ////html.Append($"<td>{((totalPriceVar - (totalPriceVar * discountPercentageVar)) * 0.0825M).ToString("C")}</td>");
            //html.Append("</tr>");
            //html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            ////Total:Total:
            ////This section is for the Total after Tax
            //html.Append("<tr>");
            //html.Append($"<td></td>");
            //html.Append($"<td></td>");
            //html.Append($"<td>Total:</td>");
            ////html.Append($"<td>{(((totalPriceVar - (totalPriceVar * discountPercentageVar)) * 0.0825M) + (((totalPriceVar - (totalPriceVar * discountPercentageVar))))).ToString("C")}</td>");
            //html.Append("</tr>");
            //html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            //html.AppendLine("</table>");
            //html.AppendLine("</body></html>");
            return html; // The returned value has all the HTML and CSS code to represent a webpage
        }


        internal static StringBuilder GenerateReport(string title, 
            ListView lstShoppingCartVar,
            string discountCodeVar, bool isManager)
        {
            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();

            // CSS is a way to style the HTML page. Each HTML tag can be customized.
            // In this example, the H1 and TD tags are customized.
            // Refer to this website for examples: https://www.w3schools.com/Css/css_syntax.asp

            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-align:center; font-weight: bold; text-align: center;}");
            css.AppendLine("h1 {color: blue;}");
            css.AppendLine("</style>");

            // HTML is used to format the layout of a webpage. This will be the frame
            // we use to place our data in. CSS is used to style the page to look a
            // certain way.

            // The <HTML> and </HTML> tags are the start and end of a webpage.
            // The <HEAD> and </HEAD> tags gives information about the webpage
            // such as the title and if there is any CSS styles being used.
            // The text between the <TITLE> and </TITLE> tags are used by the
            // browser to display the name of the page.
            // <BODY> and </BODY> is where the data of the page is stored
            // <H1> and </H1> is the largest font size for headings. These
            // can be from H1 to H6. H6 is the smallest font. https://www.w3schools.com/tags/tag_hn.asp

            html.AppendLine("<html>");
            html.AppendLine($"<head>{css}<title>{title}</title></head>");
            html.AppendLine("<body>");

            html.AppendLine($"<h1>{title}</h1>");

            if (isManager)
            {
                string managerName = clsSQL.GetNameOfManager(frmLogon.UserName);
                //MessageBox.Show(managerName);
                html.AppendLine($"<h1>Manager: {managerName}</h1>");
            }



            // Create table of data
            // <TABLE> and </TABLE> is the start and end of a table of rows and data.
            // <TR> and </TR> is one row of data. They contain <TD> and </TD> tags.
            // <TD> and </TD> represents the data inside of the table in a particular row.
            // https://www.w3schools.com/tags/tag_table.asp

            // I used an <HR /> tag which is a "horizontal rule" as table data.
            // You can "span" it across multiple columns of data.
            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Item</td><td>Item Price</td><td>Quantity</td><td>Total Price</td></tr>");
            html.AppendLine("<tr><td colspan=4><hr /></td></tr>");
            decimal totalPriceVar = 0.00M;
            //This section is for the individual items
            foreach (ListViewItem item in lstShoppingCartVar.Items)
            {
                html.Append("<tr>");
                html.Append($"<td>{item.SubItems[0].Text}</td>");//Item Name
                html.Append($"<td>{item.SubItems[2].Text}</td>");//Price
                html.Append($"<td>x{item.SubItems[1].Text}</td>");//Quantity
                html.Append($"<td>{item.SubItems[3].Text}</td>");//Total Price
                totalPriceVar += (decimal.Parse(item.SubItems[3].Text.ToString().Substring(1)));
                html.Append("</tr>");
                html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            }
            //This section is for the subtotal
            html.Append("<tr>");
            html.Append($"<td></td>");
            html.Append($"<td></td>");
            html.Append($"<td>Subtotal:</td>");
            html.Append($"<td>${totalPriceVar}</td>");
            html.Append("</tr>");
            html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            ////////////////////////////////////////////////////////////////////////
            //Add discount section if discount code is valid
            if ((clsSQL.GetDiscountPercentage(discountCodeVar)) > 0.00)
            {
                //This section is for the discount amount
                html.Append("<tr>");
                html.Append($"<td>Discount</td>");
                html.Append($"<td></td>");
                html.Append($"<td>{(clsSQL.GetDiscountPercentage(discountCodeVar) * 100).ToString("#.##")}%</td>");
                decimal discountPercentageVar2 = decimal.Parse(clsSQL.GetDiscountPercentage(discountCodeVar).ToString());
                html.Append($"<td>-({(totalPriceVar * discountPercentageVar2).ToString("C")})</td>");
                html.Append("</tr>");
                html.AppendLine("<tr><td colspan=5><hr /></td></tr>");

                //This section is for the total after discount
                html.Append("<tr>");
                html.Append($"<td></td>");
                html.Append($"<td></td>");
                html.Append($"<td>Discounted Subtotal </td>");
                html.Append($"<td>{(totalPriceVar - (totalPriceVar * discountPercentageVar2)).ToString("C")}</td>");
                html.Append("</tr>");
                html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            }
            ////////////////////////////////////////////////////////////////////////
            //Tax (8.25%):
            //This section is for the tax
            html.Append("<tr>");
            html.Append($"<td></td>");
            html.Append($"<td></td>");
            html.Append($"<td>Tax (8.25%):</td>");
            decimal discountPercentageVar = decimal.Parse(clsSQL.GetDiscountPercentage(discountCodeVar).ToString());
            html.Append($"<td>{((totalPriceVar - (totalPriceVar * discountPercentageVar)) * 0.0825M).ToString("C")}</td>");
            html.Append("</tr>");
            html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            //Total:Total:
            //This section is for the Total after Tax
            html.Append("<tr>");
            html.Append($"<td></td>");
            html.Append($"<td></td>");
            html.Append($"<td>Total:</td>");
            html.Append($"<td>{(((totalPriceVar - (totalPriceVar * discountPercentageVar)) * 0.0825M) + (((totalPriceVar - (totalPriceVar * discountPercentageVar))))).ToString("C")}</td>");
            html.Append("</tr>");
            html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            html.AppendLine("</table>");
            html.AppendLine("</body></html>");
            return html; // The returned value has all the HTML and CSS code to represent a webpage
        }
        internal static void PrintReport(StringBuilder html)
        {
            // Write (and overwrite) to the hard drive using the same filename of "Report.html"
            try
            {
                
                DateTime today = DateTime.Now;



                string strDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                        @"Reciepts - Paged Adventures\");
                if (!Directory.Exists(strDirectory))
                {
                    Directory.CreateDirectory(strDirectory);
                    
                    


                }
                //Check that the file doesn't already exist. If it doesn't exist, create
                // the file
                string strDirectoryPlusFileName = Path.Combine(strDirectory, $"{today.ToString("yyyy-MM-dd-HHmmss")} - Report.html");
                if (!File.Exists(strDirectoryPlusFileName))
                {
                    // A "using" statement will automatically close a file after opening it.                           
                    // It never hurts to include a file.Close() once you are done with a file.
                    using (StreamWriter writer = new StreamWriter(strDirectoryPlusFileName))
                    {
                        writer.WriteLine(html);
                    }
                    System.Diagnostics.Process.Start(@strDirectoryPlusFileName);//Open the report in the default web browser
                }












            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
