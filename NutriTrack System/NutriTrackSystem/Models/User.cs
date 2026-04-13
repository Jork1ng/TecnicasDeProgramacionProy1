

namespace NutriTrackSystem.Models
{
    /// <summary>
    /// Model representing a user in the NutriTrack system
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        /// <value>
        /// The unique identifier for the user.
        /// </value>
        public string Username { get; set; }
        /// <summary>
        /// Gets or sets the password associated with the current user.
        /// </summary>
        /// <value>
        /// The password associated with the current user.
        /// </value>
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the weight value.
        /// </summary>
        /// <value>
        /// The weight value.
        /// </value>
        public double Weight { get; set; }
        /// <summary>
        /// Gets or sets the height value.
        /// </summary>
        /// <value>
        /// The height value.
        /// </value>
        public double Height { get; set; }
        /// <summary>
        /// Gets or sets the activity level associated with the User
        /// </summary>
        /// <value>
        /// The activity level associated with the User
        /// </value>
        public string ActivityLevel { get; set; }
        /// <summary>
        /// Gets or sets the dietary preferences of the user.
        /// </summary>
        /// <value>
        /// The dietary preferences of the user.
        /// </value>
        public string DietaryPreferences { get; set; }
        /// <summary>
        /// Gets or sets the user's health goals.
        /// </summary>
        /// <value>
        /// The user's health goals.
        public string HealthGoals { get; set; }
        /// <summary>
        /// The Body Mass Index (BMI) is a measure of body fat based on height and weight. It is calculated by dividing a person's weight in kilograms by the square of their height in meters. The BMI value can be used to categorize individuals into different weight status categories, such as underweight, normal weight, overweight, and obesity. A higher BMI may indicate a higher risk of health problems related to excess body fat, while a lower BMI may indicate a lower risk. However, it is important to note that BMI is not a perfect measure of body fat and does not take into account factors such as muscle mass or distribution of fat.
        /// </summary>
        public double BMI { get; set; }
        /// <summary>
        /// Gets or sets the total number of calories consumed or allocated for a single day.
        /// </summary>
        public double DailyCalories { get; set; }
        /// <summary>
        /// Gets or sets the amount of protein, in grams.
        /// </summary>
        public double ProteinGrams { get; set; }
        /// <summary>
        /// Gets or sets the amount of carbohydrates, in grams.
        /// </summary>
        public double CarbsGrams { get; set; }
        /// <summary>
        /// Gets or sets the amount of fats, in grams.
        /// </summary>
        public double FatGrams { get; set; }
    }
}
