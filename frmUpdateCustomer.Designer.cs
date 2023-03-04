
namespace ShippingApplication
{
    partial class frmUpdateCustomer
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
            this.components = new System.ComponentModel.Container();
            this.btnReturn = new System.Windows.Forms.Button();
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
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.cUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOWNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIRCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARDNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUNTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custDataSet = new ShippingApplication.CustDataSet();
            this.cUSTOMERSTableAdapter = new ShippingApplication.CustDataSetTableAdapters.CUSTOMERSTableAdapter();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.lblCustId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.munProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1083, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(101, 24);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.munProgram.TabIndex = 26;
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
            this.registerCustomerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.registerCustomerToolStripMenuItem.Text = "Register Customer";
            // 
            // updateDeleteToolStripMenuItem
            // 
            this.updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            this.updateDeleteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.updateDeleteToolStripMenuItem.Text = "Update / Delete";
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
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
            this.registerGameToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.registerGameToolStripMenuItem.Text = "Register Game";
            // 
            // updateDeleteToolStripMenuItem1
            // 
            this.updateDeleteToolStripMenuItem1.Name = "updateDeleteToolStripMenuItem1";
            this.updateDeleteToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.updateDeleteToolStripMenuItem1.Text = "Update / Delete";
            // 
            // viewDetailsToolStripMenuItem1
            // 
            this.viewDetailsToolStripMenuItem1.Name = "viewDetailsToolStripMenuItem1";
            this.viewDetailsToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
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
            // grdCustomers
            // 
            this.grdCustomers.AutoGenerateColumns = false;
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTIDDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.fORENAMEDataGridViewTextBoxColumn,
            this.tOWNDataGridViewTextBoxColumn,
            this.eIRCODEDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.cARDNUMBERDataGridViewTextBoxColumn,
            this.cOUNTYDataGridViewTextBoxColumn});
            this.grdCustomers.DataSource = this.cUSTOMERSBindingSource;
            this.grdCustomers.Location = new System.Drawing.Point(0, 97);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(1044, 68);
            this.grdCustomers.TabIndex = 28;
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            // 
            // fORENAMEDataGridViewTextBoxColumn
            // 
            this.fORENAMEDataGridViewTextBoxColumn.DataPropertyName = "FORENAME";
            this.fORENAMEDataGridViewTextBoxColumn.HeaderText = "FORENAME";
            this.fORENAMEDataGridViewTextBoxColumn.Name = "fORENAMEDataGridViewTextBoxColumn";
            // 
            // tOWNDataGridViewTextBoxColumn
            // 
            this.tOWNDataGridViewTextBoxColumn.DataPropertyName = "TOWN";
            this.tOWNDataGridViewTextBoxColumn.HeaderText = "TOWN";
            this.tOWNDataGridViewTextBoxColumn.Name = "tOWNDataGridViewTextBoxColumn";
            // 
            // eIRCODEDataGridViewTextBoxColumn
            // 
            this.eIRCODEDataGridViewTextBoxColumn.DataPropertyName = "EIRCODE";
            this.eIRCODEDataGridViewTextBoxColumn.HeaderText = "EIRCODE";
            this.eIRCODEDataGridViewTextBoxColumn.Name = "eIRCODEDataGridViewTextBoxColumn";
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // cARDNUMBERDataGridViewTextBoxColumn
            // 
            this.cARDNUMBERDataGridViewTextBoxColumn.DataPropertyName = "CARDNUMBER";
            this.cARDNUMBERDataGridViewTextBoxColumn.HeaderText = "CARDNUMBER";
            this.cARDNUMBERDataGridViewTextBoxColumn.Name = "cARDNUMBERDataGridViewTextBoxColumn";
            // 
            // cOUNTYDataGridViewTextBoxColumn
            // 
            this.cOUNTYDataGridViewTextBoxColumn.DataPropertyName = "COUNTY";
            this.cOUNTYDataGridViewTextBoxColumn.HeaderText = "COUNTY";
            this.cOUNTYDataGridViewTextBoxColumn.Name = "cOUNTYDataGridViewTextBoxColumn";
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.custDataSet;
            // 
            // custDataSet
            // 
            this.custDataSet.DataSetName = "CustDataSet";
            this.custDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERSTableAdapter
            // 
            this.cUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(43, 52);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(100, 20);
            this.txtCustId.TabIndex = 29;
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(40, 36);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(58, 13);
            this.lblCustId.TabIndex = 30;
            this.lblCustId.Text = "ID Number";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(193, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.munProgram);
            this.Name = "frmUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.munProgram.ResumeLayout(false);
            this.munProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
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
        private System.Windows.Forms.DataGridView grdCustomers;
        private CustDataSet custDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private CustDataSetTableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fORENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOWNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIRCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARDNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUNTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Button btnSearch;
    }
}