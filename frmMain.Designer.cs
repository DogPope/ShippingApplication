
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
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCancelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceReceiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearlyStockAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.munProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // munProgram
            // 
            this.munProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.adminFeaturesToolStripMenuItem});
            this.munProgram.Location = new System.Drawing.Point(0, 0);
            this.munProgram.Name = "munProgram";
            this.munProgram.Size = new System.Drawing.Size(1184, 24);
            this.munProgram.TabIndex = 0;
            this.munProgram.Text = "mnuProgram";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerCustomerToolStripMenuItem,
            this.updateDeleteToolStripMenuItem,
            this.viewDetailsToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // registerCustomerToolStripMenuItem
            // 
            this.registerCustomerToolStripMenuItem.Name = "registerCustomerToolStripMenuItem";
            this.registerCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerCustomerToolStripMenuItem.Text = "Register Customer";
            this.registerCustomerToolStripMenuItem.Click += new System.EventHandler(this.registerCustomerToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem
            // 
            this.updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            this.updateDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateDeleteToolStripMenuItem.Text = "Update / Delete";
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerGameToolStripMenuItem,
            this.updateDeleteToolStripMenuItem1,
            this.viewDetailsToolStripMenuItem1});
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // registerGameToolStripMenuItem
            // 
            this.registerGameToolStripMenuItem.Name = "registerGameToolStripMenuItem";
            this.registerGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerGameToolStripMenuItem.Text = "Register Game";
            // 
            // updateDeleteToolStripMenuItem1
            // 
            this.updateDeleteToolStripMenuItem1.Name = "updateDeleteToolStripMenuItem1";
            this.updateDeleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.updateDeleteToolStripMenuItem1.Text = "Update / Delete";
            // 
            // viewDetailsToolStripMenuItem1
            // 
            this.viewDetailsToolStripMenuItem1.Name = "viewDetailsToolStripMenuItem1";
            this.viewDetailsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.viewDetailsToolStripMenuItem1.Text = "View Details";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.updateCancelOrderToolStripMenuItem,
            this.viewOrderToolStripMenuItem,
            this.sendOrderToolStripMenuItem,
            this.invoiceReceiptsToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            // 
            // updateCancelOrderToolStripMenuItem
            // 
            this.updateCancelOrderToolStripMenuItem.Name = "updateCancelOrderToolStripMenuItem";
            this.updateCancelOrderToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.updateCancelOrderToolStripMenuItem.Text = "Update / Cancel Order";
            // 
            // viewOrderToolStripMenuItem
            // 
            this.viewOrderToolStripMenuItem.Name = "viewOrderToolStripMenuItem";
            this.viewOrderToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewOrderToolStripMenuItem.Text = "View Order";
            // 
            // sendOrderToolStripMenuItem
            // 
            this.sendOrderToolStripMenuItem.Name = "sendOrderToolStripMenuItem";
            this.sendOrderToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sendOrderToolStripMenuItem.Text = "Send Order";
            // 
            // invoiceReceiptsToolStripMenuItem
            // 
            this.invoiceReceiptsToolStripMenuItem.Name = "invoiceReceiptsToolStripMenuItem";
            this.invoiceReceiptsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.invoiceReceiptsToolStripMenuItem.Text = "Invoice / Receipts";
            // 
            // adminFeaturesToolStripMenuItem
            // 
            this.adminFeaturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.yearlyStockAnalysisToolStripMenuItem});
            this.adminFeaturesToolStripMenuItem.Name = "adminFeaturesToolStripMenuItem";
            this.adminFeaturesToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.adminFeaturesToolStripMenuItem.Text = "Admin Features";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            // 
            // yearlyStockAnalysisToolStripMenuItem
            // 
            this.yearlyStockAnalysisToolStripMenuItem.Name = "yearlyStockAnalysisToolStripMenuItem";
            this.yearlyStockAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyStockAnalysisToolStripMenuItem.Text = "Yearly Stock Analysis";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1082, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 24);
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
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCancelOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceReceiptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminFeaturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearlyStockAnalysisToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
    }
}

