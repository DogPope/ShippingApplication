
namespace ShippingApplication
{
    partial class frmAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboRevenueYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chtRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStockYear = new System.Windows.Forms.ComboBox();
            this.chtStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtGameTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1083, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 24);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Return";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboRevenueYear
            // 
            this.cboRevenueYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRevenueYear.FormattingEnabled = true;
            this.cboRevenueYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cboRevenueYear.Location = new System.Drawing.Point(47, 99);
            this.cboRevenueYear.Name = "cboRevenueYear";
            this.cboRevenueYear.Size = new System.Drawing.Size(169, 21);
            this.cboRevenueYear.TabIndex = 4;
            this.cboRevenueYear.SelectedIndexChanged += new System.EventHandler(this.cboRevenueYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Revenue Analysis Year";
            // 
            // chtRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtRevenue.Legends.Add(legend1);
            this.chtRevenue.Location = new System.Drawing.Point(12, 168);
            this.chtRevenue.Name = "chtRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chtRevenue.Series.Add(series1);
            this.chtRevenue.Size = new System.Drawing.Size(561, 391);
            this.chtRevenue.TabIndex = 6;
            this.chtRevenue.Text = "Revenue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(668, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stock Analysis Year";
            // 
            // cboStockYear
            // 
            this.cboStockYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStockYear.FormattingEnabled = true;
            this.cboStockYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cboStockYear.Location = new System.Drawing.Point(672, 99);
            this.cboStockYear.Name = "cboStockYear";
            this.cboStockYear.Size = new System.Drawing.Size(169, 21);
            this.cboStockYear.TabIndex = 7;
            this.cboStockYear.SelectedIndexChanged += new System.EventHandler(this.cboStockYear_SelectedIndexChanged);
            // 
            // chtStock
            // 
            chartArea2.Name = "ChartArea1";
            this.chtStock.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtStock.Legends.Add(legend2);
            this.chtStock.Location = new System.Drawing.Point(611, 168);
            this.chtStock.Name = "chtStock";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Stock";
            this.chtStock.Series.Add(series2);
            this.chtStock.Size = new System.Drawing.Size(561, 391);
            this.chtStock.TabIndex = 9;
            this.chtStock.Text = "chart2";
            // 
            // txtGameTitle
            // 
            this.txtGameTitle.Location = new System.Drawing.Point(878, 46);
            this.txtGameTitle.Name = "txtGameTitle";
            this.txtGameTitle.Size = new System.Drawing.Size(100, 20);
            this.txtGameTitle.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(875, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 13);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Game Title";
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtGameTitle);
            this.Controls.Add(this.chtStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboStockYear);
            this.Controls.Add(this.chtRevenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRevenueYear);
            this.Controls.Add(this.btnExit);
            this.Name = "frmAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboRevenueYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRevenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStockYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtStock;
        private System.Windows.Forms.TextBox txtGameTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}