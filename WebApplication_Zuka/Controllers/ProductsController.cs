using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Zuka.Models;

namespace WebApplication_Zuka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private static List<Product> productList = new List<Product>
        {
            new Product { Title = "Apple iPhone 14", Category = "Electronics", Price = 999.99m },
            new Product { Title = "Samsung Galaxy S23", Category = "Electronics", Price = 849.49m },
            new Product { Title = "Sony WH-1000XM5 Headphones", Category = "Audio", Price = 389.00m },
            new Product { Title = "Dell XPS 13 Laptop", Category = "Computers", Price = 1299.00m },
            new Product { Title = "Nike Air Max 270", Category = "Footwear", Price = 159.99m },
            new Product { Title = "Adidas Ultraboost 22", Category = "Footwear", Price = 179.99m },
            new Product { Title = "Levi's 501 Original Jeans", Category = "Clothing", Price = 89.50m },
            new Product { Title = "Ray-Ban Aviator Sunglasses", Category = "Accessories", Price = 154.99m },
            new Product { Title = "Apple Watch Series 9", Category = "Wearables", Price = 429.00m },
            new Product { Title = "Logitech MX Master 3S Mouse", Category = "Computer Accessories", Price = 99.99m },
            new Product { Title = "HP Envy 6055e Printer", Category = "Office", Price = 149.99m },
            new Product { Title = "KitchenAid Stand Mixer", Category = "Home Appliances", Price = 399.99m },
            new Product { Title = "Philips AirFryer XXL", Category = "Home Appliances", Price = 299.90m },
            new Product { Title = "The North Face Backpack", Category = "Travel", Price = 119.99m },
            new Product { Title = "Sony PlayStation 5", Category = "Gaming", Price = 499.99m },
        };


        [HttpGet]

        public List<Product> GetProducts()
        {
            return productList;
        }


        [HttpGet("Details/{productId}")]

        public Product GetProductById(int productId)
        {
            var product = productList.FirstOrDefault(p => p.Id == productId);

            return product;
        }

        [HttpGet("GetByTitle/{productTitle}")]

        public Product GetByTitle(string productTitle)
        {
            var products = productList.FirstOrDefault(p => p.Title.ToLower().Contains(productTitle.ToLower()));

            return products;
        }

        [HttpGet("Filter")]

        public List<Product> FilterProducts(string title, string category, int price)
        {
            var products = productList
                .Where(p =>
                 p.Title.ToLower().Contains(title.ToLower()) ||
                 p.Category.ToLower().Contains(category.ToLower()) ||
                 p.Price == 0 || p.Price <= price).ToList();

            return products;
        }

    }
}

