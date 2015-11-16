using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RBAC.MVC
{
    public class MyViewEngine : RazorViewEngine
    {
        public MyViewEngine() : base()
        {
            ViewLocationFormats = new[]
            {
                "~/Views/DashBoard/{0}.cshtml","~/Views/Administration/{0}.cshtml",  "~/Views/Shared/{0}.vbhtml"
            };

            PartialViewLocationFormats = new[]
            {
                "~/Views/DashBoard/{0}.cshtml","~/Views/Administration/{0}.cshtml", "~/Views/Shared/{0}.vbhtml"
            };

        }

        //protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        //{
        //    var catagoryName = controllerContext.RouteData.Values["category"].ToString();
        //    return base.CreatePartialView(controllerContext, partialPath.Replace("%1", catagoryName));
        //}

        //protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        //{
        //    var catagoryName = controllerContext.RouteData.Values["category"].ToString();
        //    return base.CreateView(controllerContext, viewPath.Replace("%1", catagoryName), masterPath);
        //}

        //protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
        //{
        //    var catagoryName = controllerContext.RouteData.Values["category"].ToString();
        //    return base.FileExists(controllerContext, virtualPath.Replace("%1", catagoryName));
        //}

    }
}
