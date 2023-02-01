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
        public async Task<Guid> Create(AssetDefinition assetDefinition)
        {
            AssetDefinitionDb definition = new AssetDefinitionDb
            {
                Id = assetDefinition.Id,
                Type = assetDefinition.Type,
                TypeId = assetDefinition.TypeId,
                ClientId = assetDefinition.ClientId,
                Name = assetDefinition.Name,
            };

            await _definitions.InsertOneAsync(definition);

            return definition.Id;
        }

    }
}
