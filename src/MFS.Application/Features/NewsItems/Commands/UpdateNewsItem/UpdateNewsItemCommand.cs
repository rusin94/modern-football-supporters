using MediatR;
using MFS.Shared.Dto.NewsItems;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;

public record UpdateNewsItemCommand(NewsItemUpdateDto Dto) : IRequest<IResult<int>>;
