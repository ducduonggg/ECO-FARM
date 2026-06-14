namespace QLNongSan.Products.Services
{
    using Schemas;

    public interface ICatalogService
    {
        public List<CatalogDTO> GetCatalogs();
        public CatalogDTO GetCatalogById(Guid id);
        public CatalogDTO CreateCatalog(CreateCatalogParams create_params);
        public CatalogDTO UpdateCatalog(UpdateCatalogParams update_params);
        public void DeleteCatalog(Guid id);
    }
}