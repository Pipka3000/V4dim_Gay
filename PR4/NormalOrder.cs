using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    interface INormalOrder:IOrder
    {
        void dispatch();
        void receive();
    }
    class NormalOrder:Order ,INormalOrder
    {
        
        public override void confirm() { }
        public override  void close() { }
        public void dispatch() { }
        public void receive() { }
        public NormalOrder() { }
        public NormalOrder(DateTime dateTime) { }
        public NormalOrder(int number) { }

    }
}
