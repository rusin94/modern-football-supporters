using AutoMapper;
using MFS.Core.Entities;
using MFS.Shared.Dto.NewsItems;

namespace MFS.Application.Mappings;

public class NewsItemMapProfile : Profile
{
    public NewsItemMapProfile()
    {
        CreateMap<NewsItem, NewsItemDto>()
            .ForMember(x => x.Author,
                opt => opt.MapFrom(
                    src => src.Author.Value))
            .ForMember(x=>x.Header,
                opt=>opt.MapFrom(
                    src=>src.Title.Value))
            .ForMember(x=>x.Content,
                opt=>opt.MapFrom(
                                       src=>src.Content.Value))
            .ReverseMap();
    }
}