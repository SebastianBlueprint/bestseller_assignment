using Microsoft.AspNetCore.Mvc;
using ProductLogicService.Models;
using ProductLogicService.Interfaces;

namespace ProductLogicService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductsService _productsService;

    public ProductsController(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts(CancellationToken cancellationToken)
    {
        return await _productsService.GetProductsAsync(cancellationToken);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(string id, CancellationToken cancellationToken)
    {
        if (Guid.TryParse(id, out Guid guid))
            return await _productsService.GetProductAsync(guid, cancellationToken);

        return new BadRequestObjectResult("Id was not a valid Guid");
    }

    [HttpPost]
    public async Task<ActionResult<string>> PostProduct([FromBody] Product newProduct, CancellationToken cancellationToken)
    {
        return await _productsService.PostProductAsync(newProduct, cancellationToken);
    }
}