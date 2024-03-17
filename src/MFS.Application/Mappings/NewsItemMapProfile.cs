using AutoMapper;
using MFS.Application.DTOs.NewsItem;
using MFS.Core.Entities;

namespace MFS.Application.Mappings;

public class NewsItemMapProfile:Profile
{
    public NewsItemMapProfile()
    {
        CreateMap<NewsItem, NewsItemDto>().ReverseMap();
    }
}