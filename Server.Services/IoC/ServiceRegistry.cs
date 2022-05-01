using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore6.Services.Services;
using Server.Services.Services.User;

namespace NetCore6.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<IExamplePersonService, ExamplePersonService>();
            services.AddTransient<IUserService, UserService>();

            services.AddHttpClient("BackEnd", client => 
            {
                client.BaseAddress = new Uri(configuration["AppSettings:ApiUrl"]);
            });

        }
    }
}