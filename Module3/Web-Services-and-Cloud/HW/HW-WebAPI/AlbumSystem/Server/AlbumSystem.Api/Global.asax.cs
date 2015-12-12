namespace AlbumSystem.Api
{
    using System.Reflection;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using Common.Constants;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Custom
            DatabaseConfig.Initialize();
            AutoMapperConfig.RegisterMappings(Assembly.Load(Assemblies.WebApi));
            
            // WebApi
            GlobalConfiguration.Configure(WebApiConfig.Register);


            // MVC
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
