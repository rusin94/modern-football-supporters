using MediatR;
using MFS.Shared.Dto.Communities;

namespace MFS.Application.Features.Communities.Comands.CreateCommunity;

public record CreateCommunityCommand(CommunityCreateDto Dto) : IRequest<int>;