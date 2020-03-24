using System;

namespace DesignADatabaseConnection
{
    public class SqlConnection : DbConnection // SqlConnection will overwrite to the abstract base class (Polymorphism behavior)
    {
        

        public SqlConnection(string connectionString) 
            : base(connectionString)
        {
            // because DbConnection passed in connectionString, so SqlConnection needs a constructor to pass in string as well

        }

        public override void ClosingConnection()
        {
            Console.WriteLine("Closing Sql Connection");
        }

        public override void OpeningConnection()
        {
            Console.WriteLine("Opening Sql Connection");
        }
    }
}
