using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Entity_Framework_MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Added new comment
            //Added new comment

            ///new change
            /////again new change
            ///1234
            //final change
            //final change done
            //last final change
           //testing 8 build
        }
    }
}
