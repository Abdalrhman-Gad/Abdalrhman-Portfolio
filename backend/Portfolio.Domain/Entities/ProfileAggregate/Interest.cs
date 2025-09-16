namespace Portfolio.Domain.Entities.ProfileAggregate;

public class Interest
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;
}
