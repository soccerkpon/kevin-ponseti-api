using kevin_ponseti_api.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using kevin_ponseti_api.DataAccess;
using kevin_ponseti_api.Repositories;

namespace kevin_ponseti_api.Static_Extensions
{
    public static class ServiceRegistrations
    {
        public static void Register(IServiceCollection services, string connection)
        {
            services.AddDbContext<KevinPonsetiContext>(options => options.UseSqlServer(connection));
            services.AddTransient<IKevinPonsetiContext, KevinPonsetiContext>();
            services.AddTransient<ITechService, TechService>();
            services.AddTransient<ITechRepo, TechRepo>();
        }
    }
}
