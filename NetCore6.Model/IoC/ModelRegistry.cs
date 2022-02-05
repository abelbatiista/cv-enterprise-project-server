using Microsoft.Extensions.DependencyInjection;
using NetCore6.Model.Repositories;

namespace NetCore6.Model.IoC
{
    public static class ModelRegistry
    {
        public static void AddModelRegistry(this IServiceCollection services)
        {
            services.AddTransient<IExamplePersonRepository, ExamplePersonRepository>();
        }
    }
}