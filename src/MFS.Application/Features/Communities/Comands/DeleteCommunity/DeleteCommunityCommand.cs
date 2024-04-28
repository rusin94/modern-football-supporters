using MediatR;

namespace MFS.Application.Features.Communities.Comands.DeleteCommunity;

public record DeleteCommunityCommand(int Id) : IRequest;