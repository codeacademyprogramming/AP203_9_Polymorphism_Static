using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLesson
{
    internal static class Checker
    {
        public static bool PasswordChecker(string pas)
        {
            //yoxlama
            return true;
        }

        public static bool HasDigit(string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                    return true;
            }

            return false;
        }
    }
}
