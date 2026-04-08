using System;
using System.Collections.Generic;
using System.Text;

namespace NutriTrackSystem.Models
{
    public class MealProduct
    {
        public string Name { get; set; }

        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }

        public double Quantity { get; set; }
    }
}
