using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Infrastructure.Persistence
{
    public class AssetRepository : IAssetRepository
    {
        private readonly IMongoCollection<AssetDb> _assets;
        public AssetRepository(IMongoClient client, IConfiguration configuration)
        {
            var database = client.GetDatabase(configuration.GetSection("DatabaseSettings:ConnectionString").Value);
            _assets = database.GetCollection<AssetDb>(configuration.GetSection("DatabaseSettings:Collections:Assets").Value);
        }
        public async Task<Guid> Create(Asset asset)
        {
            AssetDb assetDb = new AssetDb
            {
                Id = asset.Id,
                ClientId = asset.ClientId,
                TemsId = asset.TemsId,
                UploadedBy = asset.UploadedBy,
                UploadedAt = asset.UploadedAt,
                PurchasedAt = asset.PurchasedAt,
                Description = asset.Description,
                Type = asset.Type,
                TypeId = asset.TypeId,
                Price = asset.Price,
                Definition = asset.Definition,
            };

            await _assets.InsertOneAsync(assetDb);

            return assetDb.Id;
        }
    }
}
