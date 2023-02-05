using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Core.Operations;
using System;

namespace Infrastructure.Persistence
{
    public class DefinitionRepository : IDefinitionRepository
    {
        private readonly IMongoCollection<AssetDefinitionDb> _definitions;
        public DefinitionRepository(IMongoClient client, IConfiguration configuration)
        {
            var database = client.GetDatabase(configuration.GetSection("DatabaseSettings:DatabaseName").Value);
            _definitions = database.GetCollection<AssetDefinitionDb>(configuration.GetSection("DatabaseSettings:Collections:AssetDefinition").Value);
        }
        public async Task<Guid> CreateAsync(AssetDefinition assetDefinition, CancellationToken cancellationToken)
        {
            AssetDefinitionDb definition = Mapper.MapToDb(assetDefinition);

            await _definitions.InsertOneAsync(definition, cancellationToken);

            return definition.Id;
        }

    }
}
