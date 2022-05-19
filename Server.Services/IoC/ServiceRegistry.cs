using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Server.Services.Services;
using Server.Services.Services.Enterprise;
using Server.Services.Services.File;
using Server.Services.Services.User;
using Server.Services.Services.UserDetails;
using Server.Services.Services.VacantUser;

namespace Server.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<IExamplePersonService, ExamplePersonService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IBiographyService, BiographyService>();
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<IEducationService, EducationService>();
            services.AddTransient<IGeneralInformationService, GeneralInformationService>();
            services.AddTransient<ISkillsService, SkillsService>();
            services.AddTransient<ISocialService, SocialService>();
            services.AddTransient<IUserDetailsService, UserDetailsService>();
            services.AddTransient<IWorkExperienceService, WorkExperienceService>();
            services.AddTransient<IWorkPlataformService, WorkPlataformService>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IEnterpriseService, EnterpriseService>();
            services.AddTransient<IVacantService, VacantService>();
            services.AddTransient<IVacantUserService, VacantUserService>();

            services.AddHttpClient("BackEnd", client => 
            {
                client.BaseAddress = new Uri(configuration["AppSettings:ApiUrl"]);
            });

        }
    }
}