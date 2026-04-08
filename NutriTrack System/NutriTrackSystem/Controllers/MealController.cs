using NutriTrackSystem.Interfaces;
using NutriTrackSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace NutriTrackSystem.Controllers
{
    /// <summary>
    /// Provides operations for managing meal data, including retrieving and adding meals.
    /// </summary>
    public class MealController : IMealService
    {
        private string GetFilePath()
        {
            string directory = Path.Combine(Directory.GetCurrentDirectory(), "Data");

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            return Path.Combine(directory, "meals.json");
        }

        /// <summary>
        /// gets the list of meals from the JSON file. If the file does not exist, it creates an empty file and returns an empty list.
        /// </summary>
        public List<Meal> GetMeals()
        {
            string path = GetFilePath();

            if (!File.Exists(path))
                File.WriteAllText(path, "[]");

            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<List<Meal>>(json) ?? new List<Meal>();
        }

        /// <summary>
        /// Adds a new meal to the collection and persists the updated list to storage.
        /// </summary>
        public void AddMeal(Meal meal)
        {
            var meals = GetMeals();

            meals.Add(meal);

            string json = JsonSerializer.Serialize(meals, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(GetFilePath(), json);
        }
        /// <summary>
        /// Deletes a meal entry for the specified user by meal name.
        /// </summary>
        public void DeleteMeal(string name, string username)
        {
            var meals = GetMeals();

            var meal = meals.FirstOrDefault(m => m.Name == name && m.Username == username);

            if (meal != null)
            {
                meals.Remove(meal);

                string json = JsonSerializer.Serialize(meals, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(GetFilePath(), json);
            }
        }
        /// <summary>
        /// Updates the products of an existing meal for a specific user.
        /// </summary>
        public void UpdateMeal(Meal updatedMeal)
        {
            var meals = GetMeals();

            var meal = meals.FirstOrDefault(m =>
                m.Name == updatedMeal.Name &&
                m.Username == updatedMeal.Username);

            if (meal != null)
            {
                meal.Products = updatedMeal.Products;

                string json = JsonSerializer.Serialize(meals, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(GetFilePath(), json);
            }
        }
    }
}

