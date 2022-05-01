using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetCore6.Model.Context;

namespace NetCore6.Bl.Settings
{
    public static class SqlServerDbSetting
    {
        public static IServiceCollection SettingSqlServerDbContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

            return services;
        }
    }
}