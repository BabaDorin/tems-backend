using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface ITypeRepository
    {
        Task<Guid> CreateAsync(AssetType assetType, CancellationToken cancellationToken);
    }
}
