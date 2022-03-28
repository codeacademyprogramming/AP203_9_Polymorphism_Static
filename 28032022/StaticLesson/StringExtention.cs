using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLesson
{
    internal static class StringExtention
    {
        public static bool HasDigit(this string str)
        {
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                    return true;
            }

            return false;
        }

        public static string ToName(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;

            str = str.ToLower();

            string newStr = char.ToUpper(str[0]) + str.Substring(1);
            return newStr;
        }

        public static int Add(this int num1,int num2)
        {
            return num1+ num2;
        }
    }
}
