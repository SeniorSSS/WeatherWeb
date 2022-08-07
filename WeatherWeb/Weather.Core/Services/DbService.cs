using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core.Services.Interfaces;
using Weather.DAL.Interfaces;
using Weather.DAL.Models;

namespace Weather.Core.Services
{
    public class DbService : IDbService
    {
        protected readonly IWeatherContext _ctx;

        public DbService(IWeatherContext ctx)
        {
            ctx = _ctx;
        }
        public ServiceResult Create<T>(T entity) where T : Entity
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            _ctx.Set<T>().Add(entity);
            _ctx.SaveChanges();

            return new ServiceResult(true).Set(entity);
        }

        public IEnumerable<T> Get<T>() where T : Entity
        {
            return Query<T>().ToList();
        }

        public IQueryable<T> Query<T>() where T : Entity
        {
            return _ctx.Set<T>().AsQueryable();
        }
    }
}
