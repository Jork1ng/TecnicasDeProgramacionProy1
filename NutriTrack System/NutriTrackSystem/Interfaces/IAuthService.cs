using System;
using System.Collections.Generic;
using System.Text;

using NutriTrackSystem.Models;

namespace NutriTrackSystem.Interfaces
{
    /// <summary>
    /// Defines methods for user authentication and registration services.
    /// </summary>
    public interface IAuthService
    {
        bool Register(User user);
        User Login(string username, string password);
    }
}
