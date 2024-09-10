using IoCServiceProviderWebServicePresentation.App_Start;
using IoCServiceProviderWebServicePresentation.Controllers;
using IoCWebServiceSampleServicesProject.Implementations;
using IoCWebServiceSampleServicesProject.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IoCServiceProviderWebServicePresentation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var services = new ServiceCollection();
            ConfigureServices(services);

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            GlobalConfiguration.Configuration.DependencyResolver = new GlobalConfigurationDependencyResolver(serviceProvider);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICountryService, CountryService>();
            services.AddTransient<IStatisticsService, StatisticsService>();
            services.AddTransient<CountryController>();
            services.AddTransient<CountryStatisticsController>();
        }
    }
}
