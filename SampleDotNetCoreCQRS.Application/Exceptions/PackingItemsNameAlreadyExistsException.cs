namespace SampleDotNetCoreCQRS.Application.Exceptions
{
    public class PackingItemsNameAlreadyExistsException : SampleDotNetCoreCQRSException
    {
        public string Name { get; }
        public PackingItemsNameAlreadyExistsException(string name) : base($"Packing list with name {name} already exists")
            => Name = name;
    }
}
