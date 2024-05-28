using EnqueteApi.Services.Interfaces;

namespace EnqueteApi.Bootstrapper
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddScopes(this IServiceCollection services)
        {
           return services.AddScoped<IEnqueteService, IEnqueteService>();
        }
    }
}
