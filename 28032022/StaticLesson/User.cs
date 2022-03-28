using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLesson
{
    internal class User
    {
        private string _password;
        public string UserName { get; set; }
        public string Password
        {
            set
            {
                if (CheckPassword(value))
                    _password = value;
            }
        }

        public static bool CheckPassword(string password)
        {
            if (!string.IsNullOrWhiteSpace(password) && password.Length > 5)
                return true;

            return false;
        }

        public string GetInfo()
        {
            return $"UserName: {this.UserName}";
        }




    }
}
