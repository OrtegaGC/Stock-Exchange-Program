using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class M_RealTimeData : StockMarket
    {
        public M_RealTimeData() 
        {
            
        }
        public List<M_Company> company = new List<M_Company>()
        {
            new M_Company("Facebook Inc.","MSFT",46.13,0),
            new M_Company("Apple Inc.","AAPL", 105.22, 0),
            new M_Company("Microsoft Corporation","FB", 80.67, 0)
        };
        
        public override void Notify()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                _observers[i].Update(this);
            }
        }

    }
}
