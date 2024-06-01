using MFS.Core.Common;
using MFS.Core.ValueObjects.NewsItem;

namespace MFS.Core.Entities;

public class NewsItem:AuditableEntity<int>
{
    public Title Title { get; private set; }
    public Content Content { get; private set; }
    public Author Author { get; private set; }
    public int SportTypeId { get; private set; }
    public SportType SportType { get; private set; }

    public NewsItem(Title title, Content content, Author author, int sportTypeId)
    {
        Title = title;
        Content = content;
        Author = author;
        SportTypeId = sportTypeId;
    }

    public void Update(string requestHeader, string requestContent, string requestAuthor, int sportTypeId)
    {
        Title = new Title(requestHeader);
        Content = new Content(requestContent);
        Author = new Author(requestAuthor);
        SportTypeId = sportTypeId;
    }
}