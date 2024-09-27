namespace SampleDotNetCoreCQRS.Domain.Exceptions
{
    public class InvalidTravelDaysException : SampleDotNetCoreCQRSException
    {
        public ushort Days { get; }
        public InvalidTravelDaysException(ushort days) : base($"Value {days} is invalid travel days")
            => Days = days;
    }
}
