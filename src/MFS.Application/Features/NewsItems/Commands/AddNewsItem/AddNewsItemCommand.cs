﻿using MediatR;

namespace MFS.Application.Features.NewsItems.Commands.AddNewsItem;

public class AddNewsItemCommand :IRequest<int>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
}