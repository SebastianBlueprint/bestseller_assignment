using ProductLogicService.Models;

namespace ProductLogicService.Interfaces;

public interface IProductsService
{
    Task<List<Product>> GetProductsAsync(CancellationToken cancellationToken = default);

    Task<Product> GetProductAsync(Guid id, CancellationToken cancellationToken = default);

    Task<string> PostProductAsync(Product newProduct, CancellationToken cancellationToken = default);
}