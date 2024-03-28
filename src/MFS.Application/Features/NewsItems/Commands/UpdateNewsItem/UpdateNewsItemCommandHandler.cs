using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;

namespace MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;

public class UpdateNewsItemCommandHandler : IRequestHandler<UpdateNewsItemCommand, int>
{
    private readonly INewsItemRepository _newsItemRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateNewsItemCommandHandler(INewsItemRepository newsItemRepository, IUnitOfWork unitOfWork)
    {
        _newsItemRepository = newsItemRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<int> Handle(UpdateNewsItemCommand request, CancellationToken cancellationToken)
    {
        var newsItem = _newsItemRepository.GetById(request.Dto.Id);
        newsItem.Update(request.Dto.Header, request.Dto.Content, request.Dto.Author);
        _newsItemRepository.Update(newsItem);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return newsItem.Id;
    }
}