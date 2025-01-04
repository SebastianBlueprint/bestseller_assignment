using Microsoft.EntityFrameworkCore;
using ProductLogicService.Library.Models;

namespace ProductLogicService.Repositories;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

    public required DbSet<Product> Products { get; set; }
}