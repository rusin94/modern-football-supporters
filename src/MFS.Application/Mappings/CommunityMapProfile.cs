using AutoMapper;
using MFS.Core.Entities;
using MFS.Shared.Dto.Communities;

namespace MFS.Application.Mappings;

public class CommunityMapProfile : Profile
{
    public CommunityMapProfile()
    {
        CreateMap<Community, CommunityDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Value))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description.Value));
    }
}