namespace SampleDotNetCoreCQRS.Application.DTOs
{
    public class PackingItemDTO
    {
        public string       Name        { get; set; }
        public uint         Quantity    { get; set; }
        public bool         IsPacked    { get; set; }
    }
}
