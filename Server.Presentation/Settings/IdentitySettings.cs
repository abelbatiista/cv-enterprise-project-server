using Microsoft.AspNetCore.Identity;
using NetCore6.Model.Context;
using Server.Model.Entities.User;

namespace Server.Presentation.Settings
{
    public static class IdentitySettings
    {
        public static IServiceCollection SettingsIdenity(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationIdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            return services;
        }
    }
}
