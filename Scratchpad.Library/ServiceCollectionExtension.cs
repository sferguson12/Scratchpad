using Microsoft.Extensions.DependencyInjection;

namespace Scratchpad.Library
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureLibrary(this IServiceCollection services)
        {
            services.AddSingleton<IMyService, MyService>();
            return services;
        } 
    }
}