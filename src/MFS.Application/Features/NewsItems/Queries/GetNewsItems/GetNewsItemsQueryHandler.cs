using AutoMapper;
using MediatR;
using MFS.Server.Infrastructure.Interfaces.Repositories;
using MFS.Shared.Dto.NewsItems;
using MFS.Shared.Wrapper;

namespace MFS.Application.Features.NewsItems.Queries.GetNewsItems;

public class GetNewsItemsQueryHandler : IRequestHandler<GetNewsItemsQuery, Result<List<NewsItemDto>>>
{
    private readonly IMapper _mapper;
    private readonly INewsItemRepository _newsItemRepository;

    public GetNewsItemsQueryHandler(IMapper mapper, INewsItemRepository newsItemRepository)
    {
        _mapper = mapper;
        _newsItemRepository = newsItemRepository;
    }

    public async Task<Result<List<NewsItemDto>>> Handle(GetNewsItemsQuery request, CancellationToken cancellationToken)
    {
        var newsItems = await _newsItemRepository.GetAllAsync();
        var response = _mapper.Map<List<NewsItemDto>>(newsItems);
        return await Result<List<NewsItemDto>>.SuccessAsync(response);
    }
}