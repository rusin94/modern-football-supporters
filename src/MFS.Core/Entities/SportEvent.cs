using MFS.Core.Common;

namespace MFS.Core.Entities;

public class SportEvent : AuditableEntity<Guid>
{
    string Name { get; set; }

    string Description { get; set; }

    DateTime Date { get; set; }
    
    public Guid SportId { get; set; }
    public Sport Sport { get; set; }
}