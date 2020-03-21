using System;

namespace Constructor0
{
    public class Car : Vehicle
    {
        public Car(string registerationNumber)
            :base(registerationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registerationNumber);
        }
    }
}
