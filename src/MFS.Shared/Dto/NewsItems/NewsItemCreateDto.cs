namespace MFS.Shared.Dto.NewsItems;

public record NewsItemCreateDto
{
    public string Header { get; init; }
    public string Content { get; init; }
    public string Author { get; init; }
}