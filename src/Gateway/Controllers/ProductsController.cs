using Microsoft.AspNetCore.Mvc;
using ProductLogicService.Library.Models;
using Gateway.Interfaces;

namespace Gateway.Controllers;

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
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        return await _productsService.GetProductsAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(string id)
    {
        return await _productsService.GetProductAsync(id);
    }

    [HttpPost]
    public async Task<ActionResult<string>> PostProduct([FromBody] ProductDTO newProductDTO)
    {
        return await _productsService.PostProductAsync(newProductDTO);
    }
}