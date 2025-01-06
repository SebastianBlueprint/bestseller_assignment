using System.Text.Json.Serialization;

namespace ProductLogicService.Library.Models;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public required double Price { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Stars { get; set; }
}

public class ProductDTO
{
    public required string Name { get; set; }
    public required double Price { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Stars { get; set; }
}