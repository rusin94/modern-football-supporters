using MediatR;

namespace MFS.Application.Features.NewsItems.Commands.DeleteNewsItem;

public record DeleteNewsItemCommand(int Id) : IRequest;
