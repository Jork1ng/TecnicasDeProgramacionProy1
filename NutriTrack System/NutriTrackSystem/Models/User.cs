using System;
using System.Collections.Generic;
using System.Text;

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
        /// </value>
        public string HealthGoals { get; set; }

    }
}
