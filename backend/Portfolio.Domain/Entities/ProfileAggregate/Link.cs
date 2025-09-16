namespace Portfolio.Domain.Entities.ProfileAggregate;

public class Link
{
    public int Id { get; set; }
    public string Label { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string? Icon { get; set; }

    public int ProfileId { get; set; }
    public Profile Profile { get; set; } = null!;
}
