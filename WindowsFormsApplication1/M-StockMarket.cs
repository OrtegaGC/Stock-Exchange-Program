using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class StockMarket
    {
        public List<V_StockMarketDisplay> _observers = new List<V_StockMarketDisplay>();
        
        public void Register(V_StockMarketDisplay display)
        {
            _observers.Add(display);
            
        }
        public void UnRegister(V_StockMarketDisplay display)
        {
            _observers.Remove(display);   
        }
        public abstract void Notify();


    }
}
