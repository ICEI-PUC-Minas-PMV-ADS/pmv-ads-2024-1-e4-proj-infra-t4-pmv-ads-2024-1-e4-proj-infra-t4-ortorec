namespace API_Recomecar_Login.Models
{
    public class LinkDto
    {
        public int Id { get; set; }
        public string Href { get; set; }
        public string Rel { get; set; }
        public string Method { get; set; }

        public LinkDto(int id, string href, string rel, string method)
        {
            Id = id;
            Href = href;
            Rel = rel;
            Method = method;
        }
    }

    public class LinksHATEOS
    {
        public List<LinkDto> Links { get; set; } = new List<LinkDto>();
    }
}
