using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using NutriTrackSystem.Models;
using NutriTrackSystem.Interfaces;

namespace NutriTrackSystem.Controllers
{
    /// <summary>
    /// Provides operations for managing products, including retrieving and adding products to persistent storage.
    /// </summary>
    public class ProductController : IProductService
    {
        private string GetFilePath()
        {
            string directory = Path.Combine(Directory.GetCurrentDirectory(), "Data");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            return Path.Combine(directory, "products.json");
        }

        /// <summary>
        /// Retrieves the list of products from persistent storage.
        /// </summary>
        public List<Product> GetProducts()
        {
            string path = GetFilePath();

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]");
            }

            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

        /// <summary>
        /// Adds a product to the collection and persists the updated list to storage.
        /// </summary>
        public void AddProduct(Product product)
        {
            var products = GetProducts();

            if (products.Any(p => p.Name == product.Name))
                return;

            products.Add(product);

            string json = JsonSerializer.Serialize(products, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(GetFilePath(), json);
        } 
    }
}
