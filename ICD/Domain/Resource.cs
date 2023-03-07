namespace Domain;

public class Resource
{
    public Guid ResourceId { get; set; }
    public string? Name { get; set; }
    public string? Group { get; set; }

    public ICollection<Event>? Events { get; set; }
    public ICollection<HomeResource>? HomeResources { get; set; }
}