namespace QLNongSan.Products.Schemas
{
    public class CatalogDTO
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required DateTime CreatedAt { get; set; }
    }

    public class CreateCatalogParams
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }

    public class UpdateCatalogParams
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}