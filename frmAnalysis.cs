using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingApplication
{
    public partial class frmAnalysis : Form
    {
        frmMain parent;
        String[] months = {"JAN","FEB","MAR","APR","MAY","JUN","JUL","AUG","SEP","OCT","NOV","DEC" };
        public frmAnalysis()
        {
            InitializeComponent();
        }
        public frmAnalysis(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboRevenueYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Method sends an array of months to be queried into results by month.

            // Clears any existing data from the chart.
            chtRevenue.Series["Revenue"].Points.Clear();
            
            // Takes the last two chars from cboRevenue.Text and use them as the year.
            String year = cboRevenueYear.Text.Substring(2,2);

            for(int i =0; i < months.Length; i++)
            {
                // Sends the next year to the getRevenue method to return a decimal as profit or revenue.
                chtRevenue.Series["Revenue"].Points.AddXY(months[i].ToString(), Order.getRevenue(months[i], year));
            }
        }

        private void cboStockYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the chart if anything was selected before.
            chtStock.Series["Stock"].Points.Clear();

            // Get the title from the title text box.
            String title = txtGameTitle.Text;

            // Validate Title field.
            if (title.Equals(""))
            {
                MessageBox.Show("You must enter a title and a year to see the analysis for the given game.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Takes a substring of the year from the selected year to be used in the query.
            String year = cboStockYear.Text.Substring(2,2);

            // Add the returned values to the X and Y points on the chart.
            chtStock.Series["Stock"].Points.AddXY("Sales",OrderItem.getStock(title,year));
        }
    }
}
