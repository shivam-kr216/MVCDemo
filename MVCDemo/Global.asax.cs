using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            /* 
             * IT WILL INITIALIZE THE DATABASE.
             * IF WE DON'T HAVE DATABASE IT CREATE THE DATABASE AND CREATE TABLE AS WELL IF NOT PRESENT.
             * PASSING NULL SPECIFIES WE DON'T WANT DATABASE INITIALIZATION STATEGY WE ALREADY HAVE DATABASE CREATED.
             */

            Database.SetInitializer<MVCDemo.Models.EmployeeContext>(null);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
