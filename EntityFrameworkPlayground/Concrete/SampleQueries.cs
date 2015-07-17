using System;
using System.Linq;
using EntityFrameworkPlayground.Abstract;

namespace EntityFrameworkPlayground.Concrete
{
    public class SampleQueries : ISampleQueries, IDisposable
    {
        private readonly NorthwindEntities _entities;
        private readonly ILogger _logger;

        public SampleQueries(ILogger logger)
        {
            _logger = logger;
            _entities = new NorthwindEntities();
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }

        /// <summary>
        ///     PRINCIPLE: A function should do one thing and do it well.
        ///     Why is this function coded this way?
        /// </summary>
        public void RunExample()
        {
            try
            {
                SampleSelect();
                //SampleAdd();
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
            }
        }

        private void SampleSelect()
        {
            var query = _entities.Regions.OrderBy(r => r.RegionDescription);

            foreach (var curRegion in query)
            {
                _logger.Log(curRegion.RegionDescription);
            }
        }

        private void SampleAdd()
        {
            var newRegion = new Region
            {
                RegionDescription = "Minnesota"
            };

            _entities.Regions.Add(newRegion);
            _entities.SaveChanges();

            SampleSelect();
        }
    }
}