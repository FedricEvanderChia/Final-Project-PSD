using CentuDY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repository
{
    public class RoleRepository
    {
        private static CentuDY_dbEntities db = new CentuDY_dbEntities();

        public static Role GetRoleById(int roleId)
        {
            Role role = (from x in db.Roles
                         where x.RoleId == roleId
                         select x).FirstOrDefault();
            return role;
        }
    }
}