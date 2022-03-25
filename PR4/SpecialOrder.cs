using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    interface iSpecialOrder:IOrder
    {
        void dispatch();
       
      
    }
    class SpecialOrder:Order, iSpecialOrder
    {
        
        private Customer client;
        public override void confirm() { }
        public override void close() { }
        public void dispatch() { }
        public SpecialOrder() { }
        public SpecialOrder(DateTime dateTime) { }
        public SpecialOrder(Customer client) { }
    }
}
