using CentuDY.Handler;
using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controller
{
    public class RoleController
    {
        public static Role GetRoleById(int roleId)
        {
            return RoleHandler.GetRoleById(roleId);
        }
    }
}