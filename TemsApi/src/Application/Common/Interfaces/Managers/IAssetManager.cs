using Domain.Entities;

namespace Application.Common.Interfaces.Managers;
public interface IAssetManager
{
    Task<Guid> CreateAsync(Asset asset, CancellationToken cancellationToken);
}
