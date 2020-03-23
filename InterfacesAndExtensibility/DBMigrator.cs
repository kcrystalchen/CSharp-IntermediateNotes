using System;

namespace InterfacesAndExtensibility
{
    public class DBMigrator
    {
        private readonly ILogger _logger;  // create a field for Interface ILogger _Logger


        // create a DBMigrator constructor with passing ILoger, 
        // so the passed in ILoger logger that _logger will have ILoger's access
        public DBMigrator(ILogger logger)  
        {
            _logger = logger;
        }


        public void Migrate()  // using _loger to get ILoger interface methods access
        {
            _logger.LoggerInfo("Migration started at " + DateTime.Now);
            _logger.LoggerInfo("Migration ended at " + DateTime.Now);

            // Details of migrating the database
            //Console.WriteLine("Migration started at {0} ", DateTime.Now);
            //Console.WriteLine("Migration finished at {0} ", DateTime.Now);
        }

    }
}
