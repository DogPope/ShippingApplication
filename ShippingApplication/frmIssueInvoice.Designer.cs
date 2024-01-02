
namespace ShippingApplication
{
    partial class frmIssueInvoice
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.grdReceipts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1084, -1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(101, 24);
            this.btnReturn.TabIndex = 55;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grdOrders
            // 
            this.grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrders.Location = new System.Drawing.Point(12, 12);
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(1066, 191);
            this.grdOrders.TabIndex = 56;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellClick);
            // 
            // grdReceipts
            // 
            this.grdReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReceipts.Location = new System.Drawing.Point(12, 349);
            this.grdReceipts.Name = "grdReceipts";
            this.grdReceipts.Size = new System.Drawing.Size(1143, 203);
            this.grdReceipts.TabIndex = 57;
            this.grdReceipts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceipts_CellClick);
            // 
            // frmIssueInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.grdReceipts);
            this.Controls.Add(this.grdOrders);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmIssueInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Invoices";
            this.Load += new System.EventHandler(this.frmIssueInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceipts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.DataGridView grdReceipts;
    }
}