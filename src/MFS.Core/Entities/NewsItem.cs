using MFS.Core.Common;
using MFS.Core.ValueObjects;

namespace MFS.Core.Entities;

public class NewsItem:AuditableEntity<int>
{
    public Title Title { get; private set; }
    public Content Content { get; private set; }
    public Author Author { get; private set; }

    public NewsItem(Title title, Content content, Author author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
}