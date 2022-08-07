using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.DAL.Interfaces;
using Weather.DAL.Models;

namespace Weather.DAL.DataAccess
{
    public class WeatherContext : DbContext, IWeatherContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options) { }
        public DbSet<WeatherData> Weather { get; set; }
    }
}
