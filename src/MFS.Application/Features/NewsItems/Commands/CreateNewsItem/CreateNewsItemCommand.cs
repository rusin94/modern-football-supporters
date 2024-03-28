using MediatR;

namespace MFS.Application.Features.NewsItems.Commands.AddNewsItem;

public record CreateNewsItemCommand(NewsItemCreateDto Dto) : IRequest<int>;
