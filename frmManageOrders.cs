using System;
using System.Windows.Forms;

namespace ShippingApplication
{
    public partial class frmManageOrders : Form
    {
        frmMain parent;
        Customer loginCustomer = new Customer();
        Order thisOrder = new Order();
        bool isLoggedIn = false;
        int counter = 3;
        public frmManageOrders()
        {
            InitializeComponent();
        }
        public frmManageOrders(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;

            // Order management buttons set to invisible on start-up.
            btnRemove.Visible = false;
            btnCancelOrder.Visible = false;
            btnReturnOrder.Visible = false;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Uses email given to instantiate the customer object.
            loginCustomer.findCustomerByEmail(txtEmail.Text);

            // Prevent the user from entering an empty email address.
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("We do not have an account associated with the given address. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            // Check if the user entered a valid email address.
            if (!Customer.isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("That is not a valid email address. Please ensure everything is spelled correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // If email is valid, use it to query the database for customer data.
            String email = loginCustomer.getEmail();
            String status = loginCustomer.getStatus();

            // Checks if a customers Status is Deregistered and does not allow them to place an order.
            if (status == "Deregistered")
            {
                MessageBox.Show("The account associated with these details is Deactivated! Please register an account to proceed!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Compares the given email address with associated password. Complete with counter that give three attempts at log on.
            if (loginCustomer.getPassword().Equals(txtPassword.Text))
            {
                MessageBox.Show("Welcome: " + loginCustomer.getForename(), "Hello!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isLoggedIn = true;
            }
            else
            // Displays error message. Decrements number of attempts for the user to login.
            {
                counter--;
                MessageBox.Show("Invalid password! You have " + counter +
                    " attempts remaining!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPassword.Focus();
            }

            // When counter reaches zero, the form closes.
            if (counter == 0)
            {
                MessageBox.Show("You have exceeded the maximum number of attempts! Closing form!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Displays valid logon credentials for testing purposes. Would be removed for final product.
            MessageBox.Show("The following details are one accurate entry and will work for login purposes.\n" +
                "Email:\t\temail@email.com\nPassword:\t\tpassword", "Help", MessageBoxButtons.OK);
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            // Brings up the users orders and allows them to manage them.
            if (isLoggedIn == false)
            {
                MessageBox.Show("You need to be logged in to manage an order!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gets the customer ID and uses it to query orders belonging to that customer ID
            int custId = loginCustomer.getCustomerId();

            // Sets the Order management system to visible.
            grdOrders.Visible = true;
            grdOrders.DataSource = Order.viewOrdersByCustId(custId).Tables["Orders"];
            btnReturnOrder.Visible = true;
            btnCancelOrder.Visible = true;
        }

        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if any orders have been returned by the query.
            if (grdOrders.RowCount == 1)
            {
                MessageBox.Show("You do not have any Orders associated with this account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Makes the datagridview for orders invisible, and makes the individual items visible in another data grid view below.
            grdOrderItems.Visible = true;
            btnRemove.Visible = true;
            int OrderId = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[0].Value.ToString());
            thisOrder.setOrderId(OrderId);
            grdOrderItems.DataSource = OrderItem.viewOrderItems(OrderId).Tables["Order_Items"];
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if the shopping cart is empty.
            if (grdOrderItems.Rows.Count == 1)
            {
                MessageBox.Show("This Order no longer contains any items. It is being Cancelled.", "Cancelling Order!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Int32 OrderId = thisOrder.getOrderId();
                Order.cancelOrder(OrderId);
                return;
            }

            // Create an Order Object for management purposes.
            OrderItem thisOrderItem = new OrderItem();
            int gameId = Convert.ToInt32(grdOrderItems.Rows[grdOrderItems.CurrentCell.RowIndex].Cells[2].Value.ToString());
            thisOrderItem.setGameId(gameId);

            // Pop-up asks the user if they would like to remove an individual game from an order.
            DialogResult result = MessageBox.Show("Would you like to remove this item from your order?", "Removal", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Deletes item from database and removes it from games grid.
                thisOrderItem.removeOrderItem(gameId);
                Int32 rows = grdOrderItems.CurrentCell.RowIndex;
                grdOrderItems.Rows.RemoveAt(rows);
            }
            // Do nothing.
            else
                return;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            // If no orders placed, inform the user then do nothing.
            if (grdOrders.Rows.Count == 1)
            {
                MessageBox.Show("You do not have any orders placed with us at the moment. Try placing an order first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve order details from grid. 
            int OrderId = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[0].Value.ToString());

            // Retrieves order details using the given order id.
            Order newOrder = new Order();
            newOrder.getOrder(OrderId);
            String status = newOrder.getStatus();

            // Only allow user to cancel the details of an unfulfilled order.
            if (status.Equals("Placed") || status.Equals("In Transit"))
            {
                Int32 rows = grdOrders.CurrentCell.RowIndex;
                grdOrders.Rows.RemoveAt(rows);
                Order.cancelOrder(OrderId);
                MessageBox.Show("The order has been successfully cancelled. Thanks for your custom!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // For other classes of order, do nothing.
            else
            {
                MessageBox.Show("The order cannot be cancelled at this time. You might try the return option instead.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnReturnOrder_Click(object sender, EventArgs e)
        {
            // If no orders placed, inform the user then do nothing.
            if (grdOrders.Rows.Count == 1)
            {
                MessageBox.Show("You do not have any orders placed with us at the moment. Try placing an order first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve order details using the given ID.
            int OrderId = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Order thisOrder = new Order();
            thisOrder.getOrder(OrderId);

            // If the order is less than 30 days old, it can be returned.
            // Gets age of order from database, converts it to days.
            double ageOfOrder = Convert.ToDouble(Order.getAgeOfOrder(OrderId));
            if (ageOfOrder > 30)
            {
                MessageBox.Show("This order is over the 30 day return period. We apologize for any inconvenience caused.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // If order older than 30 days, prevent the user from returning it.
            else
            {
                MessageBox.Show("Order has been successfully returned. Thank you for your co-operation!", "Returns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Order.returnOrder(OrderId);
                return;
            }
        }
    }


}

