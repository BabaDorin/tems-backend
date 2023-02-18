using Application.Common.Interfaces.Managers;
using Application.Common.Interfaces.Repositories;
using Domain.Entities;

namespace Application.Managers;

public class AssetManager : IAssetManager
{
    private readonly IAssetRepository _assetRepository;
    public AssetManager(IAssetRepository assetRepository)
    {
        _assetRepository = assetRepository;
    }

    public Task<Guid> CreateAsync(Asset asset, CancellationToken cancellationToken)
    {
        //Implement this method after

        throw new NotImplementedException();
    }
}
