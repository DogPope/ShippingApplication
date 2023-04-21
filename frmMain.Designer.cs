
namespace ShippingApplication
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.munProgram = new System.Windows.Forms.MenuStrip();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGames = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlaceOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCancelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceReceiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.munProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // munProgram
            // 
            this.munProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomers,
            this.mnuGames,
            this.mnuOrders,
            this.mnuAdmin});
            this.munProgram.Location = new System.Drawing.Point(0, 0);
            this.munProgram.Name = "munProgram";
            this.munProgram.Size = new System.Drawing.Size(1184, 24);
            this.munProgram.TabIndex = 0;
            this.munProgram.Text = "mnuProgram";
            // 
            // mnuCustomers
            // 
            this.mnuCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterCustomer,
            this.mnuUpdateCustomer});
            this.mnuCustomers.Name = "mnuCustomers";
            this.mnuCustomers.Size = new System.Drawing.Size(76, 20);
            this.mnuCustomers.Text = "Customers";
            // 
            // mnuRegisterCustomer
            // 
            this.mnuRegisterCustomer.Name = "mnuRegisterCustomer";
            this.mnuRegisterCustomer.Size = new System.Drawing.Size(180, 22);
            this.mnuRegisterCustomer.Text = "Register Customer";
            this.mnuRegisterCustomer.Click += new System.EventHandler(this.mnuRegisterCustomer_Click);
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateCustomer.Text = "Update / Delete";
            this.mnuUpdateCustomer.Click += new System.EventHandler(this.mnuCustomerUpdateDelete_Click);
            // 
            // mnuGames
            // 
            this.mnuGames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterGame,
            this.mnuUpdateDelete});
            this.mnuGames.Name = "mnuGames";
            this.mnuGames.Size = new System.Drawing.Size(55, 20);
            this.mnuGames.Text = "Games";
            // 
            // mnuRegisterGame
            // 
            this.mnuRegisterGame.Name = "mnuRegisterGame";
            this.mnuRegisterGame.Size = new System.Drawing.Size(180, 22);
            this.mnuRegisterGame.Text = "Register Game";
            this.mnuRegisterGame.Click += new System.EventHandler(this.mnuRegisterGame_Click);
            // 
            // mnuUpdateDelete
            // 
            this.mnuUpdateDelete.Name = "mnuUpdateDelete";
            this.mnuUpdateDelete.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateDelete.Text = "Update / Delete";
            this.mnuUpdateDelete.Click += new System.EventHandler(this.mnuGameUpdateDelete_Click);
            // 
            // mnuOrders
            // 
            this.mnuOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlaceOrder,
            this.updateCancelOrderToolStripMenuItem,
            this.viewOrderToolStripMenuItem,
            this.invoiceReceiptsToolStripMenuItem});
            this.mnuOrders.Name = "mnuOrders";
            this.mnuOrders.Size = new System.Drawing.Size(54, 20);
            this.mnuOrders.Text = "Orders";
            // 
            // mnuPlaceOrder
            // 
            this.mnuPlaceOrder.Name = "mnuPlaceOrder";
            this.mnuPlaceOrder.Size = new System.Drawing.Size(155, 22);
            this.mnuPlaceOrder.Text = "Place Order";
            this.mnuPlaceOrder.Click += new System.EventHandler(this.mnuPlaceOrder_Click);
            // 
            // updateCancelOrderToolStripMenuItem
            // 
            this.updateCancelOrderToolStripMenuItem.Name = "updateCancelOrderToolStripMenuItem";
            this.updateCancelOrderToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.updateCancelOrderToolStripMenuItem.Text = "Manage Orders";
            this.updateCancelOrderToolStripMenuItem.Click += new System.EventHandler(this.mnuManageOrder_Click);
            // 
            // viewOrderToolStripMenuItem
            // 
            this.viewOrderToolStripMenuItem.Name = "viewOrderToolStripMenuItem";
            this.viewOrderToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.viewOrderToolStripMenuItem.Text = "Ship Orders";
            this.viewOrderToolStripMenuItem.Click += new System.EventHandler(this.mnuShipOrders_Click);
            // 
            // invoiceReceiptsToolStripMenuItem
            // 
            this.invoiceReceiptsToolStripMenuItem.Name = "invoiceReceiptsToolStripMenuItem";
            this.invoiceReceiptsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.invoiceReceiptsToolStripMenuItem.Text = "Issue Receipts";
            this.invoiceReceiptsToolStripMenuItem.Click += new System.EventHandler(this.mnuIssueReceipts_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(102, 20);
            this.mnuAdmin.Text = "Admin Features";
            this.mnuAdmin.Click += new System.EventHandler(this.mnuAdminFeatures_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1082, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 24);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.munProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.munProgram;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.munProgram.ResumeLayout(false);
            this.munProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip munProgram;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuGames;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterGame;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuOrders;
        private System.Windows.Forms.ToolStripMenuItem mnuPlaceOrder;
        private System.Windows.Forms.ToolStripMenuItem updateCancelOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceReceiptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.Button btnExit;
    }
}

