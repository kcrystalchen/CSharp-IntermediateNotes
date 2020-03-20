using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    // Create a class called Calculator
    public class Calculator
    {
    // create a method called Add
       public int Add(params int[] numbers)
       {
         // numbers is an integer array, add all the numbers in the array and return the sum 
         var sum = 0;
         foreach (var number in numbers)
         {
            sum += number;
         }
         return sum;
       }
    }


    
}
