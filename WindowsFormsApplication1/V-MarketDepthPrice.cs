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
    public partial class MarketDepthPrice : Form, V_StockMarketDisplay
    {
        public M_RealTimeData myData;
        public int companyIndex;

        List<M_BuyOrder> buyOrdTot = new List<M_BuyOrder>();
        List<int> numOfBuy = new List<int>();

        List<M_SellOrder> sellOrdTot = new List<M_SellOrder>();
        List<int> numOfSell = new List<int>();

        //Default Constructor
        public MarketDepthPrice()
        {
            InitializeComponent();
        }
        public MarketDepthPrice(int companyNum, M_RealTimeData data)
        {
            InitializeComponent();

            //Save Data and Company
            myData = data;
            companyIndex = companyNum;

            //Populate View Rows and make sure user can add anymore 
            dataGridView1.Rows.Add(10);
            dataGridView1.AllowUserToAddRows = false;


            Update(data);
        }
        public void Update(M_RealTimeData data)
        {
            //Reinitialize Buy and Sell and corresponding lists
            buyOrdTot = new List<M_BuyOrder>();
            numOfBuy = new List<int>();

            sellOrdTot = new List<M_SellOrder>();
            numOfSell = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                for (int c = 0; c < 6; c++)
                {
                    dataGridView1.Rows[i].Cells[c].Value = "";
                }
            }
           
            bool newItem;
            //Buy
            //Loop through all orders of the given company index
            for (int i = 0; i < data.company[companyIndex].pendingBuys.Count; i++)
            {
                //Set new item true for each iteration through in case of a unallocated price
                newItem = true;
                for (int c = 0; c < buyOrdTot.Count; c++)
                {
                    //Check for price match in existing buyOrd list
                    if (data.company[companyIndex].pendingBuys[i].getPrice() == buyOrdTot[c].getPrice())
                    {
                        //When match is found, increase the order size and add the volume
                        numOfBuy[c] += 1;
                        buyOrdTot[c].orderSize += data.company[companyIndex].pendingBuys[i].orderSize;
                        //Change newItem variable because it is not a new price
                        newItem = false;
                    }
                }
                if (newItem == true)
                {
                    //Since the price has not been matched create a new buyOrdTot and give it 1 instance
                    buyOrdTot.Add(new M_BuyOrder(data.company[companyIndex].pendingBuys[i].orderSize, data.company[companyIndex].pendingBuys[i].orderPrice));
                    numOfBuy.Add(1);
                }
            }
            //Sell
            for (int i = 0; i < data.company[companyIndex].pendingSales.Count; i++)
            {
                newItem = true;
                for (int c = 0; c < sellOrdTot.Count; c++)
                {
                    if (data.company[companyIndex].pendingSales[i].getPrice() == sellOrdTot[c].getPrice())
                    {
                        numOfSell[c] += 1;
                        sellOrdTot[c].orderSize += data.company[companyIndex].pendingSales[i].orderSize;
                        newItem = false;
                    }
                }
                if (newItem == true)
                {
                    sellOrdTot.Add(new M_SellOrder(data.company[companyIndex].pendingSales[i].orderSize, data.company[companyIndex].pendingSales[i].orderPrice));
                    numOfSell.Add(1);
                }
            }
            //Populate Buy Columns
            for (int i = 0; i < buyOrdTot.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = numOfBuy[i];
                dataGridView1.Rows[i].Cells[1].Value = buyOrdTot[i].orderSize;
                dataGridView1.Rows[i].Cells[2].Value = buyOrdTot[i].orderPrice;
            }
            //Populate Sell Columns
            for (int i = 0; i < sellOrdTot.Count; i++)
            {
                dataGridView1.Rows[i].Cells[5].Value = numOfSell[i];
                dataGridView1.Rows[i].Cells[4].Value = sellOrdTot[i].orderSize;
                dataGridView1.Rows[i].Cells[3].Value = sellOrdTot[i].orderPrice;
            }
            
        }
        

    }
    
}
