using MediatR;

namespace MFS.Application.Features.Communities.DeleteCommunity;

public record DeleteCommunityCommand :IRequest
{
    public int Id { get; init; }
}