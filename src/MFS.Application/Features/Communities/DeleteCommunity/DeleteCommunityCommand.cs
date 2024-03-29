using MediatR;

namespace MFS.Application.Features.Communities.DeleteCommunity;

public record DeleteCommunityCommand(int Id) :IRequest;