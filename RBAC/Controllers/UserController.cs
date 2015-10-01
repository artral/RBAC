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
            // return View("User", oUser);
            return View("Master");
        }
        public ActionResult Trend()
        {
            var varTrend = new IssueTrendViewModel();
            return View("_IssueTrend", varTrend);
        }
        public ActionResult Daily()
        {
            var varTrend = new DailyTrend();
            return View("_DailyTrend", varTrend);
        }
    }
}