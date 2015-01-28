namespace WindowsFormsApplication1
{
    partial class StockStateSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockStateSummary));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changePicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.changePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shareVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Company,
            this.symbol,
            this.openPrice,
            this.lastSale,
            this.changeNet,
            this.changePicture,
            this.changePercent,
            this.shareVolume});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.Width = 76;
            // 
            // symbol
            // 
            this.symbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.symbol.HeaderText = "Symbol";
            this.symbol.Name = "symbol";
            this.symbol.Width = 66;
            // 
            // openPrice
            // 
            this.openPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.openPrice.HeaderText = "Open Price";
            this.openPrice.Name = "openPrice";
            this.openPrice.Width = 85;
            // 
            // lastSale
            // 
            this.lastSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lastSale.HeaderText = "Last Sale";
            this.lastSale.Name = "lastSale";
            this.lastSale.Width = 76;
            // 
            // changeNet
            // 
            this.changeNet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.changeNet.HeaderText = "Change Net";
            this.changeNet.Name = "changeNet";
            this.changeNet.Width = 89;
            // 
            // changePicture
            // 
            this.changePicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.changePicture.HeaderText = "";
            this.changePicture.Name = "changePicture";
            this.changePicture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.changePicture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.changePicture.Width = 19;
            // 
            // changePercent
            // 
            this.changePercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.changePercent.HeaderText = "Change %";
            this.changePercent.Name = "changePercent";
            this.changePercent.Width = 80;
            // 
            // shareVolume
            // 
            this.shareVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.shareVolume.HeaderText = "Share Volume";
            this.shareVolume.Name = "shareVolume";
            this.shareVolume.Width = 98;
            // 
            // StockStateSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 149);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockStateSummary";
            this.Text = "Stock State Summary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn openPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeNet;
        private System.Windows.Forms.DataGridViewImageColumn changePicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn changePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn shareVolume;
    }
}