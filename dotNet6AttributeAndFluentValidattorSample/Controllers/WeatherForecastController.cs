using DotNet6AttributeAndFluentValidationSample.Infrastructure.Attribute;
using DotNet6AttributeAndFluentValidationSample.Models.parameter;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

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
        /// �˪OAPI
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
        /// ����FluentValidation
        /// </summary>
        /// <param name="parameter">���հѼ�</param>
        [HttpPost("TestFluentValidation")]
        [TestParameter()]
        public string TestFluentValidation(TestParameter parameter)
        {
            var str = "00123";

            return str;
        }
    }
}