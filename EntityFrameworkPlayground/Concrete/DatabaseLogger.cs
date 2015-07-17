using System;
using EntityFrameworkPlayground.Abstract;

namespace EntityFrameworkPlayground.Concrete
{
    public class DatabaseLogger : IDatabaseLogger, IDisposable
    {
        private readonly NorthwindEntities _entities;

        public DatabaseLogger()
        {
            _entities = new NorthwindEntities();
        }

        public void Log(string message)
        {
            var log = new ErrorLog
            {
                Message = message,
                When = DateTime.Now
            };

            _entities.ErrorLogs.Add(log);
            _entities.SaveChanges();
        }

        public void Log(Exception exception)
        {
            var log = new ErrorLog
            {
                Message = exception.ToString(),
                When = DateTime.Now
            };

            _entities.ErrorLogs.Add(log);
            _entities.SaveChanges();
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}