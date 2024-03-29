using MediatR;
using MFS.Shared.Dto.NewsItems;

namespace MFS.Application.Features.NewsItems.Commands.CreateNewsItem;

public record CreateNewsItemCommand(NewsItemCreateDto Dto) : IRequest<int>;