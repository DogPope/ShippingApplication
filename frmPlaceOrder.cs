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
        Customer orderCustomer = new Customer();
        Game orderGame = new Game();
        Order thisOrder = new Order();
        OrderItem orderItem = new OrderItem();
        List<OrderItem> games = new List<OrderItem> { };
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
            if(thisOrder == null)
            {
                MessageBox.Show("You must have an existing order to add Games to!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            // Order_Id, Cost, Game_Id
            int gameId = Convert.ToInt32(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());
            decimal salePrice = Convert.ToDecimal(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[7].Value.ToString());
            orderItem.setCost(salePrice);
            orderItem.setGameId(gameId);
            games.Add(orderItem);
            MessageBox.Show("The game " + orderItem.toString() + " has been added to your order!","Added!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            // Need to create an order to set an order item.
            // Use C# to create an array of order Items to be inserted when place order is clicked.
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
            if(games == null)
            {
                MessageBox.Show("You need to select something to add to your order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int custid = Convert.ToInt32(txtCustId.Text);
            decimal cost = orderGame.getSalePrice();
            foreach(var orderItem in games)
            {

            }
            thisOrder.setCost(cost);
            thisOrder.setCustId(custid);
            thisOrder.addOrder();
            
            MessageBox.Show("Your order has been added to the system!" + thisOrder.toString() ,"Added!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnPlaceOrder.Visible = false;
        }
    }
}
