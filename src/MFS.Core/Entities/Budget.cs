using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFS.Core.ValueObjects;

namespace MFS.Core.Entities
{
    public class Budget
    {
        public Summary Summary { get; set; }
        public List<Income> Incomes { get; set; }
        public List<Outcome> Outcomes { get; set; } 

    }
}
