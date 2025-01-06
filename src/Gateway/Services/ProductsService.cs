using ProductLogicService.Library.Models;
using Gateway.Interfaces;
using Flurl.Http;
using Flurl;

namespace Gateway.Services;

public class ProductsService : IProductsService
{
    private readonly string BASEURL = "http://localhost:5082";

    public async Task<List<Product>> GetProductsAsync()
    {
        var products = await $"{BASEURL}".AppendPathSegments("api", "products").GetJsonAsync<List<Product>>();

        ArgumentNullException.ThrowIfNull(products);

        return products;
    }

    public async Task<Product> GetProductAsync(string id)
    {
        var product = await $"{BASEURL}".AppendPathSegments("api", "products", id).GetJsonAsync<Product>();

        ArgumentNullException.ThrowIfNull(product);

        return product;
    }

    public async Task<string> PostProductAsync(ProductDTO newProductDTO)
    {
        Product newProduct = new Product
        {
            Id = Guid.NewGuid(),
            Name = newProductDTO.Name,
            Price = newProductDTO.Price,
            Description = newProductDTO.Description,
            Image = newProductDTO.Image,
            Stars = newProductDTO.Stars
        };
        
        var products = await $"{BASEURL}/api/products".PostJsonAsync(newProduct).ReceiveString();

        ArgumentNullException.ThrowIfNull(products);

        return products;
    }
}