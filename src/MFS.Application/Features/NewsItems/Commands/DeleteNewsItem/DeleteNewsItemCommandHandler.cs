using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.NewsItems.Commands.DeleteNewsItem;

public class DeleteNewsItemCommandHandler:IRequestHandler<DeleteNewsItemCommand, IResult>
{
    private readonly INewsItemRepository _newsItemRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteNewsItemCommandHandler(INewsItemRepository newsItemRepository, IUnitOfWork unitOfWork)
    {
        _newsItemRepository = newsItemRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IResult> Handle(DeleteNewsItemCommand request, CancellationToken cancellationToken)
    {
        var newsItem = _newsItemRepository.GetById(request.Id);
        if (newsItem == null)
        {
            return await Result.FailAsync();
        }
        _newsItemRepository.Delete(newsItem);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return await Result.SuccessAsync();
    }
}