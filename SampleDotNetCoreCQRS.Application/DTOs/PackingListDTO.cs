namespace SampleDotNetCoreCQRS.Application.DTOs
{
    public class PackingListDTO
    {
        public Guid                         Id              { get; set; }
        public string                       Name            { get; set; }
        public Localization                 Localization    { get; set; }
        public IEnumerable<PackingItemDTO>  Items           { get; set; }
    }
}
