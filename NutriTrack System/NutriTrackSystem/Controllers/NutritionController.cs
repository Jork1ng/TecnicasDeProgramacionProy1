using NutriTrackSystem.Models;

namespace NutriTrackSystem.Controllers
{
    public class NutritionController
    {
        public double CalculateIMC(User user)
        {
            double heightMeters = user.Height / 100.0;
            return user.Weight / (heightMeters * heightMeters);
        }

        public double CalculateCalories(User user)
        {
            double factor = user.ActivityLevel switch
            {
                "Minima" => 25,
                "Moderada" => 30,
                "Intensa" => 35,
                _ => 25
            };

            double calories = user.Weight * factor;

            switch (user.HealthGoals)
            {
                case "Perder peso":
                    calories -= 300;
                    break;

                case "Ganar masa":
                    calories += 300;
                    break;

                case "Mantener":
                    break;
            }

            return calories;
        }

        public (double protein, double carbs, double fats) CalculateMacros(User user)
        {
            double calories = CalculateCalories(user);

            double proteinPercent = 0;
            double carbsPercent = 0;
            double fatsPercent = 0;

            switch (user.DietaryPreferences)
            {
                case "Estandar":
                    proteinPercent = 0.30;
                    carbsPercent = 0.40;
                    fatsPercent = 0.30;
                    break;

                case "Keto":
                    proteinPercent = 0.30;
                    carbsPercent = 0.10;
                    fatsPercent = 0.60;
                    break;

                case "Vegetariana":
                    proteinPercent = 0.25;
                    carbsPercent = 0.50;
                    fatsPercent = 0.25;
                    break;
            }

            double protein = (calories * proteinPercent) / 4;
            double carbs = (calories * carbsPercent) / 4;
            double fats = (calories * fatsPercent) / 9;

            return (protein, carbs, fats);
        }
    }
}