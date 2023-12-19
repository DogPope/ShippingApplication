using System;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate the given customer details.
            if (txtEnterForename.Text.Equals(""))
            {
                MessageBox.Show("You must enter part of your forename to continue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterForename.Text = "";
                txtEnterForename.Focus();
                return;
            }
            String forename = txtEnterForename.Text;

            // Brings up the customer details using the name given.
            grdCustomers.DataSource = Customer.findCustomerByName(forename).Tables["Customers"];

            // If no rows returned, display message and exit.
            if (grdCustomers.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterForename.Focus();
                txtEnterForename.Text = "";
                return;
            }

            // Display grid to customer.
            grdCustomers.Visible = true;
        }

        private void grdCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if forename field is empty.
            if (txtEnterForename.Text.Equals(""))
            {
                MessageBox.Show("You must enter a valid forename to continue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterForename.Focus();
                return;
            }

            int id = Convert.ToInt32(grdCustomers.Rows[grdCustomers.CurrentCell.RowIndex].Cells[0].Value.ToString());

            // Assign customer details to the text boxes.
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

            grdCustomers.Visible = true;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            // Validate the fields entered by the customer. If nothing is returned, exit.
            if (txtForename.Text == "" || txtForename.Text.Length > 20)
            {
                MessageBox.Show("A name is required to set up an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }

            if (txtSurname.Text == "" || txtSurname.Text.Length > 20)
            {
                MessageBox.Show("A name is required to set up an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            if (txtTown.Text == "" || txtTown.Text.Length > 20)
            {
                MessageBox.Show("A town is required to set up an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }

            if (!Customer.isValidEircode(txtEircode.Text))
            {
                MessageBox.Show("An EIR Code is required to send parcels to your address!\nIt must be a three character Routing code +" +
                    " a four character unique identifier, punctuated by a space or hyphen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }
            if (!Customer.isValidPassword(txtPassword.Text))
            {
                MessageBox.Show("A password must have at least 1 upper case letter, a lower case letter, a symbol and a number." +
                    "\nIt must be between 8 and 20 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            txtPhone.Text.Trim(' ');
            if (!Customer.isValidPhone(txtPhone.Text))
            {
                MessageBox.Show("A phone number contains 10 digits and starts with 08.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!Customer.isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("An email address is required for receipts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            String card = txtCardnumber.Text.Trim(' ');
            if (card.Length != 16)
            {
                MessageBox.Show("A credit card must consist of 16 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardnumber.Focus();
                return;
            }
            foreach (char c in card)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("A credit card must consist of 16 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCardnumber.Focus();
                    return;
                }
            }
            if (cboCounty.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a county for deliveries!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCounty.Focus();
                return;
            }
            if (grdCustomers.RowCount == 1)
            {
                MessageBox.Show("You must select a customer to Deregister!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterForename.Text = "";
                txtEnterForename.Focus();
                return;
            }

            // Update customer details from the values given from the text boxes.
            updateCustomer.setForename(txtForename.Text);
            updateCustomer.setSurname(txtSurname.Text);
            updateCustomer.setTown(txtTown.Text);
            updateCustomer.setEircode(txtEircode.Text);
            updateCustomer.setPassword(txtPassword.Text);
            updateCustomer.setPhoneNumber(txtPhone.Text);
            updateCustomer.setEmail(txtEmail.Text);
            updateCustomer.setCardNumber(txtCardnumber.Text);
            updateCustomer.setCounty(cboCounty.Text);

            // Update the data in the database
            updateCustomer.updateCustomer();

            // Display confirmation message
            MessageBox.Show("Customer information updated Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset UI
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
            btnDeregisterAccount.Visible = false;
            btnSearch.Visible = false;
            btnUpdateCustomer.Visible = false;
        }

        private void btnDeregisterAccount_Click(object sender, EventArgs e)
        {
            // Check if the values given in the text fields are legitimate.
            if (txtEnterForename.Text.Equals(""))
            {
                MessageBox.Show("You must enter a valid ID number to continue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterForename.Text = "";
                txtEnterForename.Focus();
                return;
            }

            // Checks if any data is returned and exits if it is not.
            if (grdCustomers.RowCount == 1)
            {
                MessageBox.Show("You must select a customer to Deregister!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnterForename.Text = "";
                txtEnterForename.Focus();
                return;
            }

            // Get the customers ID from the data grid.
            int id = Convert.ToInt32(grdCustomers.Rows[grdCustomers.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Customer deregisterCustomer = new Customer();
            deregisterCustomer.getCustomer(id);

            // Invoke method to remove customer, then displays a confirmation message.
            deregisterCustomer.deregisterCustomer();
            MessageBox.Show("The Customers status has successfully been changed to Deregistered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Makes the order management buttons invisible.
            btnDeregisterAccount.Visible = false;
            btnSearch.Visible = false;
            btnUpdateCustomer.Visible = false;

            // Resets User Interface.
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
        }
    }
}