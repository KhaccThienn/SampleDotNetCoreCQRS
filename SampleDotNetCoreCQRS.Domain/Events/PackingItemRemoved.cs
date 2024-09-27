namespace SampleDotNetCoreCQRS.Domain.Events
{
    public record PackingItemRemoved(PackingList PackingList, PackingItem PackingItem) : IDomainEvent
    {
    }
}
