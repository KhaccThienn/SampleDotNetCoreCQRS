namespace SampleDotNetCoreCQRS.Domain.Exceptions
{
    public class EmptyPackingListNameException : SampleDotNetCoreCQRSException
    {
        public EmptyPackingListNameException() : base("Packing list name cannot be empty")
        {
        }
    }
}
