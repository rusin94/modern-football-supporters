using MFS.Shared.Dto.Communities;

namespace MFS.Client.Infrastructure.Managers.Community;

public interface ICommunityManager
{
    Task<int> CreateCommunityAsync(CommunityCreateDto dto, CancellationToken cancellationToken);
    Task UpdateCommunityAsync(CommunityUpdateDto dto, CancellationToken cancellationToken);
    Task DeleteCommunityAsync(int id, CancellationToken cancellationToken);
}