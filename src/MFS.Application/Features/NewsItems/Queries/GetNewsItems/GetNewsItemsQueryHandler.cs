using AutoMapper;
using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Shared.Dto.NewsItems;

namespace MFS.Application.Features.NewsItems.Queries.GetNewsItems;

public class GetNewsItemsQueryHandler : IRequestHandler<GetNewsItemsQuery, List<NewsItemDto>>
{
    private readonly IMapper _mapper;
    private readonly INewsItemRepository _newsItemRepository;

    public GetNewsItemsQueryHandler(IMapper mapper, INewsItemRepository newsItemRepository)
    {
        _mapper = mapper;
        _newsItemRepository = newsItemRepository;
    }

    public async Task<List<NewsItemDto>> Handle(GetNewsItemsQuery request, CancellationToken cancellationToken)
    {
        var newsItems = await _newsItemRepository.GetAllAsync();
        return _mapper.Map<List<NewsItemDto>>(newsItems);
    }
}