using Microsoft.Extensions.DependencyInjection;
using Server.Model.Repositories;
using Server.Model.Repositories.Enterprise;
using Server.Model.Repositories.File;
using Server.Model.Repositories.UserDetails;
using Server.Model.Repositories.VacantUser;

namespace Server.Model.IoC
{
    public static class ModelRegistry
    {
        public static void AddModelRegistry(this IServiceCollection services)
        {
            services.AddTransient<IExamplePersonRepository, ExamplePersonRepository>();
            services.AddTransient<IBiographyRepository, BiographyRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IEducationRepository, EducationRepository>();
            services.AddTransient<IGeneralInformationRepository, GeneralInformationRepository>();
            services.AddTransient<ISkillsRepository, SkillsRepository>();
            services.AddTransient<ISocialRepository, SocialRepository>();
            services.AddTransient<IUserDetailsRepository, UserDetailsRepository>();
            services.AddTransient<IWorkExperienceRepository, WorkExperienceRepository>();
            services.AddTransient<IWorkPlataformRepository, WorkPlataformRepository>();
            services.AddTransient<IFileRepository, FileRepository>();
            services.AddTransient<IVacantRepository, VacantRepository>();
            services.AddTransient<IEnterpriseRepository, EnterpriseRepository>();
            services.AddTransient<IVacantUserRepository, VacantUserRepository>();
        }
    }
}