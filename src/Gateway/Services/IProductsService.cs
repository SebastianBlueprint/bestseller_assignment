using ProductLogicService.Library.Models;

namespace Gateway.Interfaces;

public interface IProductsService
{
    Task<List<Product>> GetProductsAsync();

    Task<Product> GetProductAsync(string id);

    Task<string> PostProductAsync(Product newProduct);
}