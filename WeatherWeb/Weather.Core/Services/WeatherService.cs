using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core.Models;
using Weather.Core.Services.Interfaces;
using Weather.DAL.DataAccess;
using Weather.DAL.Interfaces;
using Weather.DAL.Models;

namespace Weather.Core.Services
{
    public class WeatherService : EntityService<WeatherData>, IWeatherService
    {
        public WeatherService(WeatherContext context) : base(context)
        {
        }

        public ServiceResult AddWeather(WeatherData weather)
        {
            return Create(weather);
        }

        public IEnumerable<WeatherData> GetForLastTwoHours(int id)
        {
            var now = DateTime.Now;
            return _ctx.Weather.Where(w => w.Id == id
                                            && (w.CreatedOn < now && w.CreatedOn >= now.AddHours(-2)))
                        .AsEnumerable();
        }

        public IEnumerable<MinTemp> GetMinTemp()
        {
            return _ctx.Weather.Where(w => w == w)
                .GroupBy(g => new { g.Country, g.City })
                .Select(
                    s => new MinTemp
                    {
                        Country = s.Key.Country,
                        City = s.Key.City,
                        MinTempValue = s.Min(t => t.Temperature)
                    }
                )
                .AsEnumerable();
        }

        IEnumerable<WeatherData> IWeatherService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
