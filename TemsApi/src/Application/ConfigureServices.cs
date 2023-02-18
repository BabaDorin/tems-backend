using Application.Validators;
using Application.Validators.AttributeValidatorFactory;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IAttributeValidatorFactory,AttributeValidatorFactory>();
        services.AddScoped<IAttributeValidator, AttributesValidator>();

        return services;
    }
}

