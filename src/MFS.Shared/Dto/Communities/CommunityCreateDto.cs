namespace MFS.Shared.Dto.Communities;

public record CommunityCreateDto
{
    public string Name { get; init; }
    public string Description { get; init; }
}