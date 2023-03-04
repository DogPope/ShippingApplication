﻿using System;
using System.Windows.Forms;

namespace ShippingApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterCustomer form = new frmRegisterCustomer(this);
            form.ShowDialog();
            this.Show();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need Administrative Priveleges to enter this part of the site. Please enter your Username and Password");
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterGame form = new frmRegisterGame(this);
            form.ShowDialog();
            this.Show();
        }

        private void registerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterCustomer form = new frmRegisterCustomer(this);
            form.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to exit?","Quitting!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }

        private void registerGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterGame makeGame = new frmRegisterGame(this);
            makeGame.ShowDialog();
            this.Show();
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCustomer editCust = new frmUpdateCustomer(this);
            editCust.ShowDialog();
            this.Show();
        }
    }
}
