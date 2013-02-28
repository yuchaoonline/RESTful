using System;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;

namespace RESTful.WCFServer
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            RouteTable.Routes.Add(new ServiceRoute("UserSvc", new WebServiceHostFactory(), typeof(UserSvc)));
            RouteTable.Routes.Add(new ServiceRoute("ImageSvc", new WebServiceHostFactory(), typeof(ImageSvc)));
        }
    }
}
