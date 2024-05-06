using MFS.Shared.Dto.Communities;
using MFS.Shared.Wrapper;

namespace MFS.Client.Infrastructure.Managers.Community;

public interface ICommunityManager : IManager
{
    Task<IResult<int>> CreateCommunityAsync(CommunityCreateDto dto);
    Task<IResult<int>> UpdateCommunityAsync(CommunityUpdateDto dto);
    Task<IResult<int>> DeleteCommunityAsync(int id);
    Task<IResult<List<CommunityDto>>> GetCommunitiesAsync();
}