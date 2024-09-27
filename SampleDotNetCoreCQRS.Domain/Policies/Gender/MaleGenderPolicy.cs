namespace SampleDotNetCoreCQRS.Domain.Policies.Gender
{
    internal sealed class MaleGenderPolicy : IPackingItemPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new PackingItem("Laptop", 1),
                new PackingItem("Beer", 10),
                new PackingItem("Book", (uint) Math.Ceiling(data.Days / 7m)),
            };

        public bool IsApplicable(PolicyData data)
            => data.Gender is Const.Gender.Male;

    }
}
