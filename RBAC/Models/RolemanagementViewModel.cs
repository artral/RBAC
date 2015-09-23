using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RBAC.Models
{
     
    public class RolemanagementViewModel
    {
        public string user { get; set; }
        public string rolename { get; set; }

        public List<SelectListItem> GetRoles()
        {
            List<SelectListItem> Roles = new List<SelectListItem>();
            Roles .Add(  new SelectListItem
            {
                Text = "Admin",
                Value = "1"
            });
            Roles.Add(new SelectListItem
            {
                Text = "User",
                Value = "2"
            });
            Roles.Add(new SelectListItem
            {
                Text = "Master",
                Value = "2"
            });
            Roles.Add(new SelectListItem
            {
                Text = "Financial",
                Value = "2"
            });


            return Roles;
        }
        public RolemanagementViewModel()
        {
            GetRoles();
        }
        public void Save()
        { }
        public void Delete() { }
    }
}