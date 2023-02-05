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
            Customer next = new Customer(txtForename.Text, txtSurname.Text, cboCounty.Text,
                txtTown.Text, txtPassword.Text, txtPhone.Text, txtEircode.Text, txtCardnumber.Text, txtEmail.Text);

            next.addCustomer();

            MessageBox.Show(next.toString() + " added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCustId.Text = Customer.getNextCustomerID().ToString("00000");
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
