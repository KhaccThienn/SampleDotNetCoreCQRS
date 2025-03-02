﻿namespace SampleDotNetCoreCQRS.Domain.Policies.Temperature
{
    internal sealed class LowTemperaturePolicy : IPackingItemPolicy
    {
        public bool IsApplicable(PolicyData data)
            => data.Temperature < 10D;

        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Winter hat", 1),
                new("Scarf", 1),
                new("Gloves", 1),
                new("Hoodie", 1),
                new("Warm jacket", 1),
            };
    }
}
