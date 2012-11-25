using System;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;
using NiCris.WebAPI.App_Start;

namespace NiCris.WebAPI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FormattersConfig.RegisterFormatters(GlobalConfiguration.Configuration);
        }
    }
}