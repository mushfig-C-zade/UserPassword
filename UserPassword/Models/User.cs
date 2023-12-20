using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPassword.Interfaces;

namespace UserPassword.Models
{
    public class User : IAccount
    {
        public Guid Id { get; private set; }
        private string _password;
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get => _password; set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }

        public User(string email, string password)
        {
            Id = Guid.NewGuid();
            Email = email;
            Password = password;
        }

        public User()
        {
        }

        public static bool PasswordChecker(string password)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;

            if (!string.IsNullOrWhiteSpace(password) && password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        hasDigit = true;
                    }
                    if (char.IsLower(item))
                    {
                        hasLower = true;
                    }
                    if (char.IsUpper(item))
                    {
                        hasUpper = true;
                    }
                    if (hasDigit && hasLower && hasUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User Id: {Id}  Fullname: {Fullname}  Email: {Email}");
        }


        
    }
}
