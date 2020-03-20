using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            DBMigrator dbMigrator = new DBMigrator(new Logger());// creating dbMigrator and pass the Logger Object => new Logger()

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}
 