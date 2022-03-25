using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    interface IOrder
    {
        void confim();
        void close();
    }
    class Order:IOrder
    {
        protected Customer Customer;
        protected DateTime date;
        protected int number;
        public void confim() { }
        public void close() { }
    }
}
