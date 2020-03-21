using System;

namespace Constructor0
{
    public class Vehicle
    {
        private readonly string registerationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized...");
        //}

        public Vehicle(string registerationNumber)
        {
            this.registerationNumber = registerationNumber;

            Console.WriteLine("Vehicle is being initialized. {0} ", registerationNumber);
        }
    }
}
