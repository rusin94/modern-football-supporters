using MFS.Core.Common;

namespace MFS.Core.Entities;

public class Sport : AuditableEntity<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<SportEvent> SportEvents { get; set; }
}