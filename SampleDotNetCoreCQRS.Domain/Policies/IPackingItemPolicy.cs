namespace SampleDotNetCoreCQRS.Domain.Policies
{
    public interface IPackingItemPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<PackingItem> GenerateItems(PolicyData data);
    }
}
