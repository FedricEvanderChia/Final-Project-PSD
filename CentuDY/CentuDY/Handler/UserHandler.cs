using CentuDY.Factory;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handler
{
    public class UserHandler
    {
        public static User LoginUser(string username, string password)
        {
            return UserRepository.LoginUser(username, password);
        }

        public static bool RegisterUser(int roleId, string username, string password, string name, string gender, string phoneNumber, string address)
        {
            if (UserRepository.isUniqueUsername(username))
            {
                User user = UserFactory.CreateUser(roleId, username, password, name, gender, phoneNumber, address);
                return UserRepository.RegisterUser(user);
            }
            return false;
        }

        public static List<User> GetAllUsers()
        {
            return UserRepository.GetAllUsers();
        }

        public static User GetUserById(int userId)
        {
            return UserRepository.GetUserById(userId);
        }

        public static void RemoveUser(int userId)
        {
            UserRepository.RemoveUser(userId);
        }

        public static void UpdateProfile(int userId, string name, string gender, string phoneNumber, string address)
        {
            UserRepository.UpdateProfile(userId, name, gender, phoneNumber, address);
        }

        public static void ChangePassword(int userId, string newPw)
        {
            UserRepository.ChangePassword(userId, newPw);
        }
    }
}