namespace SampleDotNetCoreCQRS.Application.Commands
{
    public record RemovePackingList(Guid Id) : ICommand;
}
