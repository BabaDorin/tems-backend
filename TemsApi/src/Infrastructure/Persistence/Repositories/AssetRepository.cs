using Application.Common.Interfaces;
<<<<<<< Updated upstream
=======
using Application.Common.Interfaces.Repositories;
>>>>>>> Stashed changes
using Domain.Entities;
using Infrastructure.Persistence.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Infrastructure.Persistence.Repositories;

public class AssetRepository : IAssetRepository
{
    private readonly IMongoCollection<AssetDb> _assets;
    public AssetRepository(IMongoClient client, IConfiguration configuration)
    {
        var database = client.GetDatabase(configuration.GetSection("DatabaseSettings:ConnectionString").Value);
        _assets = database.GetCollection<AssetDb>(configuration.GetSection("DatabaseSettings:Collections:Assets").Value);
    }
    public async Task<Guid> CreateAsync(Asset asset, CancellationToken cancellationToken)
    {
        AssetDb assetDb = Mapper.MapToDb(asset);

        await _assets.InsertOneAsync(assetDb, cancellationToken);

        return assetDb.Id;
    }
}

