using CentuDY.Model;
using CentuDY.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handler
{
    public class RoleHandler
    {
        public static Role GetRoleById(int roleId)
        {
            return RoleRepository.GetRoleById(roleId);
        }
    }
}