using CentuDY.Handler;
using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class UserController
    {
        public static User LoginUser(string username, string password)
        {
            return UserHandler.LoginUser(username, password);
        }

        public static string RegisterUser(int roleId, string username, string password, string confirmPassword, string name, string gender, string phoneNumberString, string address)
        {
            long phoneNumber;
            string message = "";

            if (username.Length <= 0)
            {
                return message = "Username cannot be empty";
            }
            else if (username.Length < 3)
            {
                return message = "Username minimal length is 3 characters";
            }
            else
            {
                if (!UserRepository.isUniqueUsername(username))
                {
                    return message = "Username must be unique";
                }
            }

            if (password.Length <= 0)
            {
                return message = "Password cannot be empty";
            }
            else if (password.Length < 8)
            {
                return message = "Password minimal length is 8 characters";
            }

            if (confirmPassword.Length <= 0)
            {
                return message = "Confirm password cannot be empty";
            }
            else if (confirmPassword != password)
            {
                return message = "Password didn't match";
            }

            if (name.Length <= 0)
            {
                return message = "Name cannot be empty";
            }

            if (gender.Equals(""))
            {
                return message = "Gender must be chosen";
            }

            if (phoneNumberString.Length <= 0)
            {
                return message = "Phone number cannot be empty";
            }
            else
            {
                if (!Int64.TryParse(phoneNumberString, out phoneNumber))
                {
                    return message = "Phone number must be numeric";
                }
            }

            if (address.Length <= 0)
            {
                return message = "Address cannot be empty";
            }
            else
            {
                if (!address.Contains("Street"))
                {
                    return message = "Address must contain the word 'Street'";
                }
            }

            UserHandler.RegisterUser(roleId, username, password, name, gender, phoneNumber.ToString(), address);

            return message;
        }

        public static List<User> GetAllUsers()
        {
            return UserHandler.GetAllUsers();
        }

        public static User GetUserById(int userId)
        {
            return UserHandler.GetUserById(userId);
        }

        public static void RemoveUser(int userId)
        {
            UserHandler.RemoveUser(userId);
        }

        public static string UpdateProfile(int userId, string name, string gender, string phoneNumberString, string address)
        {
            long phoneNumber;

            if (name.Length <= 0)
            {
                return "Name cannot be empty";
            }

            if (gender.Equals(""))
            {
                return "Gender must be chosen";
            }

            if (phoneNumberString.Length <= 0)
            {
                return "Phone number cannot be empty";
            }
            else
            {
                if (!Int64.TryParse(phoneNumberString, out phoneNumber))
                {
                    return "Phone number must be numeric";
                }
            }

            if (address.Length <= 0)
            {
                return "Address cannot be empty";
            }
            else
            {
                if (!address.Contains("Street"))
                {
                    return "Address must contain the word 'Street'";
                }
            }

            UserHandler.UpdateProfile(userId, name, gender, phoneNumber.ToString(), address);

            return "";
        }

        public static string ChangePassword(int userId, string oldPw, string newPw, string confNewPw)
        {
            User user = UserHandler.GetUserById(userId);

            if(oldPw.Length <= 0)
            {
                return "Old password cannot be empty";
            }
            else if (!oldPw.Equals(user.Password))
            {
                return "Old password didn't match current password";
            }

            if(newPw.Length <= 0)
            {
                return "New password cannot be empty";
            }
            else if(newPw.Length <= 5)
            {
                return "New password must be longer than 5 characters";
            }

            if(confNewPw.Length <= 0)
            {
                return "Confirm new password cannot be empty";
            }
            else if(!confNewPw.Equals(newPw))
            {
                return "New password didn't match";
            }

            UserHandler.ChangePassword(userId, newPw);

            return "";
        }
    }
}