using System;
using EntityFrameworkPlayground.Abstract;

namespace EntityFrameworkPlayground.Concrete
{
    public class ConsoleLogger : IConsoleLogger
    {
        public void Log(string message)
        {
            LogMessage(message);
        }

        public void Log(Exception exception)
        {
            LogMessage(exception.ToString());
        }

        private void LogMessage(string message)
        {
            Console.WriteLine("{0:g}\t{1}", DateTime.Now, message);
        }
    }
}