namespace MFS.Shared.Dto.NewsItems;

public record NewsItemCreateDto
{
    public string Header { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
}