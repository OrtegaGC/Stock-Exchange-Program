using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MarketOrderByDepth : Form,V_StockMarketDisplay
    {
        public int companyIndex;
        public MarketOrderByDepth()
        {
            InitializeComponent();
        }
        public MarketOrderByDepth(int companyNum,M_RealTimeData data)
        {
            InitializeComponent();
            companyIndex = companyNum;
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add();

            }
            dataGridView1.AllowUserToAddRows = false;
            Update(data);
        }
        public void Update(M_RealTimeData data)
        {
            //clear table
            for (int i = 0; i < 10; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    dataGridView1.Rows[i].Cells[c].Value = "";
                }
            }
            //hold the number of entries at 10
            
            int hold = data.company[companyIndex].pendingBuys.Count;
            int hold2 = data.company[companyIndex].pendingSales.Count;

            if (hold > 10)
            {
                hold = 10;
            }
            if (hold2 > 10)
            {
                hold2 = 10;
            }
            for (int i = 0; i < hold; i++) { 
                dataGridView1.Rows[i].Cells[1].Value = data.company[companyIndex].pendingBuys[i].orderPrice;
                dataGridView1.Rows[i].Cells[0].Value = data.company[companyIndex].pendingBuys[i].orderSize;
            }
            for (int i = 0; i < hold2; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = data.company[companyIndex].pendingSales[i].orderPrice;
                dataGridView1.Rows[i].Cells[3].Value = data.company[companyIndex].pendingSales[i].orderSize;
            }
        }
    }
}
