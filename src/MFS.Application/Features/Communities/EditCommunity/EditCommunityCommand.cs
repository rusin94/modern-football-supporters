using MediatR;

namespace MFS.Application.Features.Communities.EditCommunity;

public record EditCommunityCommand : IRequest<int>
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
}