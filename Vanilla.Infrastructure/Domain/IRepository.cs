namespace Vanilla.Infrastructure.Domain
{
    public interface IRepository<T, TId> : IReadOnlyRepository<T, TId> where T : IAggregateRoot
    {
        TId Add(T entity);
        void Save(T entity);
        void Remove(T entity);
    }
}
