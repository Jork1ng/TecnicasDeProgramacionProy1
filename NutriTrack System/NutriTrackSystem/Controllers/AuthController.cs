using System.Text.Json;
using NutriTrackSystem.Models;
using NutriTrackSystem.Interfaces;
using System.Linq;
using System.IO;

namespace NutriTrackSystem.Controllers
{
    /// <summary>
    /// Handles user authentication, including registration and login,
    /// by managing user data stored in a JSON file.
    /// </summary>
    public class AuthController : IAuthService
    {
        /// <summary>
        /// Builds and ensures the correct file path for the JSON file.
        /// </summary>
        private string GetFilePath()
        {
            string directory = Path.Combine(Directory.GetCurrentDirectory(), "Data");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            return Path.Combine(directory, "users.json");
        }

        /// <summary>
        /// Gets all users from the JSON file.
        /// </summary>
        public List<User> GetUsers()
        {
            string fullPath = GetFilePath();
            if (!File.Exists(fullPath))
            {
                File.WriteAllText(fullPath, "[]");
            }

            string json = File.ReadAllText(fullPath);

            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        /// <summary>
        /// Registers a new user if the username is unique.
        /// </summary>
        public bool Register(User user)
        {
            string fullPath = GetFilePath();

            var users = GetUsers();

            // Validar usuario único
            if (users.Any(u => u.Username == user.Username))
                return false;

            users.Add(user);

            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(fullPath, json);

            return true;
        }

        /// <summary>
        /// Validates user credentials.
        /// </summary>
        public User Login(string username, string password)
        {
            var users = GetUsers();

            return users.FirstOrDefault(u =>
                u.Username == username && u.Password == password);
        }
    }
}