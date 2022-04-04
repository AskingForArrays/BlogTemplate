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

        public static void Update(User userToUpdate)
        {
            try
            {
                var db = new BlogContext();
                var oldUser = db.Users.Find(userToUpdate.UserID);
                oldUser.FirstName = userToUpdate.FirstName;
                oldUser.LastName = userToUpdate.LastName;
                db.SaveChanges();
            }
            catch
            {

            }
        }

        public static void Delete(User userToUpdate)
        {
            try
            {
                var db = new BlogContext();
                db.Users.Remove(userToUpdate);
                db.SaveChanges();
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
            var db = new BlogContext();
            var userReturn = db.Users.SingleOrDefault(user => user.Username == username
                                                    && user.Password == password);
            return userReturn; //this will either be null or an object
        }

        public static User GetUserById(int userId)
        {
            var db = new BlogContext();
            var userReturn = db.Users.SingleOrDefault(u => u.UserID == userId);
            return userReturn;
        }

        /// <summary>
        /// Checks if a username already exists in the database and returns true if it already exists
        /// </summary>
        /// <param name="username"></param>
        /// <returns>bool - true if it exists</returns>
        public static bool CheckUsername(string username)
        {
            var db = new BlogContext();
            var userReturn = db.Users.SingleOrDefault(u => u.Username == username);
            if (userReturn != null)
            {
                return true;
            } else
            {
                return false;
            }

        }

    }
}
