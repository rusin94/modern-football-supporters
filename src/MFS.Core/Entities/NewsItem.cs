using MFS.Core.Common;
using MFS.Core.ValueObjects;

namespace MFS.Core.Entities;

public class NewsItem:AuditableEntity<int>
{
    public Header Header { get; private set; }
    public Content Content { get; private set; }
    public Author Author { get; private set; }
}