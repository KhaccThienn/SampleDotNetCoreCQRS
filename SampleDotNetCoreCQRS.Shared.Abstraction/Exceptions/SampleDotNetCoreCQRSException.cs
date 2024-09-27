namespace SampleDotNetCoreCQRS.Shared.Abstraction.Exceptions
{
    public abstract class SampleDotNetCoreCQRSException : Exception
    {
        protected SampleDotNetCoreCQRSException(string message) : base(message)
        {

        }
    }
}
