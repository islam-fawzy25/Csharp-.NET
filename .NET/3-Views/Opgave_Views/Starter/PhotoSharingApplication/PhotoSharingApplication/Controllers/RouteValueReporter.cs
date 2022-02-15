using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace PhotoSharingApplication.Controllers
{
    public class RouteValueReporter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LogValues(filterContext.RouteData);
        }

        private void LogValues(RouteData routeData)
        {
            var kontroller = routeData.Values["controller"];
            var Aktion = routeData.Values["action"];
            string message = string.Format($"Controller: {kontroller} Action : {Aktion} ");
            Debug.WriteLine(message, "Action Values");
            foreach (var V in routeData.Values)
            {
                Debug.WriteLine($"-> Key > {V.Key} -> Value {V.Value}");
            }
        }
    }
}