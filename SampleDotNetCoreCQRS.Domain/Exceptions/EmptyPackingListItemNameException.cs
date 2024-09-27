namespace SampleDotNetCoreCQRS.Domain.Exceptions
{
    public class EmptyPackingListItemNameException : SampleDotNetCoreCQRSException
    {
        public EmptyPackingListItemNameException() : base("Packing item name cannot be empty")
        {
        }
    }
}
