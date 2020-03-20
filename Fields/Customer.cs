using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<OrderInfo> Orders = new List<OrderInfo>();  // always initialize List as an empty list 


        public Customer(int inputId) // creating Customer constructor
        {
            this.Id = inputId;
        }
        public Customer(int inputId, string inputName) // creating Customer constructor
            : this(inputId)
        {
            this.Name = inputName;
        }

        public void Promote() // creating a method called Promote()
        {
            // if I incidentally re-initialize or initialize the Orders here, it will cause bug when I invoke Customer and Promote
            // Orders = new List<OrderInfo>();
            //...
        }

    }
}
