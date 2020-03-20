using System;

namespace Composition
{

    // the relationship and associations between classes
    public class Logger  // Logger class has the common functionality 
    {
        public void Log(string message)  // create a method called Log
        {
            Console.WriteLine(message);
        }
    }
}
  