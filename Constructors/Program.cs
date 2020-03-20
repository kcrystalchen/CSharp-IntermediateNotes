using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{

    class Program
    { 
        static void Main(string[] args)
        {
           // or Customer customer = new Customer(1, "John");
            Customer customer = new Customer(); // a new instance of class Customer from customers.cs
            customer.Id = 1;
            customer.Name = "John";
            customer.Orders.Add(order);


            // object initializers
            //var person = new Person
            //{
            //    FirstName = "Mohs",
            //    LastName = "Hamedani"
            //};

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
     
        }
    }
}
