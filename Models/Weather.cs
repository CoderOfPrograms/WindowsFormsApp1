using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    public class Weather
    {
        public int temperature { get; set; }
        public int high { get; set; }
        public int low { get; set; }
        public int feelsLike { get; set; }
        public int wind { get; set; }
        public String clouds { get; set; }
    }
}
