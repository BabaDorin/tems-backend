using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IAssetRepository
    {
        Task<Guid> CreateAsync(Asset asset, CancellationToken cancellationToken);
    }
}
