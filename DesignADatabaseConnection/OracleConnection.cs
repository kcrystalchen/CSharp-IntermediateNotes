using System;

namespace DesignADatabaseConnection
{
    public class OracleConnection : DbConnection // OracleConnection will overwrite to the abstract base class (Polymorphism behavior)
    {
        public OracleConnection(string ConnectionString) : base(ConnectionString)
        {
            // because DbConnection passed in connectionString, so OracleConnection needs a constructor to pass in string as well
        }

        public override void ClosingConnection()
        {
            Console.WriteLine("Closing Oracle Connection");
        }

        public override void OpeningConnection()
        {
            Console.WriteLine("Opening Oracle Connection");
        }
    }
}
