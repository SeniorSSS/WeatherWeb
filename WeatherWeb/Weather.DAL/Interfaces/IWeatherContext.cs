using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.DAL.Models;

namespace Weather.DAL.Interfaces
{
    public interface IWeatherContext
    {
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        DbSet<WeatherData> Weather { get; set; }
    }
}
