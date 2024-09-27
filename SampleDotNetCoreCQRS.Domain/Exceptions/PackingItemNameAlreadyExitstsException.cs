namespace SampleDotNetCoreCQRS.Domain.Exceptions
{
    public class PackingItemNameAlreadyExitstsException : SampleDotNetCoreCQRSException
    {
        public PackingItemNameAlreadyExitstsException(string listName, string itemName)
            : base($"Packing List '{listName}' already defined item '{itemName}'")
        {
        }
    }
}
