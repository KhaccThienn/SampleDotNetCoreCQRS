namespace SampleDotNetCoreCQRS.Domain.Policies
{
    public record PolicyData(TravelDays Days, Const.Gender Gender, ValueObjects.Temperature Temperature, Localization Localization);
}
