namespace MFS.Shared.Dto.Communities;

public record CommunityCreateDto
{
    public string Name { get; set; }
    public string Description { get; set; }
}