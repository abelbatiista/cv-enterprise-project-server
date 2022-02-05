using Microsoft.Extensions.DependencyInjection;

namespace NetCore6.Bl.Settings
{
    public static class AutoMapperSetting
    {
        public static IServiceCollection SettingAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}