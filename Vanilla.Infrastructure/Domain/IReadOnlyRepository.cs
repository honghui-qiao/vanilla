using System.Collections.Generic;
using Vanilla.Infrastructure.Querying;

namespace Vanilla.Infrastructure.Domain
{
    public interface IReadOnlyRepository<T, TId> where T : IAggregateRoot
    {
        T FindBy(TId id);

        IEnumerable<T> FindAll();
        IEnumerable<T> FindAll(int index, int count);

        IEnumerable<T> FindBy(Query query);
        IEnumerable<T> FindBy(Query query, int index, int count);
    }
}
