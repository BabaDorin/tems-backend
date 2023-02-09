﻿using Application.Common.Interfaces;
using Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IMongoClient>(c => new MongoClient(configuration.GetSection("DatabaseSettings:ConnectionString").Value));
        services.AddScoped<ITypeRepository, TypeRepository>();

        return services;
    }
}

