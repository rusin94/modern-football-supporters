using MediatR;
using MFS.Shared.Dto.NewsItems;

namespace MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;

public record UpdateNewsItemCommand(NewsItemUpdateDto Dto) : IRequest<int>;
