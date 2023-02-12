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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterCustomer form = new frmRegisterCustomer();
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
            frmRegisterGame form = new frmRegisterGame();
            form.ShowDialog();
            this.Show();
        }
    }
}
