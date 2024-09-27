namespace SampleDotNetCoreCQRS.Domain.Exceptions
{
    public class EmptyPackingListIdException : SampleDotNetCoreCQRSException
    {
        public EmptyPackingListIdException() : base("Packing list id cannot be empty")
        {
        }
    }
}
