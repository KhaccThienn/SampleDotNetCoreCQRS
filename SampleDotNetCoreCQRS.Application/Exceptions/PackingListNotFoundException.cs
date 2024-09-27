namespace SampleDotNetCoreCQRS.Application.Exceptions
{
    public class PackingListNotFoundException : SampleDotNetCoreCQRSException
    {
        public Guid Id { get; }

        public PackingListNotFoundException(Guid id) : base($"Packing list with ID '{id}' was not found.")
            => Id = id;
    }
}
