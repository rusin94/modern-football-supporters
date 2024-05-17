using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.Communities.Comands.DeleteCommunity;

public class DeleteCommunityCommandHandler : IRequestHandler<DeleteCommunityCommand, IResult>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICommunityRepository _communityRepository;

    public DeleteCommunityCommandHandler(IUnitOfWork unitOfWork, ICommunityRepository communityRepository)
    {
        _unitOfWork = unitOfWork;
        _communityRepository = communityRepository;
    }

    public async Task<IResult> Handle(DeleteCommunityCommand request, CancellationToken cancellationToken)
    {
        var community = await _communityRepository.GetByIdAsync(request.Id);
        if (community == null)
        {
            return await Result.FailAsync();
        }

        _communityRepository.Delete(community);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return await Result.SuccessAsync();
    }
}