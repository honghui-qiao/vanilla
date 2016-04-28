using System;
using System.Collections.Generic;
using Vanilla.Infrastructure.Domain;

namespace Vanilla.Model
{
    public interface IItemRepository : IRepository<Item, int>
    {
        IEnumerable<Item> GetItemsByFolder(int folderId);
    }
}
