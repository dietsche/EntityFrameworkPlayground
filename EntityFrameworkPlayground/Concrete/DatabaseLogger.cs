using System;
using EntityFrameworkPlayground.Abstract;

namespace EntityFrameworkPlayground.Concrete
{
    public class DatabaseLogger : ILogger, IDisposable
    {
        private readonly NorthwindEntities _entities;

        public DatabaseLogger()
        {
            _entities = new NorthwindEntities();
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }

        public void Log(string message)
        {
            throw new NotImplementedException();
        }

        public void Log(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}