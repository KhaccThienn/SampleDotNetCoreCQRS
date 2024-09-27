namespace SampleDotNetCoreCQRS.Domain.Exceptions
{
    public class PackingItemNotFoundException : SampleDotNetCoreCQRSException
    {
        public string ItemName { get; }
        public PackingItemNotFoundException(string itemName) : base($"Packing item '{itemName}' was not found")
        => ItemName = itemName;
    }
}
