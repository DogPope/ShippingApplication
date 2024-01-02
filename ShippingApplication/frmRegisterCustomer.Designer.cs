
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.grpAccountDetails = new System.Windows.Forms.GroupBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.grpCustDetails.SuspendLayout();
            this.grpAccountDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCounty
            // 
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cboCounty.MaxDropDownItems = 26;
            this.cboCounty.MaxLength = 9;
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(210, 28);
            this.cboCounty.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(904, 485);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(210, 42);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(16, 16);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(82, 20);
            this.lblForename.TabIndex = 4;
            this.lblForename.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(22, 39);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(141, 26);
            this.txtForename.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(236, 38);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(141, 26);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(231, 16);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(74, 20);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEircode.Location = new System.Drawing.Point(236, 148);
            this.txtEircode.MaxLength = 8;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(141, 26);
            this.txtEircode.TabIndex = 4;
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEircode.Location = new System.Drawing.Point(230, 125);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(79, 20);
            this.lblEircode.TabIndex = 8;
            this.lblEircode.Text = "EIR Code";
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(20, 148);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(141, 26);
            this.txtTown.TabIndex = 3;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(17, 125);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(47, 20);
            this.lblTown.TabIndex = 10;
            this.lblTown.Text = "Town";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(20, 64);
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
            this.lblPassword.Location = new System.Drawing.Point(16, 41);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(235, 64);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(231, 41);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(116, 20);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-mail Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(20, 166);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(141, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(16, 143);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(115, 20);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtCardnumber
            // 
            this.txtCardnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardnumber.Location = new System.Drawing.Point(235, 166);
            this.txtCardnumber.MaxLength = 20;
            this.txtCardnumber.Name = "txtCardnumber";
            this.txtCardnumber.Size = new System.Drawing.Size(141, 26);
            this.txtCardnumber.TabIndex = 8;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.Location = new System.Drawing.Point(231, 143);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(149, 20);
            this.lblCard.TabIndex = 18;
            this.lblCard.Text = "Credit Card Number";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1082, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(101, 24);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.lblSurname);
            this.grpCustDetails.Controls.Add(this.lblForename);
            this.grpCustDetails.Controls.Add(this.txtForename);
            this.grpCustDetails.Controls.Add(this.txtSurname);
            this.grpCustDetails.Controls.Add(this.lblEircode);
            this.grpCustDetails.Controls.Add(this.txtEircode);
            this.grpCustDetails.Controls.Add(this.lblTown);
            this.grpCustDetails.Controls.Add(this.txtTown);
            this.grpCustDetails.Location = new System.Drawing.Point(282, 53);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Size = new System.Drawing.Size(418, 205);
            this.grpCustDetails.TabIndex = 28;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Personal Details";
            // 
            // grpAccountDetails
            // 
            this.grpAccountDetails.Controls.Add(this.lblPassword);
            this.grpAccountDetails.Controls.Add(this.txtPassword);
            this.grpAccountDetails.Controls.Add(this.lblEmail);
            this.grpAccountDetails.Controls.Add(this.txtEmail);
            this.grpAccountDetails.Controls.Add(this.lblPhone);
            this.grpAccountDetails.Controls.Add(this.txtPhone);
            this.grpAccountDetails.Controls.Add(this.lblCard);
            this.grpAccountDetails.Controls.Add(this.txtCardnumber);
            this.grpAccountDetails.Location = new System.Drawing.Point(282, 315);
            this.grpAccountDetails.Name = "grpAccountDetails";
            this.grpAccountDetails.Size = new System.Drawing.Size(418, 231);
            this.grpAccountDetails.TabIndex = 29;
            this.grpAccountDetails.TabStop = false;
            this.grpAccountDetails.Text = "Account Details";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCounty.Location = new System.Drawing.Point(900, 66);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(59, 20);
            this.lblCounty.TabIndex = 30;
            this.lblCounty.Text = "County";
            // 
            // frmRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.grpAccountDetails);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboCounty);
            this.Name = "frmRegisterCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Customers";
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            this.grpAccountDetails.ResumeLayout(false);
            this.grpAccountDetails.PerformLayout();
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
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.GroupBox grpAccountDetails;
        private System.Windows.Forms.Label lblCounty;
    }
}