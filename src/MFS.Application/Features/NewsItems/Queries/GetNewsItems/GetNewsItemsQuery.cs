using MediatR;
using MFS.Shared.Dto.NewsItems;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.NewsItems.Queries.GetNewsItems;

public record GetNewsItemsQuery : IRequest<IResult<List<NewsItemDto>>>;