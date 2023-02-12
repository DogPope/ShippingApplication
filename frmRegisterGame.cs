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
            Game doom = new Game(txtTitle.Text, txtDeveloper.Text, txtPublisher.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToChar(txtStatus.Text));

            doom.addGame();

            MessageBox.Show(doom.toString() + " added successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitle.Clear();
            txtDeveloper.Clear();
            txtPublisher.Clear();
            txtPrice.Clear();
            txtPrice.Text = "0.00";
            txtTitle.Focus();
            Console.WriteLine(doom.toString());
        }
    }
}
