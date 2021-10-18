using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class UserRepository
    {
        static CentuDY_dbEntities db = new CentuDY_dbEntities();
        public static User LoginUser(string username, string password)
        {
            User user = (from x in db.Users
                         where x.Username.Equals(username) && x.Password.Equals(password)
                         select x).FirstOrDefault();
            return user;
        }

        public static List<User> GetAllUsers()
        {
            List<User> users = (from x in db.Users select x).ToList();

            return users;
        }

        public static User GetUserById(int userId)
        {
            User user = (from x in db.Users
                         where x.UserId == userId
                         select x).FirstOrDefault();
            return user;
        }

        public static void RemoveUser(int userId)
        {
            User user = (from x in db.Users where x.UserId == userId select x).FirstOrDefault();

            if(user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public static void UpdateProfile(int userId, string name, string gender, string phoneNumber, string address)
        {
            User user = (from x in db.Users where x.UserId == userId select x).FirstOrDefault();

            if(user != null)
            {
                user.Name = name;
                user.Gender = gender;
                user.PhoneNumber = phoneNumber;
                user.Address = address;

                db.SaveChanges();
            }
        }

        public static void ChangePassword(int userId, string newPw)
        {
            User user = (from x in db.Users where x.UserId == userId select x).FirstOrDefault();

            if(user != null)
            {
                user.Password = newPw;

                db.SaveChanges();
            }
        }

        public static bool RegisterUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();

            return true;
        }

        public static bool isUniqueUsername(string username)
        {
            User user = (from x in db.Users
                         where x.Username == username
                         select x).FirstOrDefault();

            if (user == null) return true;
            return false;
        }

    }
}