using MFS.Core.Common;
using MFS.Core.ValueObjects.Community;

namespace MFS.Core.Entities;

public class Community : AuditableEntity<int>
{
    public Name Name { get; set; }
    public Description Description { get; set; }
}