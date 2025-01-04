using ProductLogicService.Library.Models;
using ProductLogicService.Repositories;
using ProductLogicService.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ProductLogicService.Services;

public class ProductsService : IProductsService
{
    private readonly ProductDbContext _productDbContext;

    public ProductsService(ProductDbContext productDbContext)
    {
        _productDbContext = productDbContext;
    }
    public async Task<List<Product>> GetProductsAsync(CancellationToken cancellationToken = default)
    {
        var products = await _productDbContext.Products.ToListAsync(cancellationToken);

        ArgumentNullException.ThrowIfNull(products);

        return products;
    }

    public async Task<Product> GetProductAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var product = await _productDbContext.Products.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        ArgumentNullException.ThrowIfNull(product);

        return product;
    }

    public async Task<string> PostProductAsync(Product newProduct, CancellationToken cancellationToken)
    {
        await _productDbContext.Products.AddAsync(newProduct, cancellationToken);
        await _productDbContext.SaveChangesAsync();

        string baseurl = Environment.GetEnvironmentVariable("ASPNETCORE_URLS") ?? "";
        string responsePath = $"{baseurl}/api/products/{newProduct.Id}";

        return responsePath;
    }
}