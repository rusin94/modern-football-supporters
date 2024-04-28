using MediatR;
using MFS.Shared.Dto.Communities;

namespace MFS.Application.Features.Communities.Comands.UpdateCommunity;

public record UpdateCommunityCommand(CommunityUpdateDto Dto) : IRequest<int>;