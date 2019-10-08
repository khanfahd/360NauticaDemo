using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Auth.Web.Services
{
    public interface IUserService
    {
        Task<bool> ValidateCredentials(string username, string password, out User user);
    }

    public class User
    {
        public User(string username, string dateOfBirth, string role)
        {
            Username = username;
            this.DateOfBirth = dateOfBirth;
            this.Role = role;
        }

        public string Username { get; }
        public string DateOfBirth { get; }
        public string Role { get; }
    }
}

