using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace AngularJSWebUI.Cors
{
    //public class AllowCrossOrgine : ActionFilterAttribute
    //{
    //    public override void OnActionExecuting(ActionExecutingContext filterContext)
    //    {
    //        filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "http://localhost:4200");
    //        filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Headers", "*");
    //        filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Credentials", "true");

    //        base.OnActionExecuting(filterContext);
    //    }

    //    public class AllowCrossSiteJsonAttribute : System.Web.Http.Filters.ActionFilterAttribute
    //    {
    //        public void OnAuthorization(AuthorizationContext filterContext)
    //        {
    //            filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
    //        }

    //    }
    //}
}