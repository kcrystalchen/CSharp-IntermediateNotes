namespace Composition
{
    public class Installer
    {
        private readonly Logger _logger;  // creating logger private field

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing the application.");
        }
    }
}
 