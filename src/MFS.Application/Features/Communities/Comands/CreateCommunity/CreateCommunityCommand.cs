using MediatR;
using MFS.Shared.Dto.Communities;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.Communities.Comands.CreateCommunity;

public record CreateCommunityCommand(CommunityCreateDto Dto) : IRequest<IResult<int>>;