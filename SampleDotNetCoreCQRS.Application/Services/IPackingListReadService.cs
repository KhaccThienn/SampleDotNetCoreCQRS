namespace SampleDotNetCoreCQRS.Application.Services
{
    public interface IPackingListReadService
    {
        Task<bool> ExistsByNameAsync(string name);
    }
}
