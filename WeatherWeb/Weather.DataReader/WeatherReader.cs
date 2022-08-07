using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Weather.Core.Services;
using Weather.DataReader.Models;

namespace Weather.DataReader
{
    public static class WeatherReader
    {
        

        private static readonly HttpClient client = new HttpClient();

        public static async Task Start(List<string> cities)
        {
            foreach (var city in cities)
            {
                client.DefaultRequestHeaders.Accept.Clear();
                var apiPath = $"http://api.weatherapi.com/v1/current.json?key=798915be4f0c44c396c101740220208&q={city}&aqi=no";
                //var streamTask = client.GetStreamAsync(apiPath);
                //var weather = await JsonSerializer.DeserializeAsync<WeatherApiComResponse>(await streamTask);


                var stringTask = client.GetStringAsync(apiPath);

                var msg = await stringTask;
                Console.Write(msg);

            }



            //get real data
            






            //save data








        }
    }
}
