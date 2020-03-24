using System;

namespace DesignADatabaseConnection
{
    public class DbCommand  // for executing an instruction against the database
    {
        // 1. needs to have a connection in order to have a valid state
        // 2. so it needs to create a constructor and pass in the DbConnection class (No Null)
        // 3. Each DbCommand should have an instruction (string) sends to the database
        // 4. Each command should be executable Execute() -> Open connection, Run instruction, Close connection

        public DbCommand()
        {
        }

        public DbCommand(DbConnection dbConnection)  // Needs the connection in order to send the valid command, pass in the DbConnection class 
        {
            if(String.IsNullOrEmpty(dbConnection.ConnectionString))
            {
                throw new InvalidOperationException("connection string is Null or Empty");
            }

        }

        // executable method for Open connection, Run instruction, Close connection
        public void SqlExecution()
        {
            Console.WriteLine("Enter Connection String: ");
            string connectionStringInput = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(connectionStringInput);
            sqlConnection.OpeningConnection();
            sqlConnection.ClosingConnection();
        }

        public void OracleExecution()
        {
            Console.WriteLine("Enter Connection String: ");
            string connectionStringInput = Console.ReadLine();

            OracleConnection oracleConnection = new OracleConnection(connectionStringInput);
            oracleConnection.OpeningConnection();
            oracleConnection.ClosingConnection();
        }



    }
}
