namespace SampleDotNetCoreCQRS.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDTO> GetWeatherAsync(Localization localization);

    }
}
