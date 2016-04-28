using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla.Service.LinqToTree
{
    public interface ILinqTree<T>
    {
        IEnumerable<T> Children();

        T Parent { get; }
    }
}
