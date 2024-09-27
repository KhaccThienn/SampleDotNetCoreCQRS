namespace SampleDotNetCoreCQRS.Application.Commands
{
    public record AddPackingItem(Guid PackingListId, string Name, uint Quantity) : ICommand;
}
