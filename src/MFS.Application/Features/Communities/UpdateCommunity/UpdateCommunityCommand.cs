using MediatR;
using MFS.Shared.Dto.Communities;

namespace MFS.Application.Features.Communities.UpdateCommunity;

public record UpdateCommunityCommand(CommunityUpdateDto Dto) : IRequest<int>;