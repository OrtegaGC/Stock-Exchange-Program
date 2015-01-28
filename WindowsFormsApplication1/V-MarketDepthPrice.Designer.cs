namespace WindowsFormsApplication1
{
    partial class MarketDepthPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketDepthPrice));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellNumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberBuy,
            this.buyVol,
            this.buyPrice,
            this.sellPrice,
            this.sellVol,
            this.sellNumb});
            this.dataGridView1.Location = new System.Drawing.Point(10, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // numberBuy
            // 
            this.numberBuy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numberBuy.HeaderText = "#";
            this.numberBuy.Name = "numberBuy";
            this.numberBuy.Width = 39;
            // 
            // buyVol
            // 
            this.buyVol.HeaderText = "Volume";
            this.buyVol.Name = "buyVol";
            // 
            // buyPrice
            // 
            this.buyPrice.HeaderText = "Price";
            this.buyPrice.Name = "buyPrice";
            // 
            // sellPrice
            // 
            this.sellPrice.HeaderText = "Price";
            this.sellPrice.Name = "sellPrice";
            // 
            // sellVol
            // 
            this.sellVol.HeaderText = "Volume";
            this.sellVol.Name = "sellVol";
            // 
            // sellNumb
            // 
            this.sellNumb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sellNumb.HeaderText = "#";
            this.sellNumb.Name = "sellNumb";
            this.sellNumb.Width = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sell";
            // 
            // MarketDepthPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarketDepthPrice";
            this.Text = "Market Depth By Price";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellNumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}