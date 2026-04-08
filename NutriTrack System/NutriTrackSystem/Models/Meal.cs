using System;
using System.Collections.Generic;
using System.Text;

namespace NutriTrackSystem.Models
{
    /// <summary>
    /// Represents a meal, including its name, type, associated user, and the collection of products that comprise the
    /// meal.
    /// </summary>
    public class Meal
    {
        /// <summary>
        /// Gets or sets the name associated with the meal
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of meal associated with this instance.
        /// </summary>
        public string MealType { get; set; } 

        /// <summary>
        /// Gets or sets the username associated with the user account.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the collection of products associated with this meal.
        /// </summary>
        public List<MealProduct> Products { get; set; } = new List<MealProduct>();
    }
}
