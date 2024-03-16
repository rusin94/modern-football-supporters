using MediatR;

namespace MFS.Application.Features.NewsItems.Commands.DeleteNewsItem
{
    public record DeleteNewsItemCommand:IRequest
    {
        public int Id { get; set; }
    }
}
