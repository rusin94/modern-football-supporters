using MediatR;
using MFS.Shared.Dto.NewsItems;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.NewsItems.Commands.CreateNewsItem;

public record CreateNewsItemCommand(NewsItemCreateDto Dto) : IRequest<IResult<int>>;