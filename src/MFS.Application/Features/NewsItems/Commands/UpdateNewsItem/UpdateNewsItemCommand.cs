using MediatR;

namespace MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;

public record UpdateNewsItemCommand(NewsItemUpdateDto Dto) : IRequest<int>;
