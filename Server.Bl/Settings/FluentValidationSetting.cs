using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using NetCore6.Bl.Validators;

namespace NetCore6.Bl.Settings
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