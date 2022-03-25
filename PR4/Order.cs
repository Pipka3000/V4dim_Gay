using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    interface IOrder
    {
        void confirm();
        void close();
    } 
    class Order:IOrder
    {
        
        protected DateTime date;
        protected int number;
        public virtual void confirm() { }
        public virtual void close() { }

        public Order() { }
        public Order (DateTime dateTime) { }
        public Order(int number) { }
    }
}
