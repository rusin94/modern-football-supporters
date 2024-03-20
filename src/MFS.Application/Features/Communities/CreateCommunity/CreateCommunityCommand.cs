using MediatR;

namespace MFS.Application.Features.Communities.CreateCommunity;

public record CreateCommunityCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
}