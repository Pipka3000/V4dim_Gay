using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
     interface ICustomer 
     {
        void send_order();
        void receive_order();
     }
    class Customer:ICustomer
    {
        protected string name;
        protected string address;
        public  void send_order() { }
        public  void receive_order() { }
        public Customer() { }
        public Customer(string name) { }
        public Customer(string address,string name) { }
    }
}
