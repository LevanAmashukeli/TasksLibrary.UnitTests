using System;

namespace TasksLibrary
{
    public class UserManager
    {
        public bool Add(string userId, string phone , string email)
        {
            if(userId.Length < 4)
            {
                throw new Exception("UserId should be more 4 symbols");
            }

            if (phone.Contains("a"))
            {
                throw new Exception("Phone should contain only numbers");
            }

            if (!email.Contains("@"))
            {
                throw new Exception("Error in Email Address");
            }

            //Save data logic

            return true;
        }
    }
}
