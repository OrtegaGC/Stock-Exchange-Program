using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace WindowsFormsApplication1
{
    public class M_Company
    {
        public String companyName,Symbol;
        public double lastPrice,openPrice,netChange;
        public double volume;
        public Bitmap bmp;


        public M_Company()
        {
            companyName = "";
            lastPrice = 0;
            volume = 0;
            netChange = 0;
        }
        public M_Company(String name,String Symbol, double opPrice, int vol)
        {
            this.companyName = name;
            this.Symbol = Symbol;
            this.openPrice = opPrice;
            this.volume = vol;
            this.netChange = 0;
            this.bmp = new Bitmap(WindowsFormsApplication1.Properties.Resources.noChange);
             
        }
        //PendingBuy/Sale Functions
        public List<M_BuyOrder> pendingBuys = new List<M_BuyOrder>() ;
        public List<M_SellOrder> pendingSales = new List<M_SellOrder>();

        public void addBuy( double volume, double price)
        {
            bool bottomAdd = true;
            
            M_BuyOrder itemAdd = new M_BuyOrder();

            //Create the item to add
            itemAdd.setOrder(volume, price);

            //TODO Transactions
            bool alreadySold = false;
            bool tryAgain = false;
            if (pendingSales.Count != 0)
            {
                do
                {
                    tryAgain = false;
                    for (int i = 0; i < pendingSales.Count; i++)
                    {
                        if (pendingSales[i].getPrice() == itemAdd.getPrice())
                        {
                            if (pendingSales[i].getSize() == itemAdd.getSize())
                            {
                                //even trade
                                lastPrice = itemAdd.getPrice();
                                pendingSales.Remove(pendingSales[i]);
                                alreadySold = true;
                                this.volume += itemAdd.getSize();
                                sale();
                            }
                            else if (pendingSales[i].getSize() > itemAdd.getSize())
                            {
                                //bigger sale
                                lastPrice = itemAdd.getPrice();
                                pendingSales[i].orderSize -= itemAdd.orderSize;
                                alreadySold = true;
                                this.volume += itemAdd.getSize();

                                sale();
                                
                            }
                            else if (pendingSales[i].getSize() < itemAdd.getSize())
                            {
                                //greedy buyer
                                tryAgain = true;
                                lastPrice = itemAdd.getPrice();
                                this.volume += pendingSales[i].orderSize;
                                itemAdd.orderSize -= pendingSales[i].orderSize;
                                pendingSales.Remove(pendingSales[i]);
                                sale();
                            }
                        }
                    }
                } while (tryAgain == true);
            }

            //If there are no pending orders at the moment, create the first one
            if(alreadySold == false){
                if(pendingBuys.Count == 0)
                {
                    pendingBuys.Add(itemAdd);
                }
                else
                {
                    //Otherwise go through the already created pending and order by price
                    for (int i = 0; i < pendingBuys.Count; i++)
                    {
                        if (pendingBuys[i].orderPrice < itemAdd.orderPrice)
                        {
                            //if there the new order is bigger insert it in that place
                            pendingBuys.Insert(i,itemAdd);
                            bottomAdd = false;
                            break;
                        }
                    }
                    //otherwise add to bottom of the stack
                    if (bottomAdd == true)
                    {
                        pendingBuys.Add(itemAdd);
                    }
                }
            }
            
        }


        public void addSell( double volume, double price)
        {
            bool bottomAdd = true;
            M_SellOrder itemAdd = new M_SellOrder();

            itemAdd.setOrder(volume, price);
 
            
            //TODO Transactions
            bool alreadySold = false;
            bool tryAgain = false;
            if (pendingBuys.Count != 0)
            {
                do
                {
                    tryAgain = false;
                    for (int i = 0; i < pendingBuys.Count; i++)
                    {
                        if (pendingBuys[i].getPrice() == itemAdd.getPrice())
                        {
                            if (pendingBuys[i].getSize() == itemAdd.getSize())
                            {
                                //even trade
                                lastPrice = itemAdd.getPrice();
                                pendingBuys.Remove(pendingBuys[i]);
                                alreadySold = true;
                                this.volume += itemAdd.getSize();
                                sale();
                            }
                            else if (pendingBuys[i].getSize() > itemAdd.getSize())
                            {
                                //bigger sale
                                lastPrice = itemAdd.getPrice();
                                pendingBuys[i].orderSize -= itemAdd.orderSize;
                                alreadySold = true;
                                this.volume += itemAdd.getSize();

                                sale();

                            }
                            else if (pendingBuys[i].getSize() < itemAdd.getSize())
                            {
                                //greedy buyer
                                tryAgain = true;
                                lastPrice = itemAdd.getPrice();
                                this.volume += pendingBuys[i].orderSize;
                                itemAdd.orderSize -= pendingBuys[i].orderSize;
                                pendingBuys.Remove(pendingBuys[i]);
                                sale();
                            }
                        }
                    }
                } while (tryAgain == true);
            }

            //
            if (alreadySold == false)
            {
                if (pendingSales.Count == 0)
                {
                    pendingSales.Add(itemAdd);
                }
                else
                {
                    for (int i = 0; i < pendingSales.Count; i++)
                    {
                        //Only true difference with sell, ordered by lowest price 
                        if (pendingSales[i].orderPrice > itemAdd.orderPrice)
                        {
                            pendingSales.Insert(i, itemAdd);
                            bottomAdd = false;
                            break;
                        }
                    }
                    if (bottomAdd == true)
                    {
                        pendingSales.Add(itemAdd);
                    }
                }
            }
            
        }

        //Modifying Functions
        public void sale()
        {
            netChange = lastPrice - openPrice;
            if (netChange > 0)
            {
                this.bmp = new Bitmap(WindowsFormsApplication1.Properties.Resources.up);
            }
            else if (netChange < 0)
            {
                this.bmp = new Bitmap(WindowsFormsApplication1.Properties.Resources.down);
            }
            else
            {
                this.bmp = new Bitmap(WindowsFormsApplication1.Properties.Resources.noChange);
            }
        }



        public double getLastPrice() 
        {
            return this.lastPrice;
        }
        public double getVolume()
        {
            return this.volume;
        }
        public String getName()
        {
            return this.companyName;
        }
        public void setName(String name)
        {
            this.companyName = name;
        }
    }
}
