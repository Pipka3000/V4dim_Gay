using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    interface INormalOrder:IOrder
    {
        void confim();
        void close();
        void dispatch();
        void receive();
    }
    class NormalOrder:INormalOrder
    {
        protected DateTime date;
        protected int number;
        public void confim() { }
        public void close() { }
        public void dispatch() { }
        public void receive() { }

    }
}
