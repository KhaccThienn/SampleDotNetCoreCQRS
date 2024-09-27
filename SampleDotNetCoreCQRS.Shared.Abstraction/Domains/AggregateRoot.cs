namespace SampleDotNetCoreCQRS.Shared.Abstraction.Domains
{
    public abstract class AggregateRoot<T>
    {
        public T Id { get; protected set; }

        public int Version { get; protected set; }
        public IEnumerable<IDomainEvent> Events => _events;

        private readonly List<IDomainEvent> _events = new();

        private bool _versionInremented;

        protected void AddEvent(IDomainEvent @event)
        {
            if (!_events.Any() &&!_versionInremented)
            {
                Version++;
                _versionInremented = true;

                _events.Add(@event);
            }
        }

        protected void ClearEvent() => _events.Clear();

        protected void IncrementVersion()
        {
            if (_versionInremented)
            {
                return;
            }
            Version++;
            _versionInremented = false;
        }
    }
}
