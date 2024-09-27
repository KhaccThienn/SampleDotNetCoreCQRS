namespace SampleDotNetCoreCQRS.Domain.ValueObjects
{
    public record Localization(string City, string Country)
    {
        public static Localization Create(string value)
        {
            var splitedLocalization = value.Split(",");
            return new Localization(splitedLocalization.First(), splitedLocalization.Last());
        }

        public override string ToString()
            => $"{City}, {Country}";
    }
}
