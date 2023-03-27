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
    public partial class frmUpdateGame : Form
    {
        frmMain parent;
        Game updateGame = new Game();
        public frmUpdateGame()
        {
            InitializeComponent();
        }
        public frmUpdateGame(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtGameTitle.Text == "")
            {
                MessageBox.Show("You must enter a title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Text = "";
                txtGameTitle.Focus();
                return;
            }
            String title = txtGameTitle.Text;

            grdGames.DataSource = Game.findGameByTitle(title).Tables["Games"];

            if (grdGames.Rows.Count == 1)
            {
                MessageBox.Show("No game Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Text = "";
                txtGameTitle.Focus();
                return;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grdGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());

            updateGame.getGame(id);
            txtTitle.Text = updateGame.getTitle();
            txtDeveloper.Text = updateGame.getDeveloper();
            txtPublisher.Text = updateGame.getPublisher();
            txtGenre.Text = updateGame.getGenre();
            txtDescription.Text = updateGame.getDescription();
            txtBuyPrice.Text = updateGame.getBuyPrice().ToString("#0.00");
            txtSalePrice.Text = updateGame.getSalePrice().ToString("#0.00");
            txtQuantity.Text = updateGame.getQuantity().ToString();
            txtStatus.Text = updateGame.getStatus();

            grdGames.Visible = true;
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            if (txtGameTitle.Text.Equals(""))
            {
                MessageBox.Show("You must enter a game ID in the ID field to edit a games details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Text = "";
                txtGameTitle.Focus();
                return;
            }
            foreach (char c in txtGameTitle.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("This field only accepts numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGameTitle.Text = "";
                    txtGameTitle.Focus();
                    return;
                }
            }
            //GameId,Title,Developer,Publisher,Genre,Description,BuyPrice,SalePrice,Quantity,Status
            //instantiate the object variables
            updateGame.setTitle(txtTitle.Text);
            updateGame.setDeveloper(txtDeveloper.Text);
            updateGame.setPublisher(txtPublisher.Text);
            updateGame.setGenre(txtGenre.Text);
            updateGame.setDescription(txtDescription.Text);
            updateGame.setBuyPrice(Convert.ToDecimal(txtBuyPrice.Text));
            updateGame.setSalePrice(Convert.ToDecimal(txtSalePrice.Text));
            updateGame.setQuantity(Convert.ToInt32(txtQuantity.Text));
            updateGame.setStatus(txtStatus.Text);

            //update the data in the database
            updateGame.updateGame();

            //Display confirmation message
            MessageBox.Show("Game information updated Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grdGames.Visible = false;
            txtTitle.Clear();
            txtDeveloper.Clear();
            txtPublisher.Clear();
            txtGenre.Clear();
            txtDescription.Clear();
            txtBuyPrice.Clear();
            txtSalePrice.Clear();
            txtQuantity.Clear();
            txtStatus.Clear();
            btnDeregisterGame.Visible = false;
            btnSearch.Visible = false;
            btnUpdateGame.Visible = false;
        }

        private void btnDeregisterGame_Click(object sender, EventArgs e)
        {
            if(txtGameTitle.Text == "")
            {
                MessageBox.Show("You must select a game to deregister or press return to go back to the main menu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Text = "";
                txtGameTitle.Focus();
                return;
            }
            foreach(char c in txtGameTitle.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("This field only accepts numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGameTitle.Text = "";
                    txtGameTitle.Focus();
                    return;
                }
            }
            if(grdGames.RowCount == 1)
            {
                MessageBox.Show("You must select a game to Deregister!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Text = "";
                txtGameTitle.Focus();
                return;
            }
            int id = Convert.ToInt32(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Game deregister = new Game();
            deregister.getGame(id);
            deregister.deregisterGame();
            MessageBox.Show("The Games status has successfully been changed to Deregistered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDeregisterGame.Visible = false;
            btnSearch.Visible = false;
            btnUpdateGame.Visible = false;
        }
    }
}
