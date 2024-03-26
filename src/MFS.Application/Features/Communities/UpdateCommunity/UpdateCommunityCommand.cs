using MediatR;

namespace MFS.Application.Features.Communities.UpdateCommunity;

public record UpdateCommunityCommand : IRequest<int>
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
}