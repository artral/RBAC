using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RBAC.Models;

namespace RBAC.Views.Administration
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var oUser = new Users();
            return View("User", oUser);
        }
    }
}