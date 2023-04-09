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
        //List<OrderItem> games = new List<OrderItem> { };
        Customer loginCustomer = new Customer();
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
            txtOrderId.Text = Order.getNextOrderID().ToString("00000");
        }

        private void grdGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderItem orderItem = new OrderItem();
            Game thisGame = new Game();

            int gameId = Convert.ToInt32(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());
            orderItem.setGameId(gameId);
            thisGame.getGame(gameId);
            MessageBox.Show(thisGame.orderString());

            // Next line will have to be changed. Cost is no longer the seventh item.
            decimal salePrice = Convert.ToDecimal(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[6].Value.ToString());
            orderItem.setCost(salePrice);

            totalPrice += salePrice;
            txtTotal.Text = totalPrice.ToString();
            //games.Add(orderItem);
            lstCart.Items.Add(thisGame.orderString());
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

            // Check if orderItem list, called games, is empty and prevent user from placing an empty order.

            if (lstCart.Items.Count == 0)
            {
                MessageBox.Show("You need to select something to add to your order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (String i in lstCart.Items)
            {
                // Note. Substring with 2 arguments takes in Starting character and LENGTH of string, unlike Java.
                i.ToString();
                int id = Convert.ToInt32(i.Substring(9, 5));
                MessageBox.Show(i.Substring(9,5));
            }

            /*if (games.Any() != true)
            {
                MessageBox.Show("You need to select something to add to your order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            // This line needs refactoring.
            int custId = loginCustomer.getCustomerId();

            // Adding order details
            Int32 orderId = Order.getNextOrderID();
            thisOrder.setCost(totalPrice);
            thisOrder.setCustId(custId);
            thisOrder.setOrderId(orderId);
            thisOrder.addOrder();

            /*foreach (OrderItem i in games)
            {
                i.setOrderId(orderId);
                i.addOrderItem();
            }*/

            MessageBox.Show("Your order has been added to the system!" + thisOrder.toString(), "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //btnPlaceOrder.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Add validation for a title that does not exist.
            if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("The search field must not be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                txtTitle.Text = "";
                return;
            }

            grdGames.DataSource = Game.findGameByTitle(txtTitle.Text).Tables["Games"];
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Remove the chosen game from the shopping list
            if (lstCart.SelectedIndex == -1)
            {
                lstCart.ClearSelected();
                return;
            }
            lstCart.Items.RemoveAt(lstCart.SelectedIndex);
            // Find way to also remove selected item from array.
            // Title of array.
            // List<OrderItem> games = new List<OrderItem> { };

            //update cart total - reduce total
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
                    MessageBox.Show("Welcome: " + loginCustomer.getForename(), "Hello!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isLoggedIn = true;
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
                "Email:\t\temail@email.com\nPassword:\t\tpassword", "Help", MessageBoxButtons.OK);
        }
    }
}
