using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Weather.Core.Services.Interfaces;
using Weather.DAL.Models;
using WeatherWeb.Models;

namespace WeatherWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherService _weatherService;

        public HomeController(ILogger<HomeController> logger, IWeatherService weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            //var a = _weatherService.GetAll();
            var b = new WeatherData()
            {
                Country = "Latvia",
                City = "Riga",
                Temperature = 22,
                Wind = 5,
                Cloud = 0,
                LastUpdateTime = DateTime.Now,
                CreatedOn = DateTime.Now
            };

            _weatherService.AddWeather(b);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}