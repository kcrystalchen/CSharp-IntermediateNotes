using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UpcastingAndDownCasting
{

    class Program
    {
        static void Main(string[] args)
        {

            // UPCASTING:

            // streamreader from .Net framework that can read any strings and any kind, and it takes a string object,no conversion is required
            // StreamReader reader = new StreamReader(new FileStream());
            // StreamReader reader = new StreamReader(new MemoryStream());
            // var list = new ArrayList(); // a class called ArrayList to store objects in the list 
            // list.Add(1); // using Add() method to pass any objects into ArrrayList and no conversion is required
            // list.Add("Add a string");
            // list.Add(new Text()); // also can add Text object
            // all the objects have been added, will be implicitly converted to the base object class


            // the best practice is using Generic List class instead of ArrayList as ArrayList may easier to cause data type issue
            // var anotherList = new List<int>(); // it is a list of integer
            // var anotherList0 = new List<Shape>();// it is a list of Shape, means every element is going to be a type of Shape. so we stored shape object or the instance of the ? classes 


            /*  
            Text text = new Text(); // create an object called text from class Text
            Shape shape = text;  // upcasting, no conversion is required, implicitly convert an object reference like text to a Class reference like shape
                                 // text currently has all the access from text and shape because text is inherent base class Shape properties, methods etc
                                 // but shape does not have all the access to text

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width); // it displays 100 because text.width and shape.width both are pointing to the same object
            // that Shape is the basic class that Text inherient Shape's everything
            */




            // DownCasting:

            Shape shape = new Text();
            Text text = (Text)shape; 
            // shape does not have Text object access 
            // but text have shape object and text object access because shape is downcast
            
            
        }
    }
}
