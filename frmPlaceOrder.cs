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
        List<OrderItem> games = new List<OrderItem> { };
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

        /*private void grdGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // When button is pressed, this should add games to an array list and then display confirmation to the customer.

            /* This form had a problem with the List of OrderItems being overwritten. Problem was solved by moving my instance of OrderItem object inside this
               method. It kept getting overwritten because it was declared globally.*/

        //OrderItem orderItem = new OrderItem();

        /* Sets the OrderItems gameId and Cost Field and constructs the orderItem with a two argument constructor, leaving out the OrderId field
           until the order is actually placed.

        int gameId = Convert.ToInt32(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());
        orderItem.setGameId(gameId);
        decimal salePrice = Convert.ToDecimal(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[7].Value.ToString());
        orderItem.setCost(salePrice);

        totalPrice += salePrice;

        games.Add(orderItem);
        /* Note that an Order ID is not placed here, but is added through a loop when place order is pressed.
           This prevents the user from creating multiple orders for every Game. 

        foreach(var game in games)
        {
            MessageBox.Show(game.toString());
        }

        //MessageBox.Show("The game " + orderItem.toString() + " has been added to your order!\n"
        //  +"To create this order, press Place Order!","Added!",MessageBoxButtons.OK,MessageBoxIcon.Information);
    }*/

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if(isLoggedIn == false)
            {
                MessageBox.Show("You must log in to place an order!", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.Text = "";
            }
            if (txtTitle.Text == "")
            {
                MessageBox.Show("The customer ID field is required to place an order!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            // Check if orderItem list, called games, is empty and prevent user from placing an empty order.
            if (games.Any() != true)
            {
                MessageBox.Show("You need to select something to add to your order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int custid = Convert.ToInt32(txtTitle.Text);

            // Adding order details
            Int32 orderId = Order.getNextOrderID();
            thisOrder.setCost(totalPrice);
            thisOrder.setCustId(custid);
            thisOrder.setOrderId(orderId);
            thisOrder.addOrder();

            foreach (OrderItem i in games)
            {
                i.setOrderId(orderId);
                i.addOrderItem();
            }

            MessageBox.Show("Your order has been added to the system!" + thisOrder.toString(), "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnPlaceOrder.Visible = false;
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

        /*private void grdGames_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //add the chosen game to the shopping list
            Game game = new Game();
            game;
            lstCart.Items.Add("00001 Mario Returns 005.00");
            //lstCart.Items.Add(game.toString());
            //update cart total


        }*/

        private void grdGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //add the chosen game to the shopping list
            // More Comments. Remove these later.
            String id, title;
            Game game = new Game();
            //game;
            id = (grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());
            game.getGame(Convert.ToInt32(id));

            lstCart.Items.Add(game.orderString());
            /*
             int Id = Convert.ToInt32(grdProducts.Rows[grdProducts.CurrentCell.RowIndex].Cells[0].Value.ToString());
            
            //instantiate aProduct
            theProduct.getProduct(Id);

            //move the instance variable values to the form controls
            txtName.Text = theProduct.getName();
            txtDescription.Text = theProduct.getDescription();
            txtManufacturer.Text = theProduct.getManufacturer();
            txtQty.Text = theProduct.getQty().ToString("000");
            txtPrice.Text = theProduct.getPrice().ToString("###0.00");

            //Load TypeCodes into combo box and set current value
            DataSet ds = Type.getTypes();
            int typeIndex = 0;
            cboTypes.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboTypes.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
                if (ds.Tables[0].Rows[i][0].Equals(theProduct.getTypeCode())) typeIndex = i;
            }
            cboTypes.SelectedIndex = typeIndex;

            //make the product data availale for updating
            grpProduct.Visible = true;
             */
            //update cart total
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
