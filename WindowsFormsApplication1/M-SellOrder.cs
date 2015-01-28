using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class M_SellOrder: Order
    {
        public int orderTime;
        public double orderSize;
        public double orderPrice;

        public M_SellOrder()
        {
            this.orderPrice = 0;
            this.orderSize = 0;
        }

        public M_SellOrder(double size, double price)
        {
            this.orderPrice = price;
            this.orderSize = size;
        }


        public void setOrder(double size, double price)
        {
            this.orderPrice = price;
            this.orderSize = size;
        }
        public double getPrice()
        {
            return this.orderPrice;
        }
        public double getSize()
        {
            return this.orderSize;
        }

        public void setPrice(double price)
        {
            this.orderPrice = price;
        }

    }
}
