using Application.Common.Interfaces.Managers;
using Application.Managers;
using Domain.Entities;
using MediatR;

namespace Application.AssetTypes.Commands
{
<<<<<<< Updated upstream
    public record CreateTypeCommand(AssetType assetType) : IRequest<Guid>;

    public class CreateTypeCommandHandler : IRequestHandler<CreateTypeCommand, Guid>
    {
        private readonly TypeManager _typeManager;
        public CreateTypeCommandHandler(TypeManager typeManager)
=======
    public record CreateTypeCommand(AssetType assetType) : IRequest<Result<Guid>>;

    public class CreateTypeCommandHandler : IRequestHandler<CreateTypeCommand, Result<Guid>>
    {
        private readonly ITypeManager _typeManager;
        public CreateTypeCommandHandler(ITypeManager typeManager)
>>>>>>> Stashed changes
        {
            _typeManager = typeManager;
        }

<<<<<<< Updated upstream
        public async Task<Guid> Handle(CreateTypeCommand request, CancellationToken cancellationToken)
        {
            var typeId = await _typeManager.CreateAsync(request.assetType, cancellationToken);

            return typeId;
=======
        public async Task<Result<Guid>> Handle(CreateTypeCommand request, CancellationToken cancellationToken)
        {
            var result = await _typeManager.CreateAsync(request.assetType, cancellationToken);

            return result;
>>>>>>> Stashed changes
        }
    }
}
