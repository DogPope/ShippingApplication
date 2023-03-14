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
    public partial class frmPlaceOrder : Form
    {
        frmMain parent;
        List<OrderItem> games = new List<OrderItem> { };
        Customer orderCustomer = new Customer();
        //Game orderGame = new Game();
        Order thisOrder = new Order();
        //OrderItem orderItem = new OrderItem();
        decimal totalPrice = 0;
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
            // TODO: This line of code loads data into the 'dataSet2.ORDERS' table. You can move, or remove it, as needed.
            //this.oRDERSTableAdapter.Fill(this.dataSet2.ORDERS);
            this.gAMESTableAdapter.Fill(this.dataSet1.GAMES);
        }

        private void grdGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // When button is pressed, this should add games to an array list and then display confirmation to the customer.

            /* This form had a problem with the List of OrderItems being overwritten. Problem was solved by moving my instance of OrderItem object inside this
               class, where it kept getting overwritten because it was declared globally.*/
            OrderItem orderItem = new OrderItem();

            /* Sets the OrderItems gameId and Cost Field and constructs the orderItem with a two argument constructor, leaving out the OrderId field
               until the order is actually placed. */
            int gameId = Convert.ToInt32(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());
            orderItem.setGameId(gameId);
            decimal salePrice = Convert.ToDecimal(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[7].Value.ToString());
            orderItem.setCost(salePrice);

            totalPrice += salePrice;

            games.Add(orderItem);
            /* Note that an Order ID is not placed here, but is added through a loop when place order is pressed.
               This prevents the user from creating multiple orders for every Game. */
            
            foreach(var game in games)
            {
                MessageBox.Show(game.toString());
            }

            //MessageBox.Show("The game " + orderItem.toString() + " has been added to your order!\n"
            //  +"To create this order, press Place Order!","Added!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if(txtCustId.Text == "")
            {
                MessageBox.Show("The customer ID field is required to place an order!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtCustId.Focus();
                return;
            }
            foreach (char c in txtCustId.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("This field only accepts positive numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            // Check if orderItem list, called games, is empty and prevent user from placing an empty order.
            if(games.Any() != true)
            {
                MessageBox.Show("You need to select something to add to your order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int custid = Convert.ToInt32(txtCustId.Text);

            // Adding order details
            Int32 orderId = Order.getNextOrderID();
            thisOrder.setCost(totalPrice);
            thisOrder.setCustId(custid);
            thisOrder.setOrderId(orderId);
            thisOrder.addOrder();

            foreach(OrderItem i in games)
            {
                i.setOrderId(orderId);
                i.addOrderItem();
            }
            
            MessageBox.Show("Your order has been added to the system!" + thisOrder.toString() ,"Added!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnPlaceOrder.Visible = false;
        }
    }
}
