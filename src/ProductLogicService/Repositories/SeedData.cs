using ProductLogicService.Models;

namespace ProductLogicService.Repositories;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = serviceProvider.GetRequiredService<ProductDbContext>();

        context.Database.EnsureCreated();

        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product
                {
                    Name = "Wireless Headphones",
                    Price = 59.99,
                    Description = "High-quality over-ear wireless headphones with noise cancellation.",
                    Image = "https://example.com/images/headphones.jpg",
                    Stars = "4.5"
                },
                new Product
                {
                    Name = "Smartwatch",
                    Price = 199.99,
                    Description = "Fitness tracking smartwatch with heart rate monitor.",
                    Image = "https://example.com/images/smartwatch.jpg",
                    Stars = "4.7"
                },
                new Product
                {
                    Name = "Gaming Mouse",
                    Price = 39.99,
                    Description = "Ergonomic gaming mouse with RGB lighting and customizable buttons.",
                    Image = "https://example.com/images/mouse.jpg",
                    Stars = "4.3"
                },
                new Product
                {
                    Name = "4K Monitor",
                    Price = 299.99,
                    Description = "27-inch 4K Ultra HD monitor with HDR support.",
                    Image = "https://example.com/images/monitor.jpg",
                    Stars = "4.6"
                },
                new Product
                {
                    Name = "Bluetooth Speaker",
                    Price = 49.99,
                    Description = "Portable Bluetooth speaker with excellent sound quality.",
                    Image = "https://example.com/images/speaker.jpg",
                    Stars = "4.2"
                },
                new Product
                {
                    Name = "Laptop Stand",
                    Price = 29.99,
                    Description = "Adjustable aluminum laptop stand for ergonomic workspace.",
                    Image = "https://example.com/images/stand.jpg",
                    Stars = "4.8"
                },
                new Product
                {
                    Name = "USB-C Hub",
                    Price = 24.99,
                    Description = "Multi-port USB-C hub with HDMI, USB 3.0, and SD card support.",
                    Image = "https://example.com/images/hub.jpg",
                    Stars = "4.4"
                },
                new Product
                {
                    Name = "Mechanical Keyboard",
                    Price = 79.99,
                    Description = "Compact mechanical keyboard with customizable RGB lighting.",
                    Image = "https://example.com/images/keyboard.jpg",
                    Stars = "4.5"
                },
                new Product
                {
                    Name = "External SSD",
                    Price = 99.99,
                    Description = "1TB external SSD with fast data transfer speeds.",
                    Image = "https://example.com/images/ssd.jpg",
                    Stars = "4.9"
                },
                new Product
                {
                    Name = "Noise Cancelling Earbuds",
                    Price = 89.99,
                    Description = "True wireless earbuds with active noise cancellation.",
                    Image = "https://example.com/images/earbuds.jpg",
                    Stars = "4.6"
                }
            );
            context.SaveChanges();
        }
    }
}