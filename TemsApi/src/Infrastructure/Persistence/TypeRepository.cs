using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Infrastructure.Persistence
{
    public class TypeRepository : ITypeRepository
    {
        private readonly IMongoCollection<AssetTypeDb> _types;
        public TypeRepository(IMongoClient client, IConfiguration configuration)
        {
            var database = client.GetDatabase(configuration.GetSection("DatabaseSettings:DatabaseName").Value);
            _types = database.GetCollection<AssetTypeDb>(configuration.GetSection("DatabaseSettings:Collections:AssetType").Value);
        }

        public async Task<Guid> Create(AssetType assetType)
        {
            AssetTypeDb type = new AssetTypeDb
            {
                Id = assetType.Id,
                ClientId = assetType.ClientId,
                Name = assetType.Name,
                Attributes = assetType.Attributes,
            };

            await _types.InsertOneAsync(type);

            return type.Id;
        }
    }
}
