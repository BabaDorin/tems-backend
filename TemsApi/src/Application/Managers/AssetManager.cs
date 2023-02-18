using Application.Common.Interfaces;
<<<<<<< Updated upstream
=======
using Application.Common.Interfaces.Repositories;
>>>>>>> Stashed changes

namespace Application.Managers;

public class AssetManager
{
    private readonly IAssetRepository _assetRepository;
    public AssetManager(IAssetRepository assetRepository)
    {
        _assetRepository = assetRepository;
    }

    //Create

    //Read

    //Update

    //Delete

}
