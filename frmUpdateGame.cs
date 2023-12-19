using System;
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
            // Validate given game data.
            if (txtGameTitle.Text == "")
            {
                MessageBox.Show("You must enter a title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Text = "";
                txtGameTitle.Focus();
                return;
            }
            String title = txtGameTitle.Text;

            // Returns the game data based on the title provided.
            grdGames.DataSource = Game.findGameByTitle(title).Tables["Games"];

            // If no data is returned, inform the customer then return.
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
            // Retrieve the game ID from the grid.
            int id = Convert.ToInt32(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());

            // Set the text fields to the data from the query.
            updateGame.getGame(id);
            txtTitle.Text = updateGame.getTitle();
            txtDeveloper.Text = updateGame.getDeveloper();
            txtPublisher.Text = updateGame.getPublisher();
            txtGenre.Text = updateGame.getGenre();
            txtDescription.Text = updateGame.getDescription();
            txtBuyPrice.Text = updateGame.getBuyPrice().ToString("#0.00");
            txtSalePrice.Text = updateGame.getSalePrice().ToString("#0.00");
            txtQuantity.Text = updateGame.getQuantity().ToString();
            cboStatus.Text = Convert.ToString(updateGame.getStatus());

            // Sets the grid of games to visible.
            grdGames.Visible = true;
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            // Validates given fields
            if (txtGameTitle.Text.Equals(""))
            {
                MessageBox.Show("You must enter a title in the title field to edit a games details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Text = "";
                txtGameTitle.Focus();
                return;
            }
            if (txtDeveloper.Text.Equals(""))
            {
                MessageBox.Show("You must enter a developer in the developer field to edit a games details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeveloper.Text = "";
                txtDeveloper.Focus();
                return;
            }
            if (txtPublisher.Text.Equals(""))
            {
                MessageBox.Show("You must enter a game ID in the ID field to edit a games details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublisher.Text = "";
                txtPublisher.Focus();
                return;
            }
            if (txtBuyPrice.Text.Equals(""))
            {
                MessageBox.Show("You must enter a price to buy from the distributor!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuyPrice.Text = "";
                txtBuyPrice.Focus();
                return;
            }
            foreach (Char c in txtBuyPrice.Text)
            {
                if (!Char.IsNumber(c) && c != '.')
                {
                    MessageBox.Show("You must enter a valid decimal number for the Buying price!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBuyPrice.Focus();
                    txtBuyPrice.Text = "";
                    return;
                }
            }
            if (txtSalePrice.Text.Equals(""))
            {
                MessageBox.Show("You must enter a price in the Sale Price field to edit a games details!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalePrice.Text = "";
                txtSalePrice.Focus();
                return;
            }
            foreach (Char c in txtSalePrice.Text)
            {
                if (!Char.IsNumber(c) && c != '.')
                {
                    MessageBox.Show("You must enter a valid decimal number for the sale price!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSalePrice.Focus();
                    txtSalePrice.Text = "";
                    return;
                }
            }
            if (txtQuantity.Text.Equals(""))
            {
                MessageBox.Show("You must enter a quantity of games in stock!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Text = "";
                txtQuantity.Focus();
                return;
            }
            if (cboStatus.Text.Equals(""))
            {
                MessageBox.Show("You must enter status for the game in question!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return;
            }

            // Instantiate the object variables based on the information given.
            updateGame.setTitle(txtTitle.Text);
            updateGame.setDeveloper(txtDeveloper.Text);
            updateGame.setPublisher(txtPublisher.Text);
            updateGame.setGenre(txtGenre.Text);
            updateGame.setDescription(txtDescription.Text);
            updateGame.setBuyPrice(Convert.ToDecimal(txtBuyPrice.Text));
            updateGame.setSalePrice(Convert.ToDecimal(txtSalePrice.Text));
            updateGame.setQuantity(Convert.ToInt32(txtQuantity.Text));
            //updateGame.setStatus(cboStatus.Text);

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
            cboStatus.SelectedIndex = -1;
            btnDeregisterGame.Visible = false;
            btnSearch.Visible = false;
            btnUpdateGame.Visible = false;
        }

        private void btnDeregisterGame_Click(object sender, EventArgs e)
        {
            // Validate title field.
            if (txtGameTitle.Text == "")
            {
                MessageBox.Show("You must select a game to deregister or press return to go back to the main menu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Text = "";
                txtGameTitle.Focus();
                return;
            }

            // If no data is returned.
            if (grdGames.RowCount == 1)
            {
                MessageBox.Show("You must select a game to Deregister!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGameTitle.Text = "";
                txtGameTitle.Focus();
                return;
            }

            // Get game ID from the data grid view.
            int id = Convert.ToInt32(grdGames.Rows[grdGames.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Game deregister = new Game();
            deregister.getGame(id);

            // Deregister the selected Game.
            deregister.deregisterGame();
            MessageBox.Show("The Games status has successfully been changed to Deregistered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Sets game management buttons to invisible.
            btnDeregisterGame.Visible = false;
            btnSearch.Visible = false;
            btnUpdateGame.Visible = false;

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
            cboStatus.SelectedIndex = -1;
        }
    }
}
