using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;

namespace MFS.Application.Features.Communities.Comands.UpdateCommunity;

public class UpdateCommunityCommandHandler : IRequestHandler<UpdateCommunityCommand, int>
{
    private readonly ICommunityRepository _communityRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateCommunityCommandHandler(ICommunityRepository communityRepository, IUnitOfWork unitOfWork)
    {
        _communityRepository = communityRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(UpdateCommunityCommand request, CancellationToken cancellationToken)
    {
        var community = await _communityRepository.GetByIdAsync(request.Dto.Id);
        if (community == null)
        {
            return default;
        }

        community.Name = request.Dto.Name;
        community.Description = request.Dto.Description;

        _communityRepository.Update(community);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return community.Id;
    }
}