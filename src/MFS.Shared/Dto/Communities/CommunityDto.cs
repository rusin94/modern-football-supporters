namespace MFS.Shared.Dto.Communities;

public record CommunityDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
}