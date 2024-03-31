using AutoMapper;
using MFS.Core.Entities;
using MFS.Shared.Dto.NewsItems;

namespace MFS.Application.Mappings;

public class NewsItemMapProfile:Profile
{
    public NewsItemMapProfile()
    {
        CreateMap<NewsItem, NewsItemDto>().ReverseMap();
    }
}