namespace Domain;

public class Resource
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Group { get; set; }

    
    public ICollection<Event> Events { get; set; }
    public ICollection<Event>? HomeResource { get; set; }
}