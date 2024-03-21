using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;

namespace MFS.Application.Features.Communities.EditCommunity;

public class EditCommunityCommandHandler:IRequestHandler<EditCommunityCommand, int>
{
    private readonly ICommunityRepository _communityRepository;
    private readonly IUnitOfWork _unitOfWork;

    public EditCommunityCommandHandler(ICommunityRepository communityRepository, IUnitOfWork unitOfWork)
    {
        _communityRepository = communityRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(EditCommunityCommand request, CancellationToken cancellationToken)
    {
        var community = await _communityRepository.GetByIdAsync(request.Id);
        if (community == null)
        {
            return default;
        }

        community.Name = request.Name;
        community.Description = request.Description;

        _communityRepository.Update(community);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return community.Id;
    }
}