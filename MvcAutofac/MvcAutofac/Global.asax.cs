using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcAutofac.App_Start;

namespace MvcAutofac
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ContainerConfig.SetUp();
        }

        protected void Application_End()
        {
            ContainerConfig.TearDown();
        }
    }
}
