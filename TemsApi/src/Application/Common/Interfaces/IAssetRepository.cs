using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IAssetRepository
    {
        Task Create(Asset asset);
    }
}
