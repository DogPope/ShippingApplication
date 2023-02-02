
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
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtbxForename = new System.Windows.Forms.TextBox();
            this.txtbxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtbxEircode = new System.Windows.Forms.TextBox();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtbxTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtbxCardnumber = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAnalysis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalysis.Location = new System.Drawing.Point(0, 290);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(200, 50);
            this.btnAnalysis.TabIndex = 4;
            this.btnAnalysis.Text = "System Analysis";
            this.btnAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalysis.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.Location = new System.Drawing.Point(0, 240);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 50);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Manage Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGames.Location = new System.Drawing.Point(0, 190);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(200, 50);
            this.btnGames.TabIndex = 2;
            this.btnGames.Text = "Manage Games";
            this.btnGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGames.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.Location = new System.Drawing.Point(0, 140);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 50);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // pnlImage
            // 
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(200, 140);
            this.pnlImage.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(213)))));
            this.pnlMenu.Controls.Add(this.btnAnalysis);
            this.pnlMenu.Controls.Add(this.btnOrders);
            this.pnlMenu.Controls.Add(this.btnGames);
            this.pnlMenu.Controls.Add(this.btnReturn);
            this.pnlMenu.Controls.Add(this.pnlImage);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 611);
            this.pnlMenu.TabIndex = 1;
            // 
            // cboCounty
            // 
            this.cboCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
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
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cboCounty.Location = new System.Drawing.Point(904, 89);
            this.cboCounty.MaxDropDownItems = 32;
            this.cboCounty.MaxLength = 30;
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(210, 28);
            this.cboCounty.TabIndex = 2;
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
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(299, 71);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(82, 20);
            this.lblForename.TabIndex = 4;
            this.lblForename.Text = "Forename";
            // 
            // txtbxForename
            // 
            this.txtbxForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxForename.Location = new System.Drawing.Point(302, 89);
            this.txtbxForename.Name = "txtbxForename";
            this.txtbxForename.Size = new System.Drawing.Size(141, 26);
            this.txtbxForename.TabIndex = 5;
            // 
            // txtbxSurname
            // 
            this.txtbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSurname.Location = new System.Drawing.Point(518, 89);
            this.txtbxSurname.Name = "txtbxSurname";
            this.txtbxSurname.Size = new System.Drawing.Size(141, 26);
            this.txtbxSurname.TabIndex = 7;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(515, 71);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(74, 20);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // txtbxEircode
            // 
            this.txtbxEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEircode.Location = new System.Drawing.Point(518, 201);
            this.txtbxEircode.Name = "txtbxEircode";
            this.txtbxEircode.Size = new System.Drawing.Size(141, 26);
            this.txtbxEircode.TabIndex = 9;
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
            // txtbxTown
            // 
            this.txtbxTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTown.Location = new System.Drawing.Point(302, 201);
            this.txtbxTown.Name = "txtbxTown";
            this.txtbxTown.Size = new System.Drawing.Size(141, 26);
            this.txtbxTown.TabIndex = 11;
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
            // txtbxPassword
            // 
            this.txtbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPassword.Location = new System.Drawing.Point(303, 301);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(141, 26);
            this.txtbxPassword.TabIndex = 13;
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
            // txtbxEmail
            // 
            this.txtbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxEmail.Location = new System.Drawing.Point(518, 301);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(141, 26);
            this.txtbxEmail.TabIndex = 15;
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
            // txtbxPhone
            // 
            this.txtbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPhone.Location = new System.Drawing.Point(303, 390);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(141, 26);
            this.txtbxPhone.TabIndex = 17;
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
            // txtbxCardnumber
            // 
            this.txtbxCardnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCardnumber.Location = new System.Drawing.Point(518, 390);
            this.txtbxCardnumber.Name = "txtbxCardnumber";
            this.txtbxCardnumber.Size = new System.Drawing.Size(141, 26);
            this.txtbxCardnumber.TabIndex = 19;
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
            // frmRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.txtbxCardnumber);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.txtbxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbxTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.txtbxEircode);
            this.Controls.Add(this.lblEircode);
            this.Controls.Add(this.txtbxSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtbxForename);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboCounty);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmRegisterCustomer";
            this.Text = "Manage Customers";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtbxForename;
        private System.Windows.Forms.TextBox txtbxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtbxEircode;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtbxTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtbxCardnumber;
        private System.Windows.Forms.Label lblCard;
    }
}