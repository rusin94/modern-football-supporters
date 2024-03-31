namespace MFS.Shared.Dto.NewsItems;

public record NewsItemDto
{
    public int Id { get; set; }
    public string Header { get; init; }
    public string Content { get; init; }
    public string Author { get; init; }
}