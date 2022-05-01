using Microsoft.Extensions.Diagnostics.HealthChecks;
using NetCore6.HealthCheck.EndPoints;
using NetCore6.Model.Context;

namespace NetCore6.Settings
{
    public static class HealthCheckSetting
    {
        public static IServiceCollection SettingHealthCheck(this IServiceCollection services)
        {
            services.AddHealthChecks()
                .AddCheck("self", () => HealthCheckResult.Healthy())
                .AddDbContextCheck<ApplicationDbContext>()
                .AddCheck<ExampleCheckEndPoint>("Example Check EndPoint");

            services.AddHealthChecksUI()
                .AddSqliteStorage($"Data Source=HealthCheck/Db/sqlite.db");

            return services;
        }
    }
}