using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.DataReader.Models
{

    public class WeatherApiComResponse
    {
            public Location location { get; set; }
            public Current current { get; set; }
    }

        public class Location
        {
            public string name { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public float lat { get; set; }
            public float lon { get; set; }
            public string tz_id { get; set; }
            public int localtime_epoch { get; set; }
            public string localtime { get; set; }
        }

        public class Current
        {
            public string last_updated { get; set; }
            public float temp_c { get; set; }
            public Condition condition { get; set; }
            public float wind_kph { get; set; }
            public int cloud { get; set; }
            public float uv { get; set; }
        }

        public class Condition
        {
        }

    
}
