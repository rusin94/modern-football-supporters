using MediatR;
using MFS.Shared.Dto.NewsItems;

namespace MFS.Application.Features.NewsItems.Queries.GetNewsItems;

public record GetNewsItemsQuery : IRequest<List<NewsItemDto>>;