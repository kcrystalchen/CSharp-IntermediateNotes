using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{


    class Program
    {
        static void Main(string[] args)
        {
            // For Not Generics examples: we need to instance each list 
            Book book = new Book {Isbn = "1234567", Title = "C# Advanced"};  // instance of the Book object
            Del


            List numbers = new List();  // instance of List 
            numbers.Add(10);
           

            //// For Generics examples: we do not need to instance each list

            var intNum = new GenericList<int>(); // in here, specify the type, and it did not have to specify the type earlier
            intNum.Add(20);

            var books0 = new GenericList<Book>();// object Genericlist is list of books, it is not a list of objects
            books0.Add(new Book());



            //// Generic DiscountCalculator

            var discountCalculator = new DiscountCalculator<Product>();


            // Generic Nullable
            var number = new Nullable<int>(100);
            Console.WriteLine(number);
            Console.WriteLine(number.HasValue);
            Console.WriteLine(number.GetValueOrDefault());





        }
    }
}
