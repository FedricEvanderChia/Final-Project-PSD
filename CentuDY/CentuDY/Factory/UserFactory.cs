using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factory
{
    public class UserFactory
    {
        public static User CreateUser(int roleId, string username, string password, string name, string gender, string phoneNumber, string address)
        {
            User user = new User
            {
                RoleId = roleId,
                Username = username,
                Password = password,
                Name = name,
                Gender = gender,
                PhoneNumber = phoneNumber,
                Address = address
            };

            return user;
        }
    }
}