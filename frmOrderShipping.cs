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
    public partial class frmOrderShipping : Form
    {
        frmMain parent;
        public frmOrderShipping()
        {
            InitializeComponent();
        }
        public frmOrderShipping(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
            grdGames.Visible = false;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        private void btnShowOrders_Click(object sender, EventArgs e)
        {
            // On clicking the show orders button, bring up orders that need to be sent out.
            grdOrders.DataSource = Order.showShippingOrders().Tables["Orders"];
        }

        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If query returns empty set, display message to user, then return.
            if (grdOrders.RowCount == 1)
            {
                MessageBox.Show("There are no Orders currently needing assembly!", "Congrats! You did it!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get order details from Order field, fill out data table with orders.
            int OrderId = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[0].Value.ToString());
            
            // Fills out the table with individual order items, then makes the grid visible.
            grdGames.DataSource = OrderItem.viewOrderItems(OrderId).Tables["Order_Items"];
            grdGames.Visible = true;
        }

        private void grdGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If an individual item is clicked, the user then can comfirm the successful collection of the entire order.
            DialogResult result = MessageBox.Show("Has this order been assembled, complete with items, labels and stickers?", "Checklist", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Order status gets updated to In Transit.
                Int32 orderId = Convert.ToInt32(grdOrders.Rows[grdOrders.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Order.transportOrder(orderId);
                MessageBox.Show("This order has now been changed to \"In Transit\"","Thank You!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                // Make the individual items of the completed order invisible.
                grdGames.Visible = false;
            }
            else
                return;
        }
    }
}
