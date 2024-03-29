namespace MFS.Shared.Dto.Communities;

public record CommunityUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}