namespace Domain;

public class Home
{
    public Guid HomeId { get; set; }
    public string? Name { get; set; }
    
    public ICollection<HomeResource>? HomeResources { get; set; }
}