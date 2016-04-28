using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla.Infrastructure.Querying
{
    public class OrderByClause
    {
        public string OrderByPropertyName { get; set; }
        public bool Desc { get; set; }
    }
}
