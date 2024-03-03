using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFS.Core.Common;

public abstract class AuditableEntity<T> : IAuditableEntity<T>
{
    public T Id { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime? LastModifiedOn { get; set; }
}