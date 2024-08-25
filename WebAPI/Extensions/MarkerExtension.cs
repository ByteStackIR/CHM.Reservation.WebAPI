using Asp.Versioning;
using Contracts.IMarker;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Services.Services;

namespace WebAPI.Extensions
{
    public static class MarkerExtension
    {
        public static void ConfigureDenpdencyInjectionByMarker(this IServiceCollection services )
        {
           
           var Scopes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => typeof(IScopeMarker).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).ToList();

            Scopes.ForEach(service =>
            {
                var interfaceService = service.GetInterfaces().FirstOrDefault(x => x.FullName.EndsWith(service.Name));



                if (interfaceService != null)
                    services.AddScoped(interfaceService, service);


            });

            var Transient = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => typeof(ITransientMarker).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).ToList();


            Transient.ForEach(service =>
            {
              
                    services.AddTransient( service);


            });

            var Singletons = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => typeof(ISingletonMarker).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).ToList();

            Singletons.ForEach(service =>
            {
                var interfaceService = service.GetInterfaces().FirstOrDefault(x => x.FullName.EndsWith(service.Name));

                services.AddSingleton(service, interfaceService);


            });
        }
    }
}
