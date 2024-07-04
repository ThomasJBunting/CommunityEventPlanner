
using CommunityEventPlanner.api.Context;
using Microsoft.EntityFrameworkCore;

namespace CommunityEventPlanner.api
{
    public static class InjectorServer
    {
        internal static void Inject(IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContextFactory<communityEPContext>(
                a => a.UseSqlServer(configuration["ConnectionStrings:Default"])

                );
        }
    }
}
