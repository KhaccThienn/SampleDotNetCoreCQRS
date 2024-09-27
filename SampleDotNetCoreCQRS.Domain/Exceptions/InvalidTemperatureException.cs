namespace SampleDotNetCoreCQRS.Domain.Exceptions
{
    public class InvalidTemperatureException : SampleDotNetCoreCQRSException
    {
        public double Value { get; }
        public InvalidTemperatureException(double value) : base($"Value {value} is invalid temperature")
            => Value = value;
    }
}
