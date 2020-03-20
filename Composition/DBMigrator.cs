namespace Composition
{
    public class DBMigrator  // this class responsible for migrating database
    {
        private readonly Logger _logger; // initialize field logger

        public DBMigrator(Logger logger) // creating association with Logger class
        {
            _logger = logger;
        }

        public void Migrate() // Migrate method
        {
            _logger.Log("We are migrating ......");
        }
    }
}
 