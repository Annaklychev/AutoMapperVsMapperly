namespace AutoMapperVsMapperly;

public class User
{
    public int Id { get; set; }
    public Guid ExternalId { get; set; }
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
    public decimal Balance { get; set; }
    public double Rating { get; set; }
    public int LoginCount { get; set; }
    public DateOnly BirthDate { get; set; }
}