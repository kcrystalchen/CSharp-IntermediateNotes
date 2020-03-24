using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignADatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {

            DbCommand dbCommand = new DbCommand();

            Console.WriteLine("Option 0 is for SQL || Option 1 is for Oracle: ");
            string userInput = Console.ReadLine();


            if(Convert.ToInt32(userInput) == 0)
            {
                dbCommand.SqlExecution();
            } 
            else if(Convert.ToInt32(userInput) == 1)
            {
                dbCommand.OracleExecution();
            }



        }
    }
}
