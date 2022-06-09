

using System;
using System.Text.RegularExpressions;

namespace TasksLibrary
{
    public static class PasswordStrengthChecker
    {
        public static int GetPasswordStrenght(string password)
        {
            if(string.IsNullOrEmpty(password))
            {
                return 0;
            }

            int result = 0;

            // +1 point for Length
            if(Math.Max(password.Length, 7) > 7)
            {
                result ++;
            }

            //+1 point for small chars
            if (Regex.Match(password, "[a-z]").Success)
            {
                result++;
            }

            //+1 point for small chars
            if (Regex.Match(password, "[A-Z]").Success)
            {
                result++;
            }

            //+1 point for numbers 
            if (Regex.Match(password, "[0-9]").Success)
            {
                result++;
            }

            //+1 point for special symbols 
            if (Regex.Match(password,
                "[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)\\+\\-\\=\\[\\]\\;\\'\\.\\,]").Success)
            {
                result++;
            }

            return result;
        }
    }
}
