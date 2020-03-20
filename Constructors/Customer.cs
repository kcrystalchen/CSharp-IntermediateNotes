using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders; 
        // create a List of orders, the class in the Order.cs file 
        // List of object, <Order> is parameter, it is the type of the object
        // in this list, it can be store "Object of type <Order>"



        // whenever you have class that contains a List of object <any types>,
        // -> * ALWAYS initialize the List as an empty List in the default constructor in the class
        public Customer() 
        {
            Orders = new List<Order>(); // initialize the List field 
        }
          

        public Customer(int inputId)  // declare a constructor - Customer constructor
             : this()  // this keyword means when this constructor is being called, it will called this() constructor (the previous constructor) first
        {
            this.Id = inputId;
        }

        public Customer(int inputId, string inputName)
            : this(inputId)
        { 
            this.Id = inputId;
            this.Name = inputName;
        }

  
    }
}
