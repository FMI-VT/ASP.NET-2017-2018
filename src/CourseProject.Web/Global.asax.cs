using CourseProject.DataAccess.Repositories;
using CourseProject.DB.Entities;
using CourseProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;

namespace CourseProject.Web
{
    public class MvcApplication : HttpApplication
    {
        private IUnityContainer ConfigureDependencies()
        {
            var container = new UnityContainer();

            container.RegisterType<IBaseRepository<City>, CityRepository>();
            
            container.RegisterType<CityService>();

            return container;
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyResolver.SetResolver(new UnityDependencyResolver(ConfigureDependencies()));
        }
    }
}
