using Application.Managers;
using Domain.Entities;
using MediatR;

namespace Application.AssetTypes.Commands
{
    public record CreateTypeCommand(AssetType assetType) : IRequest<Guid>;

    public class CreateTypeCommandHandler : IRequestHandler<CreateTypeCommand, Guid>
    {
        private readonly TypeManager _typeManager;
        public CreateTypeCommandHandler(TypeManager typeManager)
        {
            _typeManager = typeManager;
        }

        public async Task<Guid> Handle(CreateTypeCommand request, CancellationToken cancellationToken)
        {
            var typeId = await _typeManager.CreateAsync(request.assetType, cancellationToken);

            return typeId;
        }
    }
}
