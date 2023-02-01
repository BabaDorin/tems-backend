using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IAssetRepository
    {
        Task<Guid> Create(Asset asset);
    }
}
