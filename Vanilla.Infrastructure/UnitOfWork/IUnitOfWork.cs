using System;
using System.Collections.Generic;
using Vanilla.Infrastructure.Domain;

namespace Vanilla.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        void RegisterAmended(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository);
        void RegisterNew(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository);
        void RegisterRemoved(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository);

        void Commit();
    }
}
