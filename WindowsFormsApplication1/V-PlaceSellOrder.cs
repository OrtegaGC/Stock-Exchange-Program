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
    public partial class PlaceSellOrder : Form
    {
        M_RealTimeData bidData;
        public PlaceSellOrder()
        {
            InitializeComponent();
        }
        public PlaceSellOrder(M_RealTimeData data)
        {
            InitializeComponent();
            bidData = data;
            for (int i = 0; i < data.company.Count; i++)
            {
                companies.Items.Add(data.company[i].companyName);
            }
            companies.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = companies.SelectedIndex;
            System.Diagnostics.Debug.Write(num);
            bidData.company[num].addSell(int.Parse(maskedTextBox1.Text), double.Parse(maskedTextBox2.Text));
            bidData.Notify();
        }
    }
}
