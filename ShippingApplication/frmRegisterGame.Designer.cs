
namespace ShippingApplication
{
    partial class frmRegisterGame
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
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.bxGameDetails = new System.Windows.Forms.GroupBox();
            this.bxFinancial = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.bxGameDetails.SuspendLayout();
            this.bxFinancial.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(75, 180);
            this.txtPublisher.MaxLength = 20;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(141, 26);
            this.txtPublisher.TabIndex = 3;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(72, 162);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(74, 20);
            this.lblPublisher.TabIndex = 18;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyPrice.Location = new System.Drawing.Point(74, 180);
            this.txtBuyPrice.MaxLength = 6;
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(141, 26);
            this.txtBuyPrice.TabIndex = 7;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(70, 157);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(97, 20);
            this.lblCost.TabIndex = 16;
            this.lblCost.Text = "Price To Buy";
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeveloper.Location = new System.Drawing.Point(291, 68);
            this.txtDeveloper.MaxLength = 20;
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(141, 26);
            this.txtDeveloper.TabIndex = 2;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(288, 50);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(81, 20);
            this.lblDeveloper.TabIndex = 14;
            this.lblDeveloper.Text = "Developer";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(75, 68);
            this.txtTitle.MaxLength = 20;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(141, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(72, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(838, 415);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(210, 42);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(289, 66);
            this.txtSalePrice.MaxLength = 6;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(141, 26);
            this.txtSalePrice.TabIndex = 6;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.Location = new System.Drawing.Point(286, 43);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(96, 20);
            this.lblSalePrice.TabIndex = 23;
            this.lblSalePrice.Text = "Price To Sell";
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(290, 180);
            this.txtGenre.MaxLength = 20;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(141, 26);
            this.txtGenre.TabIndex = 4;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(287, 162);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 25;
            this.lblGenre.Text = "Genre";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(289, 180);
            this.txtQuantity.MaxLength = 3;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(141, 26);
            this.txtQuantity.TabIndex = 8;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(287, 157);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 27;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(772, 114);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(339, 138);
            this.txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(768, 91);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = "Description";
            // 
            // bxGameDetails
            // 
            this.bxGameDetails.Controls.Add(this.txtGenre);
            this.bxGameDetails.Controls.Add(this.lblGenre);
            this.bxGameDetails.Controls.Add(this.txtPublisher);
            this.bxGameDetails.Controls.Add(this.lblPublisher);
            this.bxGameDetails.Controls.Add(this.txtDeveloper);
            this.bxGameDetails.Controls.Add(this.lblDeveloper);
            this.bxGameDetails.Controls.Add(this.txtTitle);
            this.bxGameDetails.Controls.Add(this.lblTitle);
            this.bxGameDetails.Location = new System.Drawing.Point(234, 46);
            this.bxGameDetails.Name = "bxGameDetails";
            this.bxGameDetails.Size = new System.Drawing.Size(474, 236);
            this.bxGameDetails.TabIndex = 31;
            this.bxGameDetails.TabStop = false;
            this.bxGameDetails.Text = "Game Details";
            // 
            // bxFinancial
            // 
            this.bxFinancial.Controls.Add(this.lblCost);
            this.bxFinancial.Controls.Add(this.txtBuyPrice);
            this.bxFinancial.Controls.Add(this.txtQuantity);
            this.bxFinancial.Controls.Add(this.lblSalePrice);
            this.bxFinancial.Controls.Add(this.lblQuantity);
            this.bxFinancial.Controls.Add(this.txtSalePrice);
            this.bxFinancial.Location = new System.Drawing.Point(234, 327);
            this.bxFinancial.Name = "bxFinancial";
            this.bxFinancial.Size = new System.Drawing.Size(474, 255);
            this.bxFinancial.TabIndex = 32;
            this.bxFinancial.TabStop = false;
            this.bxFinancial.Text = "Financial Details";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1083, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(101, 24);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmRegisterGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.bxFinancial);
            this.Controls.Add(this.bxGameDetails);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnRegister);
            this.Name = "frmRegisterGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegisterGame";
            this.bxGameDetails.ResumeLayout(false);
            this.bxGameDetails.PerformLayout();
            this.bxFinancial.ResumeLayout(false);
            this.bxFinancial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox bxGameDetails;
        private System.Windows.Forms.GroupBox bxFinancial;
        private System.Windows.Forms.Button btnReturn;
    }
}