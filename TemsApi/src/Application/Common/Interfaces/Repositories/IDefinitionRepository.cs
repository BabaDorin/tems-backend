using Domain.Entities;

namespace Application.Common.Interfaces.Repositories;

public interface IDefinitionRepository
{
    Task<Guid> CreateAsync(AssetDefinition assetDefinition, CancellationToken cancellationToken);
}

