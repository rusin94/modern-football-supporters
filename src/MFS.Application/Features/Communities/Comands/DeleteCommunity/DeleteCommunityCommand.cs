using MediatR;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.Communities.Comands.DeleteCommunity;

public record DeleteCommunityCommand(int Id) : IRequest<IResult>;