namespace Domain;

public class HomeResource
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Text { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    
    public Guid ResourceId { get; set; }
    public Resource? Resource { get; set; }
    
    public Guid HomeId { get; set; }
    public Home? Home { get; set; }
}