namespace Domain;

public class Home
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    
    public ICollection<Event>? Events { get; set; }
    
    public ICollection<HomeResource>? HomeResource { get; set; }
}