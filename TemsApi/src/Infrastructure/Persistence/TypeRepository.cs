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

        public async Task<Guid> CreateAsync(AssetType assetType, CancellationToken cancellationToken)
        {
            AssetTypeDb type = Mapper.MapToDb(assetType);

            await _types.InsertOneAsync(type, cancellationToken);

            return type.Id;
        }
    }
}
