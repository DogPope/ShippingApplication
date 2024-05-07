using System;
using System.Windows.Forms;

namespace ShippingApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Asks the user if they would like to exit.
            DialogResult result = MessageBox.Show("Are you sure you would like to exit?", "Quitting!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }

        // All the following entries are for the menu and to navigate to other forms.
        private void mnuRegisterCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterCustomer newCustomer = new frmRegisterCustomer(this);
            newCustomer.Show();
        }

        private void mnuCustomerUpdateDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCustomer editCustomer = new frmUpdateCustomer(this);
            editCustomer.Show();
        }

        private void mnuRegisterGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterGame makeGame = new frmRegisterGame(this);
            makeGame.Show();
        }

        private void mnuPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlaceOrder addOrder = new frmPlaceOrder(this);
            addOrder.Show();
        }

        private void mnuGameUpdateDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateGame editGame = new frmUpdateGame(this);
            editGame.Show();
        }

        private void mnuAdminFeatures_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnalysis analyse = new frmAnalysis(this);
            analyse.Show();
        }

        private void mnuManageOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageOrders manage = new frmManageOrders(this);
            manage.Show();
        }

        private void mnuShipOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrderShipping orderShipping = new frmOrderShipping(this);
            orderShipping.Show();
        }

        private void mnuIssueReceipts_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIssueInvoice invoices = new frmIssueInvoice(this);
            invoices.Show();
        }
    }
}
