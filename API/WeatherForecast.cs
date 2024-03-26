using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class WeatherForecast
    {
        public string date { get; set; }
        public int temperatureC { get; set; }
        public string summary { get; set; }
        public int TemperatureF => 32 + (int)(temperatureC / 0.5556);
    }
}