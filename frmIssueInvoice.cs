using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingApplication
{
    public partial class frmIssueInvoice : Form
    {
        frmMain parent;
        public frmIssueInvoice()
        {
            InitializeComponent();
        }
        public frmIssueInvoice(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmIssueInvoice_Load(object sender, EventArgs e)
        {
            // Retrieve order details from orders that need to be printed.
            grdOrders.DataSource = Order.findOrdersToPrint().Tables["Orders"];

            // Set the receipt data to not visible on starting the form.
            grdReceipts.Visible = false;
            
            // If no orders match the criteria, nothing is brought up and information is displayed to the user.
            if(grdOrders.RowCount == 1)
            {
                MessageBox.Show("There are no orders that need invoices issued at this time. Please try again later!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdOrders.Visible = false;
                return;
            }
        }

        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the grid of orders does not contain any in transit orders.
            if (grdOrders.RowCount == 1)
            {
                MessageBox.Show("There are no orders that need invoices issued at this time. Please try again later!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdOrders.Visible = false;
                return;
            }

            Int32 CustId = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[4].Value.ToString());

            // Update User interface and brings customer details to a table for receipt generation.
            grdReceipts.Visible = true;
            grdReceipts.DataSource = Order.generateReceipt(CustId).Tables["Orders"];
        }

        private void grdReceipts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Give a file path and encoding to a streamwriter for receipts.
                StreamWriter sw = new StreamWriter("C:\\Users\\T00158237\\Desktop\\receipts.txt", true, Encoding.ASCII);

                String orderIdAsString = Convert.ToString(grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[0].Value.ToString());
                // Print the details of the receipt to a text file declared in the Streamwriter using cells in the DataGridView.
                sw.WriteLine("\nPrinting receipt: ");
                sw.WriteLine("Order Number    : " + grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[0].Value.ToString());

                sw.WriteLine("Forename        : " + grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[1].Value.ToString());

                sw.WriteLine("Surname         : " + grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[2].Value.ToString());

                sw.WriteLine("Email           : " + grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[3].Value.ToString());
                
                String email = grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[3].Value.ToString();

                sw.WriteLine("Date            : " + grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[4].Value.ToString());

                sw.WriteLine("Cost            : " + grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[5].Value.ToString());

                sw.WriteLine("Customer Number : " + grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[6].Value.ToString());

                // Close Streamwriter.
                sw.Close();

                // Converts the OrderId from datagridview and uses it to change the orders status to Fulfilled.
                Int32 orderId = Convert.ToInt32(grdReceipts.Rows[grdReceipts.CurrentCell.RowIndex].Cells[0].Value.ToString());

                // The following code will not work due to obvious fake email. I'm not giving out real credentials for a project. Comment out this code to let the rest of the code work.
                /*SmtpClient emailClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("fakeEmailAddress@gmail.com", "password"),
                    EnableSsl = true,
                };
                emailClient.Send("fakeEmailAddress@gmail.com", email, "Receipt for order number" + orderIdAsString, "Receipt for your order!");*/

                // Sets order Id to Fulfilled on successful recieving of Order.
                Order.finishOrder(orderId);

                MessageBox.Show("The receipt has been generated and the order has been fulfilled!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Exception: " + fnfe.Message);
            }
            finally
            {
                // When grid is empty, Display that no more receipts need to be generated currently.
                if(grdReceipts.RowCount == 1)
                {
                    MessageBox.Show("There are no more orders to generate receipts for! Please try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grdReceipts.Visible = false;
                }
            }
        }
    }
}
