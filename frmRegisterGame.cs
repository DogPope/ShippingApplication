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

        public frmRegisterGame(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validation for fields required here. Genre and Description are nullable.
            if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("You must enter a game title to continue!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtTitle.Focus();
                txtTitle.Text = "";
                return;
            }

            if (txtDeveloper.Text.Equals(""))
            {
                MessageBox.Show("You must enter a Developer to continue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeveloper.Focus();
                txtDeveloper.Text = "";
                return;
            }

            if (txtPublisher.Text.Equals(""))
            {
                MessageBox.Show("You must enter a Publisher to continue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisher.Focus();
                txtPublisher.Text = "";
                return;
            }

            if (txtBuyPrice.Text.Equals(""))
            {
                MessageBox.Show("You must enter the cost to buy a game from the supplier!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuyPrice.Focus();
                txtBuyPrice.Text = "";
                return;
            }
            foreach (Char c in txtBuyPrice.Text)
            {
                if (!Char.IsNumber(c) && c != '.')
                {
                    MessageBox.Show("You must enter a valid decimal number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBuyPrice.Focus();
                    txtBuyPrice.Text = "";
                    return;
                }
            }

            if (txtSalePrice.Text.Equals(""))
            {
                MessageBox.Show("You must enter the cost to buy a game as a customer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalePrice.Focus();
                txtSalePrice.Text = "";
                return;
            }
            foreach(Char c in txtSalePrice.Text)
            {
                if (!Char.IsNumber(c) && c != '.')
                {
                    MessageBox.Show("You must enter a valid decimal number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalePrice.Focus();
                    txtSalePrice.Text = "";
                    return;
                }
            }

            if (txtQuantity.Text.Equals(""))
            {
                MessageBox.Show("You must enter a quantity of games to continue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                txtQuantity.Text = "";
                return;
            }
            foreach (char c in txtQuantity.Text)
            {
                if (!char.IsNumber(c))
                {
                    MessageBox.Show("The quantity of games must be numeric!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Focus();
                    txtQuantity.Text = "";
                    return;
                }
            }

            //Creates a game object to add to the database.
            Game newGame = new Game(Game.getNextGameID(), txtTitle.Text, txtDeveloper.Text, txtPublisher.Text, txtGenre.Text, txtDescription.Text,
                                 Convert.ToDecimal(txtBuyPrice.Text), Convert.ToDecimal(txtSalePrice.Text), Convert.ToInt32(txtQuantity.Text));

            // Calls method to add object to the database.
            newGame.addGame();

            // Verifies creation of object to the user.
            MessageBox.Show(newGame.toString() + " added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Resets user interface.
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
