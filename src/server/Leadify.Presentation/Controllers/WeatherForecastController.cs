using Leadify.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Leadify.Presentation.Controllers;


public class WeatherForecastController(ISender sender) : ApiController(sender)
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };



    [HttpGet()]
#pragma warning disable CA5394 // Do not use insecure randomness
    public Task<IActionResult> Get ()
    {
       WeatherForecast[] result =  Enumerable
            .Range(1, 5)
            .Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
       
       return Task.FromResult<IActionResult>(Ok(result));
    } 
        
#pragma warning restore CA5394 // Do not use insecure randomness
}
