using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;

namespace MFS.Application.Features.NewsItems.Commands.EditNewsItem;

public class EditNewsItemCommandHandler : IRequestHandler<EditNewsItemCommand, int>
{
    private readonly INewsItemRepository _newsItemRepository;
    private readonly IUnitOfWork _unitOfWork;

    public EditNewsItemCommandHandler(INewsItemRepository newsItemRepository, IUnitOfWork unitOfWork)
    {
        _newsItemRepository = newsItemRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<int> Handle(EditNewsItemCommand request, CancellationToken cancellationToken)
    {
        var newsItem = _newsItemRepository.GetById(request.Id);
        newsItem.Update(request.Header, request.Content, request.Author);
        _newsItemRepository.Update(newsItem);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return newsItem.Id;
    }
}