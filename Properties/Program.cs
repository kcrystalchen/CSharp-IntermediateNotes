using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Properties
{

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            // var person = new Person(new Date(1999,1,1));

            person.Birthdate = new DateTime(1999, 1, 1);
            Console.WriteLine(person.Age);
        }
    }
}
