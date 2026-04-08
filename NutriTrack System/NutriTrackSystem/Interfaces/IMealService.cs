using System;
using System.Collections.Generic;
using System.Text;
using NutriTrackSystem.Models;

namespace NutriTrackSystem.Interfaces
{
    /// <summary>
    /// Define the contract for meal management services, including methods for retrieving and adding meal entries within the system.
    /// </summary>
    internal interface IMealService
    {
        List<Meal> GetMeals();
        void AddMeal(Meal meal);

        void DeleteMeal(string name, string username);

        void UpdateMeal(Meal updatedMeal);
    }
}
