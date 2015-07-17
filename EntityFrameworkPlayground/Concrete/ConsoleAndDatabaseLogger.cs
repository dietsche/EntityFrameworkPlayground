using System;
using EntityFrameworkPlayground.Abstract;

namespace EntityFrameworkPlayground.Concrete
{
    public class ConsoleAndDatabaseLogger : ILogger
    {
        private readonly IConsoleLogger _consoleLogger;
        private readonly IDatabaseLogger _databaseLogger;

        public ConsoleAndDatabaseLogger(IConsoleLogger consoleLogger, IDatabaseLogger databaseLogger)
        {
            _consoleLogger = consoleLogger;
            _databaseLogger = databaseLogger;
        }

        public void Log(string message)
        {
            _consoleLogger.Log(message);
            _databaseLogger.Log(message);
        }

        public void Log(Exception exception)
        {
            _consoleLogger.Log(exception);
            _databaseLogger.Log(exception);
        }
    }
}