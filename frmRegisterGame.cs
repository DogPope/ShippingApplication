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
        public frmRegisterGame()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Game doom = new Game(Game.getNextGameID(), txtTitle.Text, txtDeveloper.Text, txtPublisher.Text, txtDescription.Text, txtGenre.Text, Convert.ToInt32(txtQuantity.Text),
                Convert.ToDecimal(txtBuyPrice.Text) + Convert.ToDecimal(txtSalePrice.Text), txtStatus.Text);

            MessageBox.Show(doom.toString() + " added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            doom.addGame();

            txtTitle.Clear();
            txtDeveloper.Clear();
            txtPublisher.Clear();
            txtBuyPrice.Clear();
            txtBuyPrice.Text = "0.00";
            txtSalePrice.Clear();
            txtSalePrice.Text = "0.00";
            txtTitle.Focus();
            //Console.WriteLine(doom.toString());
        }
    }
}
