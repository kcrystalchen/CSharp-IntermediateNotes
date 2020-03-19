using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

       public class Person  // creating a class called Person 
        {
            public string Name;  // field 

            public void Introduce(string toName)  //method
            {
                Console.WriteLine("Hi {0}, I am {1}.", toName, Name);
            }

        /*
           // Parse Method for Person class 
            public Person Parse(string inputName)
            {
               Person person = new Person();
               person.Name = inputName;
               return person;
            }
        */
           // static class for parse() method
           
           public static Person Parse(string inputName)
            {
              Person person = new Person();
              person.Name = inputName;
              return person;
            }
            

        }


    class Program
    {

        static void Main(string[] args)
        {
            // Person class to instance an object called person
            Person person = new Person();
            person.Name = "Mosh";
            person.Introduce("John");

            // Person class with Parse() method to instance an object called person 
            //Person person = new Person();
            //var personObject = person.Parse("Mosh again");
            //personObject.Introduce("John again");

            // without instance an object, then it should use Static class 
            
            var personObject1 = Person.Parse("Mosh1 again");
            personObject1.Introduce("John1 again");
            
        }
    }
}
