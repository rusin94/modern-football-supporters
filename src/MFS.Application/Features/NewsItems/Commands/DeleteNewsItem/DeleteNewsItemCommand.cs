using MediatR;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.NewsItems.Commands.DeleteNewsItem;

public record DeleteNewsItemCommand(int Id) : IRequest<IResult>;
