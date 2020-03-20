using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdateInput)
        {
            _birthdate = birthdateInput;
        }
        
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetBirthdate(new DateTime(1999, 1, 1));
            Console.WriteLine("The person's birth date is " + person.GetBirthdate());
        }
    }
}
