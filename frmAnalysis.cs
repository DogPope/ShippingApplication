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
    public partial class frmAnalysis : Form
    {
        frmMain parent;
        public frmAnalysis()
        {
            InitializeComponent();
        }
        public frmAnalysis(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
