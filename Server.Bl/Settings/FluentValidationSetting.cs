using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Server.Bl.Validators;

namespace Server.Bl.Settings
{
    public static class FluentValidationSetting
    {
        public static IMvcBuilder SettingFluentValidation(this IMvcBuilder builder)
        {
            builder.AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblyContaining<ExamplePersonValidator>();
            });
            return builder;
        }
    }
}