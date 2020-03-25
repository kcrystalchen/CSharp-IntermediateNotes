using System.IO;

namespace InterfacesAndExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _loggerPath;

        public FileLogger(string loggerPath)
        {
            _loggerPath = loggerPath;
        }


        public void LoggerError(string message)
        {
            Log("Error ",  message);
        }


        public void LoggerInfo(string message)
        {
            Log("LoggerInfo", message);
        }



        private void Log(string messageType, string message)
        {
            using (var streamWriter = new StreamWriter(_loggerPath, true))
            {
                streamWriter.WriteLine(messageType + " : " + message);
                streamWriter.Dispose();
            }
        }
    }
}
