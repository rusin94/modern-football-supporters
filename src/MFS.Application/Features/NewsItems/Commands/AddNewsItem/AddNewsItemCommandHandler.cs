using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MFS.Core.Entities;
using MFS.Core.ValueObjects;
using MFS.Server.Infrastructure.Interfaces.Repositories;

namespace MFS.Application.Features.NewsItems.Commands.AddNewsItem
{
    public class AddNewsItemCommandHandler:IRequestHandler<AddNewsItemCommand, int>
    {
        private readonly INewsItemRepository _newsItemRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AddNewsItemCommandHandler(INewsItemRepository newsItemRepository, IUnitOfWork unitOfWork)
        {
            _newsItemRepository = newsItemRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(AddNewsItemCommand request, CancellationToken cancellationToken)
        {
            var newsItem = new NewsItem(request.Header, request.Content, request.Author);
            var entity = _newsItemRepository.Add(newsItem);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
