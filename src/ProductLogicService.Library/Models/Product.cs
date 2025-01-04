namespace ProductLogicService.Library.Models;

public class Product
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required double Price { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Stars { get; set; }
}