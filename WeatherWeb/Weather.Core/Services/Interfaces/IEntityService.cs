using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.DAL.Models;

namespace Weather.Core.Services.Interfaces
{
    public interface IEntityService<T> where T : Entity
    {
        IQueryable<T> Query();
        IEnumerable<T> Get();
        ServiceResult Create(T entity);
    }
}
