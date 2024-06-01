using MFS.Core.Common;

namespace MFS.Core.Entities;

public class SportEvent : AuditableEntity<Guid>
{
    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime Date { get; set; }
    
    public Guid SportId { get; set; }
    public SportType SportType { get; set; }
}