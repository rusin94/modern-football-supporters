using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;

namespace MFS.Application.Features.Communities.DeleteCommunity;

public class DeleteCommunityCommandHandler:IRequestHandler<DeleteCommunityCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICommunityRepository _communityRepository;

    public DeleteCommunityCommandHandler(IUnitOfWork unitOfWork, ICommunityRepository communityRepository)
    {
        _unitOfWork = unitOfWork;
        _communityRepository = communityRepository;
    }

    public async Task Handle(DeleteCommunityCommand request, CancellationToken cancellationToken)
    {
        var community = await _communityRepository.GetByIdAsync(request.Id);
        if (community == null)
        {
            return;
        }

        _communityRepository.Delete(community);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}