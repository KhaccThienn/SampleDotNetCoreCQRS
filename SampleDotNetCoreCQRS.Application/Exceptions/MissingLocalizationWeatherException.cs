namespace SampleDotNetCoreCQRS.Application.Exceptions
{
    public class MissingLocalizationWeatherException : SampleDotNetCoreCQRSException
    {
        public MissingLocalizationWeatherException(Localization localization) 
            : base($"Couldn't fetch weather data for localization: '{localization.City} / {localization.Country}'")
        { }
    }
}
