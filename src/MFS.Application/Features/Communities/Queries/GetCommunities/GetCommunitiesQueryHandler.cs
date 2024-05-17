using AutoMapper;
using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Shared.Dto.Communities;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.Communities.Queries.GetCommunities;

public class GetCommunitiesQueryHandler : IRequestHandler<GetCommunitiesQuery, IResult<List<CommunityDto>>>
{
    private readonly IMapper _mapper;
    private readonly ICommunityRepository _communityRepository;
    public GetCommunitiesQueryHandler(ICommunityRepository communityRepository, IMapper mapper)
    {
        _communityRepository = communityRepository;
        _mapper = mapper;
    }
    public async Task<IResult<List<CommunityDto>>> Handle(GetCommunitiesQuery request, CancellationToken cancellationToken)
    {
        var communities = await _communityRepository.GetAllAsync();
        var response = _mapper.Map<List<CommunityDto>>(communities);
        return await Result<List<CommunityDto>>.SuccessAsync(response);
    }
}