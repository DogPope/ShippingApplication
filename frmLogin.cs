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
    public partial class frmLogin : Form
    {
        frmMain parent;
        public static frmLogin instance;
        Customer loginCustomer = new Customer();
        int counter = 3;
        public frmLogin(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmLogin()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

                
                if (txtEmail.Text.Equals(""))
                {
                    MessageBox.Show("You need to enter a valid email address to log in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    txtEmail.Text = "";
                    return;
                }
                if (Customer.isValidEmail(txtEmail.Text))
                {
                    loginCustomer.findCustomerByEmail(txtEmail.Text);

                    if (loginCustomer.getPassword().Equals(txtPassword.Text))
                    {
                        MessageBox.Show("Valid password!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Welcome: " + loginCustomer.getForename(), "Hello!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        counter--;
                        MessageBox.Show("Invalid password! You have " + counter +
                            " attempts remaining!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }
                    if (counter == 0)
                    {
                        MessageBox.Show("You have exceeded the maximum number of attempts! Closing form!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        return;
                    }
                }
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The following details are one accurate entry and will work for login purposes.\n" +
                "Email:\t\temail@email.com\nPassword:\t\tpassword","Help",MessageBoxButtons.OK);
        }
    }
}
