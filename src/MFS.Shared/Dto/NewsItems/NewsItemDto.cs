namespace MFS.Shared.Dto.NewsItems;

public record NewsItemDto
{
    public int Id { get; set; }
    public string Header { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
}