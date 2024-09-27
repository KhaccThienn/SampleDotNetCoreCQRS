namespace SampleDotNetCoreCQRS.Application.Queries
{
    public class GetPackingList : IQuery<PackingListDTO>
    {
        public Guid Id { get; set; }
    }
}
