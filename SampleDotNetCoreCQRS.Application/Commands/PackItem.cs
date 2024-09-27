namespace SampleDotNetCoreCQRS.Application.Commands
{
    public record PackItem(Guid PackingListId, string Name) : ICommand;
}
