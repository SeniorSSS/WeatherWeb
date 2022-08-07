using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core.Models;
using Weather.DAL.Models;

namespace Weather.Core.Services.Interfaces
{
    public interface IWeatherService
    {
        IEnumerable<WeatherData> GetAll();
        ServiceResult AddWeather(WeatherData weather);
        IEnumerable<WeatherData> GetForLastTwoHours(int id);
        IEnumerable<MinTemp> GetMinTemp();  
    }
}
