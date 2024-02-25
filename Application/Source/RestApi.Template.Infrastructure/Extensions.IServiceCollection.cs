using Microsoft.Extensions.DependencyInjection;
using RestApi.Template.Persistenc.Context;

namespace RestApi.Template.Common
{
    public static class Extensions
    {
        public static IServiceCollection AddAllApplicationServices(this IServiceCollection services)
        {
            services.AddApplicationDbContext();
            return services;
        }

        private static IServiceCollection AddApplicationDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>();

            return services;
        }
    }
}
