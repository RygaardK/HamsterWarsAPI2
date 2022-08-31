using Entities.Models;
using HamsterWarsAPI.UI.Service;

namespace HamsterWarsAPI.UI.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<Hamster>();
        }
    }
}
