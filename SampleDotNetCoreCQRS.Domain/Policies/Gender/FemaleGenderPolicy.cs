namespace SampleDotNetCoreCQRS.Domain.Policies.Gender
{
    internal sealed class FemaleGenderPolicy : IPackingItemPolicy
    {
        public bool IsApplicable(PolicyData data)
           => data.Gender is Const.Gender.Female;

        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Lipstick", 1),
                new("Powder", 1),
                new("Eyeliner", 1)
            };
    }
}
