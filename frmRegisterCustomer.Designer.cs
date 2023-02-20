
namespace ShippingApplication
{
    partial class frmRegisterCustomer
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
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCardnumber = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.labelCustId = new System.Windows.Forms.Label();
            this.munProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCounty
            // 
            this.cboCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Donegal",
            "Dublin",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cboCounty.Location = new System.Drawing.Point(904, 89);
            this.cboCounty.MaxDropDownItems = 32;
            this.cboCounty.MaxLength = 30;
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(210, 28);
            this.cboCounty.TabIndex = 9;
            this.cboCounty.Text = "County";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(904, 485);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(210, 42);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(515, 73);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(82, 20);
            this.lblForename.TabIndex = 4;
            this.lblForename.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(518, 91);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(141, 26);
            this.txtForename.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(303, 91);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(141, 26);
            this.txtSurname.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(300, 73);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(74, 20);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(518, 201);
            this.txtEircode.MaxLength = 8;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(141, 26);
            this.txtEircode.TabIndex = 4;
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(515, 183);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(79, 20);
            this.lblEircode.TabIndex = 8;
            this.lblEircode.Text = "EIR Code";
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(302, 201);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(141, 26);
            this.txtTown.TabIndex = 3;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(299, 183);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(47, 20);
            this.lblTown.TabIndex = 10;
            this.lblTown.Text = "Town";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(303, 301);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(141, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(300, 283);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(518, 301);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(515, 283);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(116, 20);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-mail Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(303, 390);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(141, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(300, 372);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(115, 20);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtCardnumber
            // 
            this.txtCardnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardnumber.Location = new System.Drawing.Point(518, 390);
            this.txtCardnumber.MaxLength = 20;
            this.txtCardnumber.Name = "txtCardnumber";
            this.txtCardnumber.Size = new System.Drawing.Size(141, 26);
            this.txtCardnumber.TabIndex = 8;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.Location = new System.Drawing.Point(515, 372);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(149, 20);
            this.lblCard.TabIndex = 18;
            this.lblCard.Text = "Credit Card Number";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(918, 201);
            this.txtStatus.MaxLength = 20;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(141, 26);
            this.txtStatus.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(915, 183);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status";
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
            this.munProgram.TabIndex = 23;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1082, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtCustId
            // 
            this.txtCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(40, 91);
            this.txtCustId.MaxLength = 5;
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(141, 26);
            this.txtCustId.TabIndex = 26;
            // 
            // labelCustId
            // 
            this.labelCustId.AutoSize = true;
            this.labelCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustId.Location = new System.Drawing.Point(37, 73);
            this.labelCustId.Name = "labelCustId";
            this.labelCustId.Size = new System.Drawing.Size(99, 20);
            this.labelCustId.TabIndex = 27;
            this.labelCustId.Text = "Customer ID";
            // 
            // frmRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.labelCustId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.munProgram);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCardnumber);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.txtEircode);
            this.Controls.Add(this.lblEircode);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboCounty);
            this.Name = "frmRegisterCustomer";
            this.Text = "Manage Customers";
            this.munProgram.ResumeLayout(false);
            this.munProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCardnumber;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label labelCustId;
    }
}