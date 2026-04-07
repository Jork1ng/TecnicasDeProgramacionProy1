using System;
using System.Collections.Generic;
using System.Text;

namespace NutriTrackSystem.Models
{
    /// <summary>
    /// Represents a food product with nutritional values per 100g
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the name associated with the object.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the amount of protein, typically measured in grams.
        /// </summary>
        public double Protein { get; set; }
        /// <summary>
        /// Gets or sets the amount of carbohydrates associated with the item.
        /// </summary>
        public double Carbs { get; set; }
        /// <summary>
        /// Gets or sets the total amount of fats in grams.
        /// </summary>
        public double Fats { get; set; }
    }
}
