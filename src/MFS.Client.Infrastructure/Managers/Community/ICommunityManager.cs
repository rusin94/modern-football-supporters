using MFS.Shared.Dto.Communities;
using MFS.Shared.Wrapper;

namespace MFS.Client.Infrastructure.Managers.Community;

public interface ICommunityManager
{
    Task<IResult<int>> CreateCommunityAsync(CommunityCreateDto dto, CancellationToken cancellationToken);
    Task<IResult<int>> UpdateCommunityAsync(CommunityUpdateDto dto, CancellationToken cancellationToken);
    Task<IResult<int>> DeleteCommunityAsync(int id, CancellationToken cancellationToken);
    Task<IResult<List<CommunityDto>>> GetCommunitiesAsync(CancellationToken cancellationToken);
}