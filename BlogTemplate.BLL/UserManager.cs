using System;
using System.Collections.Generic;
using System.Text;
using BlogTemplate.Data;
using BlogTemplate.Domain;
using System.Linq;

namespace BlogTemplate.BLL
{
    public class UserManager
    {


        public static bool checkUser(User user)
        {
            var notexist = false;
            var db = new BlogContext();
            var sameUsername = db.Users.Where(u => u.Username == user.Username);
            if (sameUsername == null)
                notexist = true;
            return notexist;
        }

        public static void Add(User user)
        {
            try
            {
                var context = new BlogContext();
                context.Users.Add(user);
                context.SaveChanges();
            }
            catch
            {

            }
        }

        /// <summary>
        /// User is authenticated based on credentials and a user returned if exists or null if not.
        /// </summary>
        /// <param name="username">Username as string</param>
        /// <param name="password">Password as string</param>
        /// <returns>A user object or null.</returns>
        public static User Authenticate(string username, string password)
        {
            var context = new BlogContext();
            var user = context.Users.SingleOrDefault(usr => usr.Username == username
                                                    && usr.Password == password);
            return user; //this will either be null or an object
        }
    }
}
