using System;

namespace Properties
{
    public class Person
    {
        // declare auto implement property without declaring a field because this property Birthday does not have logic involved
        public DateTime Birthdate { get; set; } // C# automatically creates private field and create get and set methods and access for us
       
        
        // in the auto implement property, since we only can set Birthdate once and can't be changed, we can add private before the set method;
        // alternative solutions for setting set; as private, which helps with readonly access, and only can set the property once.


        // public DateTime Birthdate {get; private set;}  // if we use private set, then we have to create a constructor for Birthday
        // public Person(DateTime birthdate) { Birthdate = birthdate }

        // then, in the Program.cs, we can directly pass DateTime birthdate to newPerson() object
        // in Program.cs: var person = new Person(new Date(1999,1,1))




        //The Age property will be based on the Birthday of the person
        public int Age // this property can not be an auto implement property because this Age property will have logic involved
        {
            get  // in Age property, there is only a get method, not there is no set method because Age should be calculated based on the birthday, it does not have to set the Age
            {
                TimeSpan timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
            // if you don't have to set the property, then you do not have declare set method
        }
    }
}
