namespace Domain;

public class Event
{
    public Guid EventId { get; set; }
    public string? Name { get; set; }
    public string? Text { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    
    public Guid ResourceId { get; set; }
    public Resource? Resource { get; set; }
    
}
