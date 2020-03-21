using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            //Add method in ArrayList takes an argument with type of an object
            list.Add(1);  // since 1 is integer, and it is the value type, so the input value will be boxing to convert to reference type - an object
            list.Add("string"); // string is a reference type, so the boxing will not be happened
            list.Add(DateTime.Today); // DateTime is a structure, so it is a value type, so it also will be boxing


            var number = (int)list[1]; 
            // problems with ArrayList()
            // 1. datatype: second argument is a string, and cast it into an integer. Then it will get an invalid cast exception
            // because the second argument is a string, but the first argument is an integer
            // 2. .Add() method takes an argument with type of object, which means if the input is "value type", then it will boxing
            // 
            Console.WriteLine(number);



            /********************************************************************/
            // using "new List<>()"
            var anotherList = new List<int>();
            anotherList.Add(1);
            // store a list of int, so boxing will not happen. datatype will not boxing, it is type safety
            var anotherList0 = new List<string>();
            anotherList0.Add("string");


        }
    }
}
