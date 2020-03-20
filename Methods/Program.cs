using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

 
    class Program
    {
        static void Main(string[] args)
        {
            // Convert a string to a number
            //  var number = int.Parse("abc"); // it will throw an error, can not convert to a number

            try
            {
                int.Parse("ABC"); 
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed 0.");
            }

            var result = int.TryParse("abc", out int number);  // (string, declare the integer); 
            if (result)
            {
                Console.WriteLine(result); // int.TryParse() returns a bool(true || false), does not return an exception
            }
            else
            {
                Console.WriteLine("Conversion failed 1.");
            }

        }


        static void UseParams()  // Calculator class 
        {
            // create an instance of Calculator 
            Calculator calculator = new Calculator();
            var answer = calculator.Add(1, 2); // call the Add() method
            Console.WriteLine(answer);
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }


        static void UsePoints() // Point class
        {
            try
            {
                // creating a point object
                Point point = new Point(10, 20);
                // call the move method
                // point.Move(null); // will catch the error
                point.Move(new Point(200, 300));
                Console.WriteLine("Point Move method is at {0}, {1}", point.X, point.Y);


                // call the overload move method
                point.Move(100, 200);
                Console.WriteLine("Point overload move method is at {0}, {1}", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred.");
            }
        }
    }
}
