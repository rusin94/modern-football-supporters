using MediatR;
using MFS.Shared.Dto.Communities;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.Communities.Comands.UpdateCommunity;

public record UpdateCommunityCommand(CommunityUpdateDto Dto) : IRequest<IResult<int>>;