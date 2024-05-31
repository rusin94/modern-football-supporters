using MFS.Core.Common;
using MFS.Core.ValueObjects.Community;

namespace MFS.Core.Entities;

public class SportType : AuditableEntity<Guid>
{
    public Name Name { get; set; }
    public Description Description { get; set; }
    public ICollection<SportEvent> SportEvents { get; set; }
}