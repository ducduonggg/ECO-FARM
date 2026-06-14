namespace QLNongSan.Products.Errors
{
    public class GetCatalogsError(string message) : Exception(message)
    {
        // Error codes for different error modes
    }

    public class GetCatalogByIdError(string message) : Exception(message)
    {
        // Error codes for different error modes
    }

    public class CreateCatalogError(string message) : Exception(message)
    {
        // Error codes for different error modes
    }

    public class UpdateCatalogError(string message) : Exception(message)
    {
        // Error codes for different error modes
    }

    public enum DeleteCatalogErrorCode
    {
        NOT_FOUND,
    }

    public class DeleteCatalogError(string message) : Exception(message)
    {
        public required DeleteCatalogErrorCode ErrorCode { get; set; }
    }
}