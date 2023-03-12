
namespace ShippingApplication
{
    partial class frmPlaceOrder
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
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.lblCustId = new System.Windows.Forms.Label();
            this.grdGames = new System.Windows.Forms.DataGridView();
            this.gAMEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEVELOPERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUYPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALEPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ShippingApplication.DataSet1();
            this.gAMESTableAdapter = new ShippingApplication.DataSet1TableAdapters.GAMESTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oRDERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ShippingApplication.DataSet2();
            this.oRDERSTableAdapter = new ShippingApplication.DataSet2TableAdapters.ORDERSTableAdapter();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
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
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(62, 62);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(100, 20);
            this.txtCustId.TabIndex = 28;
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(59, 46);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(65, 13);
            this.lblCustId.TabIndex = 29;
            this.lblCustId.Text = "Customer ID";
            // 
            // grdGames
            // 
            this.grdGames.AutoGenerateColumns = false;
            this.grdGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gAMEIDDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.dEVELOPERDataGridViewTextBoxColumn,
            this.pUBLISHERDataGridViewTextBoxColumn,
            this.gENREDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.bUYPRICEDataGridViewTextBoxColumn,
            this.sALEPRICEDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn});
            this.grdGames.DataSource = this.gAMESBindingSource;
            this.grdGames.Location = new System.Drawing.Point(62, 123);
            this.grdGames.Name = "grdGames";
            this.grdGames.Size = new System.Drawing.Size(1043, 179);
            this.grdGames.TabIndex = 31;
            this.grdGames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGames_CellClick);
            // 
            // gAMEIDDataGridViewTextBoxColumn
            // 
            this.gAMEIDDataGridViewTextBoxColumn.DataPropertyName = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.HeaderText = "GAME_ID";
            this.gAMEIDDataGridViewTextBoxColumn.Name = "gAMEIDDataGridViewTextBoxColumn";
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
            // gENREDataGridViewTextBoxColumn
            // 
            this.gENREDataGridViewTextBoxColumn.DataPropertyName = "GENRE";
            this.gENREDataGridViewTextBoxColumn.HeaderText = "GENRE";
            this.gENREDataGridViewTextBoxColumn.Name = "gENREDataGridViewTextBoxColumn";
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // bUYPRICEDataGridViewTextBoxColumn
            // 
            this.bUYPRICEDataGridViewTextBoxColumn.DataPropertyName = "BUYPRICE";
            this.bUYPRICEDataGridViewTextBoxColumn.HeaderText = "BUYPRICE";
            this.bUYPRICEDataGridViewTextBoxColumn.Name = "bUYPRICEDataGridViewTextBoxColumn";
            // 
            // sALEPRICEDataGridViewTextBoxColumn
            // 
            this.sALEPRICEDataGridViewTextBoxColumn.DataPropertyName = "SALEPRICE";
            this.sALEPRICEDataGridViewTextBoxColumn.HeaderText = "SALEPRICE";
            this.sALEPRICEDataGridViewTextBoxColumn.Name = "sALEPRICEDataGridViewTextBoxColumn";
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            // 
            // gAMESBindingSource
            // 
            this.gAMESBindingSource.DataMember = "GAMES";
            this.gAMESBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gAMESTableAdapter
            // 
            this.gAMESTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDERIDDataGridViewTextBoxColumn,
            this.oRDERDATEDataGridViewTextBoxColumn,
            this.cOSTDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn1,
            this.cUSTIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oRDERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 69);
            this.dataGridView1.TabIndex = 32;
            // 
            // oRDERIDDataGridViewTextBoxColumn
            // 
            this.oRDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn.HeaderText = "ORDER_ID";
            this.oRDERIDDataGridViewTextBoxColumn.Name = "oRDERIDDataGridViewTextBoxColumn";
            // 
            // oRDERDATEDataGridViewTextBoxColumn
            // 
            this.oRDERDATEDataGridViewTextBoxColumn.DataPropertyName = "ORDER_DATE";
            this.oRDERDATEDataGridViewTextBoxColumn.HeaderText = "ORDER_DATE";
            this.oRDERDATEDataGridViewTextBoxColumn.Name = "oRDERDATEDataGridViewTextBoxColumn";
            // 
            // cOSTDataGridViewTextBoxColumn
            // 
            this.cOSTDataGridViewTextBoxColumn.DataPropertyName = "COST";
            this.cOSTDataGridViewTextBoxColumn.HeaderText = "COST";
            this.cOSTDataGridViewTextBoxColumn.Name = "cOSTDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewTextBoxColumn1
            // 
            this.sTATUSDataGridViewTextBoxColumn1.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn1.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn1.Name = "sTATUSDataGridViewTextBoxColumn1";
            // 
            // cUSTIDDataGridViewTextBoxColumn
            // 
            this.cUSTIDDataGridViewTextBoxColumn.DataPropertyName = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.HeaderText = "CUST_ID";
            this.cUSTIDDataGridViewTextBoxColumn.Name = "cUSTIDDataGridViewTextBoxColumn";
            // 
            // oRDERSBindingSource
            // 
            this.oRDERSBindingSource.DataMember = "ORDERS";
            this.oRDERSBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDERSTableAdapter
            // 
            this.oRDERSTableAdapter.ClearBeforeFill = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.HotPink;
            this.btnPlaceOrder.Location = new System.Drawing.Point(884, 495);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(221, 23);
            this.btnPlaceOrder.TabIndex = 33;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grdGames);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmPlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.frmManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.DataGridView grdGames;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gAMESBindingSource;
        private DataSet1TableAdapters.GAMESTableAdapter gAMESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAMEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEVELOPERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUYPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALEPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource oRDERSBindingSource;
        private DataSet2TableAdapters.ORDERSTableAdapter oRDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}