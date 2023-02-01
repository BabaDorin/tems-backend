using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface ITypeRepository
    {
        Task<Guid> Create(AssetType assetType);
    }
}
