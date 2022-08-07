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
    public class EntityService<T> : DbService, IEntityService<T> where T : Entity
    {
        public EntityService(IWeatherContext context) : base(context) { }
        public virtual ServiceResult Create(T entity)
        {
            return Create<T>(entity);
        }
        public virtual IEnumerable<T> Get()
        {
            return Get<T>();
        }
        public virtual IQueryable<T> GetAll()
        {
            return Query<T>().Select(row => row);
        }
        public virtual IQueryable<T> Query()
        {
            return Query<T>();
        }
    }
}
