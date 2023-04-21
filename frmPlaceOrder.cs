using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ShippingApplication
{
    public partial class frmPlaceOrder : Form
    {
        frmMain parent;
        Customer loginCustomer = new Customer();
        List<Game> games = new List<Game>();
        Game thisGame = new Game();
        Order thisOrder = new Order();
        decimal totalPrice = 0;
        int counter = 3;
        bool isLoggedIn = false;
        public frmPlaceOrder()
        {
            InitializeComponent();
        }
        public frmPlaceOrder(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmManageOrders_Load(object sender, EventArgs e)
        {
            // On loading the form, Gets the next available Order ID and presents it at the top of the page.
            txtOrderId.Text = Order.getNextOrderID().ToString("00000");
        }

        private void grdGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the game data from the cell in the data grid view.
            Int32 gameId = Convert.ToInt32(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());
            thisGame.getGame(gameId);

            // Quantity is needed for stock control later.
            Int32 quantity = thisGame.getQuantity();
            thisGame.setQuantity(thisGame.getQuantity() - 1);

            // Check if the number of instances in the database is less than the amount the user is trying to order.
            if(quantity < 1)
            {
                MessageBox.Show("There is currently no stock left of this item. Please try again later!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            // Add the game to a list array for INSERT INTO Order_Items Query.
            games.Add(thisGame);

            // Gets the price from the grid.
            decimal salePrice = Convert.ToDecimal(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[6].Value.ToString());

            // converts the price to be added to the shopping cart. Displays total where TXTtotal appears below the shopping cart.
            totalPrice += salePrice;
            txtTotal.Text = totalPrice.ToString();
            lstCart.Items.Add(thisGame.orderString());

            /* Loops through each item in lstCart.Items and adds to a counter each time it sees an occurence of the same ID Number.
               If the 'instances' counter is greater than the games Quantity, it removes it from the cart and gives the customer an error message. */
            int instances = 0;

            foreach (string list in lstCart.Items)
            {
                if (list.Contains(gameId.ToString()))
                    instances++;
                if(instances > quantity)
                {
                    MessageBox.Show("The quantity you are trying to order is greater than the quantity we have!", "Removing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstCart.Items.RemoveAt(lstCart.Items.IndexOf(list));
                    return;
                }
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Make sure that a customer who is not logged in cannot place an order.
            if(isLoggedIn == false)
            {
                MessageBox.Show("You must log in to place an order!", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.Text = "";
                return;
            }

            // Check if list cart is empty and prevent user from placing an empty order.
            if (lstCart.Items.Count == 0)
            {
                MessageBox.Show("You need to select something to add to your order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gets the customers details based on the information supplied.
            int custId = loginCustomer.getCustomerId();

            // Adding order details
            thisOrder.setCost(totalPrice);
            thisOrder.setCustId(custId);
            thisOrder.setOrderId(Convert.ToInt32(txtOrderId.Text));
            thisOrder.addOrder();

            foreach (String i in lstCart.Items)
            {
                // Note. Substring with 2 arguments takes in Starting character and LENGTH of string, unlike Java.
                // Sets the fields for each individual item to be inserted as an individual order item.
                i.ToString();
                int gameId = Convert.ToInt32(i.Substring(9, 5));
                decimal thisPrice = Convert.ToDecimal(i.Substring(i.Length - 6, 6));
                int orderID = Convert.ToInt32(txtOrderId.Text);

                // Declare an order Item and add it to database.
                OrderItem newItem = new OrderItem(gameId, orderID, thisPrice);
                newItem.addOrderItem();

                // Declares a game object to assess its quantity to make sure the user cant order more than is in the database.
                Game game = new Game();
                game.getGame(gameId);
                int quantity = game.getQuantity();
                if(quantity < 1)
                {
                    MessageBox.Show("We are currently out of this item. Please try another time!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // On successful order placed, reduces the quantity for each item in the system.
                game.reduceQuantity(gameId);
            }

            // Display confirmation to user.
            MessageBox.Show("Your order has been added to the system!","Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnPlaceOrder.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate title field
            if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("The search field must not be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                txtTitle.Text = "";
                return;
            }

            // Retrieves game data from the title given.
            grdGames.DataSource = Game.findGameByTitle(txtTitle.Text).Tables["Games"];
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // If nothing from the cart has been selected, nothing can be removed.
            if(lstCart.SelectedIndex == -1)
            {
                MessageBox.Show("You must select something to remove!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            // Creates a string array from the objects in lstCart.
            string[] clist = lstCart.SelectedItems.OfType<string>().ToArray();

            // Loops through the array, assigning the last 6 characters to a decimal number, then subtracts that from total price.
            foreach(String i in clist)
            {
                decimal thisPrice = Convert.ToDecimal(i.Substring(i.Length - 6, 6));
                totalPrice -= thisPrice;
            }
            txtTotal.Text = totalPrice.ToString();

            // Then removes the selected item from lstCart.
            if (lstCart.SelectedIndex == -1)
            {
                lstCart.ClearSelected();
                return;
            }
            lstCart.Items.RemoveAt(lstCart.SelectedIndex);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Note that this will load a Deregistered Customer as registered for some reason.
            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("You need to enter a valid email address to log in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.Text = "";
                return;
            }
            // Checks whether email is valid and queries Customers with the given email address.
            // Uses email given to instantiate the customer object.
            loginCustomer.findCustomerByEmail(txtEmail.Text);
            String email = loginCustomer.getEmail();

            if (email.Equals(""))
            {
                MessageBox.Show("We do not have an account associated with the given address. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

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
                btnLogin.Visible = false;
            }
            else
            // Displays error message. Decrements number of attempts remaining for security purposes.
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
                "Email:\t\tPlaceholder@gmail.com\nPassword:\t\tPlaceholder", "Help", MessageBoxButtons.OK);
        }

        // Selects all registered games, in case the user doesn't quite know what they want.
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            grdGames.DataSource = Game.selectAllGames().Tables["Games"];
        }
    }
}
