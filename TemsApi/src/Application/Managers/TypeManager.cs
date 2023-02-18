using Application.Common.Interfaces;
<<<<<<< Updated upstream
using Domain.Entities;
using Domain.Exceptions;
=======
using Application.Common.Interfaces.Repositories;
using Domain.Entities;
using Domain.Exceptions;
using FluentResults;
>>>>>>> Stashed changes

namespace Application.Managers
{
    public class TypeManager
    {
        private readonly ITypeRepository _typeRepository;
        public TypeManager(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

<<<<<<< Updated upstream
        public async Task<Guid> CreateAsync(AssetType assetType, CancellationToken cancellationToken)
        {
            var existingTypes = await _typeRepository.FindByNameAsync(assetType.Name, cancellationToken);

            if (existingTypes.Count() != 0) 
                throw new ExistingTypeException("This type already exist!");

            var typeId = await _typeRepository.CreateAsync(assetType, cancellationToken);

            return typeId;
=======
        public async Task<Result<Guid>> CreateAsync(AssetType assetType, CancellationToken cancellationToken)
        {
            var existingTypes = await _typeRepository.FindByNameAsync(assetType.Name, cancellationToken);

            if (existingTypes.Any())
                return Result.Fail<Guid>("This type already exist!");

            var typeId = await _typeRepository.CreateAsync(assetType, cancellationToken);

            return Result.Ok<Guid>(typeId);
>>>>>>> Stashed changes
        }
    }
}
