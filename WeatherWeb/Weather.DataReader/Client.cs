using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Core.Services.Interfaces;

namespace Weather.DataReader
{
    public class Client
    {
        private readonly List<string> _countryCities = new List<string>()
        {
            {"Riga"},
            {"Liepaja"},
            {"London"}
        };

        public async Task Run()
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(1);

            var timer = new System.Threading.Timer(async (e) =>
            {
                await WeatherReader.Start(_countryCities);
            }, null, startTimeSpan, periodTimeSpan);

        }

    }
}
