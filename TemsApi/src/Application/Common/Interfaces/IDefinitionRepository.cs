using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IDefinitionRepository
    {
        Task<Guid> CreateAsync(AssetDefinition assetDefinition,CancellationToken cancellationToken);
    }
}
