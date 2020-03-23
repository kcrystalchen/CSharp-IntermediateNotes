using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            DBMigrator dbMigrator0 = new DBMigrator(new ConsoleLogger());
            DBMigrator dbMigrator1 = new DBMigrator(new FileLogger(@"C:\Users\krystal.chen\Documents\CSharpIntermediateNotes\log.txt"));
            dbMigrator0.Migrate();
            dbMigrator1.Migrate();

        }
    }
}
