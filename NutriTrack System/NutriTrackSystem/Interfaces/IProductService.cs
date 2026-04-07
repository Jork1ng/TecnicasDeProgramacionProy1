using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.Generic;
using NutriTrackSystem.Models;

namespace NutriTrackSystem.Interfaces
{
    /// <summary>
    /// Defines operations for managing products, including retrieving and adding product entries.
    /// </summary>
    public interface IProductService
    {
        List<Product> GetProducts();
        void AddProduct(Product product);
    }
}
