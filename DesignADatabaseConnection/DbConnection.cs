using System;

namespace DesignADatabaseConnection
{
    public abstract class DbConnection  // DbConnection is too abstract, could not have implement in the methods
    {
        // 1. DbConnection will not be a valid state (class) if it does not have a connection string
        // 2. indicating DbConnection constructor needs to pass in ConnectionString property
        // 3. NULL and empty string will consider as not a valid connection string
        // 4. Throw an exception when it is not a valid DbConnection state (class)

        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        // 5. Two methods for opening and closing database as an abstract methods
        public DbConnection(string ConnectionString)  // DbConnection will not be a valid state (class) if it does not have a connection string
        {
            if (ConnectionString == null || ConnectionString == " " )
            {
                throw new InvalidOperationException("Connection String should not be NULL or empty string");
            }
        }




        // opening and closing connection both are abstract as need to understand which DbConnection is
        // so it will leave to derive classes to implement the methods, so the abstract class does not need implementation for the methods
        public abstract void OpeningConnection();
        

        public abstract void ClosingConnection(); // closing the connection once the job is done
 


    }
}
