using System;
using System.Collections.Generic;
using System.Linq;
using DiSample;
using DiSample.Models;

namespace DiSample.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetForecasts(int count = 5);
    }

    internal class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries =
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild",
            "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> GetForecasts(int count = 5)
        {
            return Enumerable.Range(1, count).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}