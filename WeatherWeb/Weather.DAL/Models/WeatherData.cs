using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.DAL.Models
{
    public class WeatherData : Entity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public float Temperature { get; set; }
        public float Wind { get; set; }
        public int Cloud { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public DateTime CreatedOn { get; set; }
        
    }
}
