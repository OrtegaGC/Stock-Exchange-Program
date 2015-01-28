using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace WindowsFormsApplication1
{
    public partial class PlaceBid : Form
    {
        M_RealTimeData bidData;
        public PlaceBid()
        {
            InitializeComponent();
            //ComboboxItem itemAdd = new ComboboxItem();
            
        }
        public PlaceBid(M_RealTimeData data)
        {
            bidData = data;
            InitializeComponent();
            for (int i = 0; i < data.company.Count; i++)
            {

                companiesList.Items.Add(data.company[i].companyName);
                //
            }
            companiesList.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int num = companiesList.SelectedIndex;
            
            bidData.company[num].addBuy(double.Parse(maskedTextBox1.Text),double.Parse(maskedTextBox2.Text));
            bidData.Notify();
        }
    }
}
