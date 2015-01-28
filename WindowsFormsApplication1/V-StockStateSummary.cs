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
    public partial class StockStateSummary : Form, V_StockMarketDisplay
    {
        M_Company[] displayCompany = new M_Company[3];
        public StockStateSummary()
        {
            InitializeComponent();
        }
        public StockStateSummary(M_RealTimeData data)
        {
            InitializeComponent();
            for (int i = 0; i < data.company.Count; i++)
            {

                displayCompany[i] = data.company[i];
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = "Test";
            }
            dataGridView1.AllowUserToAddRows = false;
            Update(data);
        }

        public void Update(M_RealTimeData data)
        {
            for (int i = 0; i < data.company.Count; i++)
            {
                
                dataGridView1.Rows[i].Cells[0].Value = data.company[i].companyName;
                dataGridView1.Rows[i].Cells[1].Value = data.company[i].Symbol;
                dataGridView1.Rows[i].Cells[2].Value = data.company[i].openPrice;
                dataGridView1.Rows[i].Cells[3].Value = data.company[i].lastPrice;
                dataGridView1.Rows[i].Cells[4].Value = data.company[i].netChange;
                dataGridView1.Rows[i].Cells[5].Value = data.company[i].bmp;
                dataGridView1.Rows[i].Cells[6].Value = Math.Abs(data.company[i].lastPrice - data.company[i].openPrice) / data.company[i].openPrice;
                dataGridView1.Rows[i].Cells[7].Value = data.company[i].volume;
            }
                
        }
    }
}
