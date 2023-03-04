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
    public partial class frmRegisterGame : Form
    {
        frmMain parent;
        public frmRegisterGame()
        {
            InitializeComponent();
        }

        public frmRegisterGame(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Game doom = new Game(Game.getNextGameID(), txtTitle.Text, txtDeveloper.Text, txtPublisher.Text, txtGenre.Text, txtDescription.Text,
                                 Convert.ToDecimal(txtBuyPrice.Text), Convert.ToDecimal(txtSalePrice.Text), Convert.ToInt32(txtQuantity.Text), txtStatus.Text);
            //Int32 gameId, String title, String developer, String publisher, String genre, String description, decimal buyPrice, decimal salePrice, Int32 quantity, String status

            doom.addGame();

            MessageBox.Show(doom.toString() + " added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitle.Clear();
            txtDeveloper.Clear();
            txtPublisher.Clear();
            txtBuyPrice.Clear();
            txtBuyPrice.Text = "0.00";
            txtSalePrice.Clear();
            txtSalePrice.Text = "0.00";
            txtTitle.Focus();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
