using System;
using System.Linq;
using System.Threading.Tasks;

public class WeatherForecast
{
    public DateTime Date { get; set; }
    public int temperatureC { get; set; }
    public int TemperatureF { get; set; }
    public string Summary { get; set; }
}

public class WeatherForecastService
{
    private static string[] summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild",
        "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        var rng = new Random();
        return Task.FromResult(Enumerable.Range(1, 5).Select(idx => new WeatherForecast
        {
            Date = startDate.AddDays(idx),
            temperatureC = rng.Next(-20, 55),
            Summary = summaries[rng.Next(summaries.Length)]
        }).ToArray());
    }
}

class WeatherForecastApp
{
    static async Task Main()
    {
        var service = new WeatherForecastService();
        var forecasts = await service.GetForecastAsync(DateTime.Now);

        await Console.Out.WriteLineAsync("Date\tTemp.  (C)\tTemp.  (F)\tSummary");
        foreach (var forecast in forecasts)
        {
            Console.WriteLine($"{forecast.Date.ToShortDateString()}\t" +
                $"{forecast.temperatureC}\t{forecast.TemperatureF}\t{forecast.Summary}");
        }
    }
} 