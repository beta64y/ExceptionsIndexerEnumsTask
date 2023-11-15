using ExceptionsIndexerEnumsTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsIndexerEnumsTask
{
    internal class User : Account
    {
        static int IdCounter = 1;
        public int Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }

        private string Password;
        public string password
        {
            get => Password;
            set
            {
                if (PasswordChecker(value))
                {
                    Password = value;
                }
                else
                {
                    throw new IncorrectPasswordException($"sehvdi {value}");
                }
            }
        }
        public User(string fullname, string email, string password)
        {
            Id = IdCounter++;
            FullName = fullname;
            Email = email;
            this.password = password;
        }
        public override bool PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                bool IsUpper = false;
                bool IsLower = false;
                bool IsNumber = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (IsLower && IsUpper && IsNumber)
                    {
                        return true;
                    }
                    if (Char.IsUpper(password[i])) IsUpper = true;
                    if (Char.IsLower(password[i])) IsLower = true;
                    if (Char.IsNumber(password[i])) IsNumber = true;

                }
                return false;
            }
            return false;

        }
        public override string ShowInfo()
        {
            return $"{Id} {FullName} {Email}";
        }
    }
}
