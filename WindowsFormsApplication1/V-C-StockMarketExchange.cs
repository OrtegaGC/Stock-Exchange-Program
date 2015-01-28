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
    public partial class StockMarketExchange : Form
    {
        public M_RealTimeData realTimeD;
        public StockMarketExchange()
        {
            InitializeComponent();
            
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void beginTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            watchToolStripMenuItem.Visible = true;
            toolStripMenuItem6.Visible = true;
            beginTradingToolStripMenuItem.Visible = false;

            marketVariableToolStripMenuItem.Text = "Market <<Open>>";
            realTimeD = new M_RealTimeData();
            
            
            //Add side menu Items
            
            ToolStripMenuItem[] items = new ToolStripMenuItem[realTimeD.company.Count];
            
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ToolStripMenuItem("a" + i);
                items[i].Text = realTimeD.company[i].companyName;
                items[i].Name = i + "_Company";
                items[i].Tag = i;
                items[i].Click += new EventHandler(MenuClick);
            }
            ToolStripMenuItem[] itemss = new ToolStripMenuItem[realTimeD.company.Count];

            for (int i = 0; i < itemss.Length; i++)
            {
                itemss[i] = new ToolStripMenuItem("a" + i);
                itemss[i].Text = realTimeD.company[i].companyName;
                itemss[i].Name = i + "_Company";
                itemss[i].Tag = i;
                itemss[i].Click += new EventHandler(MenuClickPrice);
            }
            marketByOrderToolStripMenuItem.DropDownItems.AddRange(items);
            marketByPriceToolStripMenuItem.DropDownItems.AddRange(itemss);

        }
        private void MenuClick(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            int num = int.Parse(clickedItem.Tag.ToString());
            MarketOrderByDepth newMDIChild = new MarketOrderByDepth(num,realTimeD);
           
            newMDIChild.Text = "Market By Order (" + realTimeD.company[num].companyName + ")";
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            realTimeD.Register(newMDIChild);
        }

        private void MenuClickPrice(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            int num = int.Parse(clickedItem.Tag.ToString());
            MarketDepthPrice newMDIChild = new MarketDepthPrice(num,realTimeD);

            newMDIChild.Text = "Market By Price (" + realTimeD.company[num].companyName + ")";
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            realTimeD.Register(newMDIChild);
        }

        private void stockStateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockStateSummary summaryForm = new StockStateSummary(realTimeD);
            summaryForm.MdiParent = this;
            summaryForm.Show();
            realTimeD.Register(summaryForm);
            realTimeD.Notify();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
        }

        private void bidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceBid placeForm = new PlaceBid(realTimeD);
            placeForm.MdiParent = this;
            
            placeForm.Show();
        }

        private void askToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceSellOrder placeSellForm = new PlaceSellOrder(realTimeD);
            placeSellForm.MdiParent = this;
            placeSellForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalTIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void stopTradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
