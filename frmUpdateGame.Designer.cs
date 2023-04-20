
namespace ShippingApplication
{
    partial class frmUpdateGame
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
            this.lblTitleIdentifier = new System.Windows.Forms.Label();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grdGames = new System.Windows.Forms.DataGridView();
            this.GAME_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEVELOPERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bxGameDetails = new System.Windows.Forms.GroupBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bxFinancial = new System.Windows.Forms.GroupBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnUpdateGame = new System.Windows.Forms.Button();
            this.btnDeregisterGame = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdGames)).BeginInit();
            this.bxGameDetails.SuspendLayout();
            this.bxFinancial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleIdentifier
            // 
            this.lblTitleIdentifier.AutoSize = true;
            this.lblTitleIdentifier.Location = new System.Drawing.Point(64, 54);
            this.lblTitleIdentifier.Name = "lblTitleIdentifier";
            this.lblTitleIdentifier.Size = new System.Drawing.Size(58, 13);
            this.lblTitleIdentifier.TabIndex = 0;
            this.lblTitleIdentifier.Text = "Game Title";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(67, 70);
            this.txtGameTitle.MaxLength = 10;
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(100, 20);
            this.txtGameTitle.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(67, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1083, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(101, 24);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grdGames
            // 
            this.grdGames.AutoGenerateColumns = false;
            this.grdGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GAME_ID,
            this.tITLEDataGridViewTextBoxColumn,
            this.dEVELOPERDataGridViewTextBoxColumn,
            this.pUBLISHERDataGridViewTextBoxColumn});
            this.grdGames.Location = new System.Drawing.Point(371, 0);
            this.grdGames.Name = "grdGames";
            this.grdGames.Size = new System.Drawing.Size(443, 244);
            this.grdGames.TabIndex = 27;
            this.grdGames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGames_CellClick);
            // 
            // GAME_ID
            // 
            this.GAME_ID.DataPropertyName = "GAME_ID";
            this.GAME_ID.HeaderText = "GAME_ID";
            this.GAME_ID.Name = "GAME_ID";
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            // 
            // dEVELOPERDataGridViewTextBoxColumn
            // 
            this.dEVELOPERDataGridViewTextBoxColumn.DataPropertyName = "DEVELOPER";
            this.dEVELOPERDataGridViewTextBoxColumn.HeaderText = "DEVELOPER";
            this.dEVELOPERDataGridViewTextBoxColumn.Name = "dEVELOPERDataGridViewTextBoxColumn";
            // 
            // pUBLISHERDataGridViewTextBoxColumn
            // 
            this.pUBLISHERDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHER";
            this.pUBLISHERDataGridViewTextBoxColumn.HeaderText = "PUBLISHER";
            this.pUBLISHERDataGridViewTextBoxColumn.Name = "pUBLISHERDataGridViewTextBoxColumn";
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
            this.bxGameDetails.Location = new System.Drawing.Point(12, 250);
            this.bxGameDetails.Name = "bxGameDetails";
            this.bxGameDetails.Size = new System.Drawing.Size(393, 236);
            this.bxGameDetails.TabIndex = 32;
            this.bxGameDetails.TabStop = false;
            this.bxGameDetails.Text = "Game Details";
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(220, 180);
            this.txtGenre.MaxLength = 20;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(141, 26);
            this.txtGenre.TabIndex = 26;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(217, 162);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 25;
            this.lblGenre.Text = "Genre";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(51, 180);
            this.txtPublisher.MaxLength = 20;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(141, 26);
            this.txtPublisher.TabIndex = 19;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(48, 162);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(74, 20);
            this.lblPublisher.TabIndex = 18;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeveloper.Location = new System.Drawing.Point(220, 54);
            this.txtDeveloper.MaxLength = 20;
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(141, 26);
            this.txtDeveloper.TabIndex = 15;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(217, 36);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(81, 20);
            this.lblDeveloper.TabIndex = 14;
            this.lblDeveloper.Text = "Developer";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(51, 54);
            this.txtTitle.MaxLength = 20;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(141, 26);
            this.txtTitle.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // bxFinancial
            // 
            this.bxFinancial.Controls.Add(this.cboStatus);
            this.bxFinancial.Controls.Add(this.lblCost);
            this.bxFinancial.Controls.Add(this.txtBuyPrice);
            this.bxFinancial.Controls.Add(this.lblStatus);
            this.bxFinancial.Controls.Add(this.txtQuantity);
            this.bxFinancial.Controls.Add(this.lblSalePrice);
            this.bxFinancial.Controls.Add(this.lblQuantity);
            this.bxFinancial.Controls.Add(this.txtSalePrice);
            this.bxFinancial.Location = new System.Drawing.Point(411, 250);
            this.bxFinancial.Name = "bxFinancial";
            this.bxFinancial.Size = new System.Drawing.Size(381, 236);
            this.bxFinancial.TabIndex = 33;
            this.bxFinancial.TabStop = false;
            this.bxFinancial.Text = "Financial Details";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(224, 31);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(97, 20);
            this.lblCost.TabIndex = 16;
            this.lblCost.Text = "Price To Buy";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyPrice.Location = new System.Drawing.Point(228, 54);
            this.txtBuyPrice.MaxLength = 8;
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(141, 26);
            this.txtBuyPrice.TabIndex = 17;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(224, 152);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(58, 175);
            this.txtQuantity.MaxLength = 3;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(141, 26);
            this.txtQuantity.TabIndex = 28;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.Location = new System.Drawing.Point(54, 31);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(96, 20);
            this.lblSalePrice.TabIndex = 23;
            this.lblSalePrice.Text = "Price To Sell";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(56, 152);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 27;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(60, 54);
            this.txtSalePrice.MaxLength = 8;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(141, 26);
            this.txtSalePrice.TabIndex = 24;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(816, 250);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(820, 273);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(339, 213);
            this.txtDescription.TabIndex = 34;
            // 
            // btnUpdateGame
            // 
            this.btnUpdateGame.BackColor = System.Drawing.Color.HotPink;
            this.btnUpdateGame.Location = new System.Drawing.Point(1024, 67);
            this.btnUpdateGame.Name = "btnUpdateGame";
            this.btnUpdateGame.Size = new System.Drawing.Size(160, 23);
            this.btnUpdateGame.TabIndex = 39;
            this.btnUpdateGame.Text = "Update Details";
            this.btnUpdateGame.UseVisualStyleBackColor = false;
            this.btnUpdateGame.Click += new System.EventHandler(this.btnUpdateGame_Click);
            // 
            // btnDeregisterGame
            // 
            this.btnDeregisterGame.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDeregisterGame.Location = new System.Drawing.Point(1024, 154);
            this.btnDeregisterGame.Name = "btnDeregisterGame";
            this.btnDeregisterGame.Size = new System.Drawing.Size(160, 23);
            this.btnDeregisterGame.TabIndex = 41;
            this.btnDeregisterGame.Text = "Deregister Game";
            this.btnDeregisterGame.UseVisualStyleBackColor = false;
            this.btnDeregisterGame.Click += new System.EventHandler(this.btnDeregisterGame_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Registered",
            "Deregistered"});
            this.cboStatus.Location = new System.Drawing.Point(228, 175);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 29;
            // 
            // frmUpdateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnDeregisterGame);
            this.Controls.Add(this.btnUpdateGame);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.bxFinancial);
            this.Controls.Add(this.bxGameDetails);
            this.Controls.Add(this.grdGames);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtGameTitle);
            this.Controls.Add(this.lblTitleIdentifier);
            this.Name = "frmUpdateGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Game";
            ((System.ComponentModel.ISupportInitialize)(this.grdGames)).EndInit();
            this.bxGameDetails.ResumeLayout(false);
            this.bxGameDetails.PerformLayout();
            this.bxFinancial.ResumeLayout(false);
            this.bxFinancial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleIdentifier;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView grdGames;
        private System.Windows.Forms.GroupBox bxGameDetails;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox bxFinancial;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnUpdateGame;
        private System.Windows.Forms.Button btnDeregisterGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn GAME_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEVELOPERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}