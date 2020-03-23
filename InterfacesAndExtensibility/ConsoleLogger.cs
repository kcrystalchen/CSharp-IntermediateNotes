using System;

namespace InterfacesAndExtensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LoggerError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LoggerInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
