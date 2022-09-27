using DotNet6AttributeAndFluentValidationSample.Models.parameter;
using Microsoft.AspNetCore.Mvc;

namespace dotNet6AttributeAndFluentValidattorSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 妓狾API
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// 代刚FluentValidation
        /// </summary>
        /// <param name="parameter">代刚把计</param>
        [HttpGet("TestFluentValidation")]
        public void TestFluentValidation(TestParameter parameter)
        {
 
        }
    }
}