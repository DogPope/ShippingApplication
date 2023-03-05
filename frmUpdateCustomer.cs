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
        Customer updateCustomer = new Customer();
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
            //this.cUSTOMERSTableAdapter.Fill(this.custDataSet.CUSTOMERS);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCustId.Text == "")
            {
                MessageBox.Show("You must enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (id < 1 || id > Int32.MaxValue)
            {
                MessageBox.Show("Please enter a positive integer below 2.1 billion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grdCustomers.DataSource = Customer.findCustomerById(id).Tables["Customers"];

            if (grdCustomers.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCustId.Focus();
                return;
            }

            grdCustomers.Visible = true;
        }

        private void grdCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grdCustomers.Rows[grdCustomers.CurrentCell.RowIndex].Cells[0].Value.ToString());

            updateCustomer.getCustomer(id);
            txtForename.Text = updateCustomer.getForename();
            txtSurname.Text = updateCustomer.getSurname();
            txtTown.Text = updateCustomer.getTown();
            txtEircode.Text = updateCustomer.getEircode();
            txtPassword.Text = updateCustomer.getPassword();
            txtPhone.Text = updateCustomer.getPhoneNumber();
            txtEmail.Text = updateCustomer.getEmail();
            txtCardnumber.Text = updateCustomer.getCardNumber();
            cboCounty.Text = updateCustomer.getCounty();
            txtStatus.Text = updateCustomer.getStatus();

            grdCustomers.Visible = true;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //validate the data
            //Int32 custId, String forename, String surname, String town, String EIRCode, String password, String phone, String email, String cardNumber, String county, String status
            //instantiate the object variables
            updateCustomer.setForename(txtForename.Text);
            updateCustomer.setSurname(txtSurname.Text);
            updateCustomer.setTown(txtTown.Text);
            updateCustomer.setEircode(txtEircode.Text);
            updateCustomer.setPassword(txtPassword.Text);
            updateCustomer.setPhoneNumber(txtPhone.Text);
            updateCustomer.setEmail(txtEmail.Text);
            updateCustomer.setCardNumber(txtCardnumber.Text);
            updateCustomer.setCounty(cboCounty.Text);
            updateCustomer.setStatus(txtStatus.Text);

            //update the data in the database
            updateCustomer.updateCustomer();

            //Display confirmation message
            MessageBox.Show("Customer information updated Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grdCustomers.Visible = false;
            txtForename.Clear();
            txtSurname.Clear();
            txtTown.Clear();
            txtEircode.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCardnumber.Clear();
            cboCounty.SelectedIndex = -1;
            txtStatus.Clear();
        }
    }
}

