using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vanilla.Service.LinqToTree
{
    public interface ILinqToTree<T>
    {
        IEnumerable<ILinqToTree<T>> Children();
        ILinqToTree<T> Parent { get; }
        T Item { get; }
    }
}
