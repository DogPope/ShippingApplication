using System;
using System.Windows.Forms;

namespace ShippingApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void registerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterCustomer newCustomer = new frmRegisterCustomer(this);
            newCustomer.ShowDialog();
            this.Show();
        }
        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCustomer editCustomer = new frmUpdateCustomer(this);
            editCustomer.ShowDialog();
            this.Show();
        }

        private void registerGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterGame makeGame = new frmRegisterGame(this);
            makeGame.ShowDialog();
            this.Show();
        }

        private void updateDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateGame editGame = new frmUpdateGame(this);
            editGame.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to exit?", "Quitting!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }
    }
}
