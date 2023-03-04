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
    public partial class frmRegisterCustomer : Form
    {
        frmMain parent;
        public frmRegisterCustomer()
        {
            InitializeComponent();
        }

        public frmRegisterCustomer(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validation Section
            if (txtForename.Text == "")
            {
                MessageBox.Show("A name is required to set up an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            if (txtSurname.Text == "")
            {
                MessageBox.Show("A name is required to set up an account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            if (txtTown.Text == "")
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
                txtTown.Focus();
                return;
            }

            txtPhone.Text.Trim(' ');
            foreach(char a in txtPhone.Text)
            {
                if (!Char.IsDigit(a))
                {
                    MessageBox.Show("A phone number contains 10 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }
            }

            if (!Customer.isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("An email address is required for receipts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            txtCardnumber.Text.Trim(' ');
            if(txtCardnumber.Text.Length != 16)
            {
                MessageBox.Show("A credit card must consist of 16 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardnumber.Focus();
                return;
            }
            foreach(char c in txtCardnumber.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("A credit card must consist of 16 digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCardnumber.Focus();
                    return;
                }
            }
            if(txtStatus.Text != "Registered" && txtStatus.Text != "Deregistered")
            {
                MessageBox.Show("An account can only be \"Registered\" or \"Deregistered\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStatus.Focus();
                return;
            }
            if(cboCounty.SelectedIndex == 0)
            {
                MessageBox.Show("You must select a county for deliveries!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCounty.Focus();
                return;
            }


            // On successful validation, 
            Customer next = new Customer(Customer.getNextCustomerID(), txtForename.Text, txtSurname.Text, txtTown.Text,
                txtEircode.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text, txtCardnumber.Text, txtStatus.Text, cboCounty.Text);

            next.addCustomer();

            MessageBox.Show(next.toString() + " added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtForename.Clear();
            txtSurname.Clear();
            txtTown.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtEircode.Clear();
            txtCardnumber.Clear();
            txtPhone.Text = "0.00";
            cboCounty.SelectedIndex = -1;
            txtForename.Focus();
            Console.WriteLine(next.toString());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
