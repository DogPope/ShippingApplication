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
        //frmMain parent;
        public frmRegisterCustomer()
        {
            InitializeComponent();
        }

        public frmRegisterCustomer(frmMain Parent)
        {
            InitializeComponent();
            //parent = Parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer next = new Customer(Convert.ToInt32(txtCustId.Text), txtForename.Text, txtSurname.Text, txtTown.Text,
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
            this.DialogResult = DialogResult.OK;
            this.Close();
            //parent.Visible = true;
        }
    }
}
