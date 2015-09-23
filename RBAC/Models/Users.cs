using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RBAC.Models;
namespace RBAC.Models
{
    public class Users
    {
        public RolemanagementViewModel MyRoles { get; set; }
        public Users()
        {
            MyRoles = new RolemanagementViewModel();
        }

    }

}