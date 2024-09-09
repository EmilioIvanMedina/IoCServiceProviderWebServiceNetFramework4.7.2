using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace IoCServiceProviderWebServicePresentation.App_Start
{
    public class GlobalConfigurationDependencyResolver : IDependencyResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public GlobalConfigurationDependencyResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IDependencyScope BeginScope()
        {
            return new GlobalConfigurationDependencyResolver(_serviceProvider.CreateScope().ServiceProvider);
        }

        public void Dispose()
        {
            
        }

        public object GetService(Type serviceType)
        {
            return _serviceProvider.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _serviceProvider.GetServices(serviceType);
        }
    }
}