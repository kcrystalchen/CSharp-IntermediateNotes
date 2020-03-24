using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignAStopWatch
{


    class Program
    {
        static void Main(string[] args)
        {

            StopWatch stopwatch = new StopWatch();

            for (var x = 0; x < 100; x += 1)
            {
                stopwatch.Start(); // starting the time 

                Thread.Sleep(1000); // delay the application
                

                stopwatch.Stop(); // stopping the time

                Console.WriteLine(stopwatch.GetInterval().Ticks);
                Console.WriteLine("Please Enter to run the stopwatch one more time");
                Console.ReadLine();

            }


        }
    }
}
