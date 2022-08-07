using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.DAL.Models;

namespace Weather.Core.Services.Interfaces
{
    public interface IDbService
    {
        IQueryable<T> Query<T>() where T : Entity;
        IEnumerable<T> Get<T>() where T : Entity;
        ServiceResult Create<T>(T entity) where T : Entity;

    }
}
