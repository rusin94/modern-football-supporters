﻿namespace MFS.Application.Features.NewsItems.Commands.UpdateNewsItem;

public record NewsItemUpdateDto
{
    public int Id { get; init; }
    public string Header { get; init; }
    public string Content { get; init; }
    public string Author { get; init; }
}