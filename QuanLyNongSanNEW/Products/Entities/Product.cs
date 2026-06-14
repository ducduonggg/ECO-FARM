public class Product
{
    public required Guid Id { get; set; }
    public required Guid CatalogId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required DateTime CreatedAt { get; set; }

    public required string Manufacturer { get; set; }
    public required DateTime? ExpirationDate { get; set; }
}