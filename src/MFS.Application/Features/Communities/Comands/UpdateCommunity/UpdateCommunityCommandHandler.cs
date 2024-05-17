using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.Communities.Comands.UpdateCommunity;

public class UpdateCommunityCommandHandler : IRequestHandler<UpdateCommunityCommand, IResult<int>>
{
    private readonly ICommunityRepository _communityRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateCommunityCommandHandler(ICommunityRepository communityRepository, IUnitOfWork unitOfWork)
    {
        _communityRepository = communityRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IResult<int>> Handle(UpdateCommunityCommand request, CancellationToken cancellationToken)
    {
        var community = await _communityRepository.GetByIdAsync(request.Dto.Id);
        if (community == null)
        {
            return await Result<int>.FailAsync();
        }

        community.Name = request.Dto.Name;
        community.Description = request.Dto.Description;

        _communityRepository.Update(community);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return await Result<int>.SuccessAsync(community.Id);
    }
}