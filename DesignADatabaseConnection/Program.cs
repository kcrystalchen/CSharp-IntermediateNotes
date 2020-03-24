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
            SqlConnection sqlConnection = new SqlConnection("passing connection string");
            OracleConnection oracleConnection = new OracleConnection("passing connection string");
            sqlConnection.OpeningConnection();
            sqlConnection.ClosingConnection();
            oracleConnection.OpeningConnection();
            oracleConnection.ClosingConnection();


        }
    }
}
