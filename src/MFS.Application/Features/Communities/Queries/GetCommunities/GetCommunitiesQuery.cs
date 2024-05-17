using MediatR;
using MFS.Shared.Dto.Communities;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.Communities.Queries.GetCommunities;

public record GetCommunitiesQuery: IRequest<IResult<List<CommunityDto>>>;