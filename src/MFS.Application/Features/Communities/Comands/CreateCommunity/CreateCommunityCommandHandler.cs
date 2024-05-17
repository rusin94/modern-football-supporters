using MediatR;
using MFS.Core.Entities;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.Communities.Comands.CreateCommunity;

public class CreateCommunityCommandHandler : IRequestHandler<CreateCommunityCommand, IResult<int>>
{
    private readonly ICommunityRepository _communityRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCommunityCommandHandler(IUnitOfWork unitOfWork, ICommunityRepository communityRepository)
    {
        _unitOfWork = unitOfWork;
        _communityRepository = communityRepository;
    }

    public async Task<IResult<int>> Handle(CreateCommunityCommand request, CancellationToken cancellationToken)
    {
        var community = new Community
        {
            Name = request.Dto.Name,
            Description = request.Dto.Description
        };

        var result = _communityRepository.Create(community);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return await Result<int>.SuccessAsync(result.Id);
    }
}