using MFS.Core.Common;
using MFS.Core.ValueObjects.Community;

namespace MFS.Core.Entities;

public class SportEvent : AuditableEntity<Guid>
{
    public Name Name { get; set; }

    public Description Description { get; set; }

    public DateTime Date { get; set; }
    
    public Guid SportId { get; set; }
    public SportType SportType { get; set; }
}