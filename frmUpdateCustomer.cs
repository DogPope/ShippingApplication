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
    public partial class frmUpdateCustomer : Form
    {
        frmMain parent;
        public frmUpdateCustomer(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'custDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
            //this.cUSTOMERSTableAdapter.Fill(this.custDataSet.CUSTOMERS);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCustId.Text == "")
            {
                MessageBox.Show("This field only accepts numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach(char c in txtCustId.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("This field only accepts numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            int id = Convert.ToInt32(txtCustId.Text);

            grdCustomers.DataSource = Customer.findCustomerById(id).Tables["Customers"];

            if (grdCustomers.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtCustId.Focus();
                return;
            }

            grdCustomers.Visible = true;
        }
    }
}
