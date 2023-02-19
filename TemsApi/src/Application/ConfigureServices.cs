using Application.Common.Interfaces.Managers;
using Application.Managers;
using Application.Validators;
using Application.Validators.AttributeValidatorFactory;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;
public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddSingleton<IAttributeValidatorFactory, AttributeValidatorFactory>();
        services.AddScoped<IAttributeValidator, AttributesValidator>();
        services.AddScoped<ITypeManager, TypeManager>();
        services.AddScoped<IDefinitionManager, DefinitionManager>();

        return services;
    }
}
