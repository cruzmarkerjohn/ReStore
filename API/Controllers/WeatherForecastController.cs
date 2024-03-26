using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new []
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var forecast = Enumerable.Range(1,5).Select(i => new WeatherForecast
            {
                date = DateOnly.FromDateTime(DateTime.Now.AddDays(i)).ToString(),
                temperatureC = Random.Shared.Next(-22, 55),
                summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            return forecast;
        }
    }
}