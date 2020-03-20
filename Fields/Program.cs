using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1);

            customer.Orders.Add(new OrderInfo());
            customer.Orders.Add(new OrderInfo());
        

            customer.Promote();  // if I invoke the Promote() here, then it will reinitize the new Order() List
            // as inside the Promote() method has re-initialize Orders = new List<Orders>()
            // The solution will be to use readonly modifier, this way THE CODE know "Orders" only can invoke ONCE. 
            // And gives an error in output

            Console.WriteLine("Counting customer orders: " +  customer.Orders.Count);


        }
    }
}
