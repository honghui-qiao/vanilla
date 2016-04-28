using System;
using System.Collections.Generic;
using Vanilla.Infrastructure.Domain;

namespace Vanilla.Model
{
    public interface IFolderRepository : IRepository<Folder, int>
    {
        IEnumerable<Folder> GetChildFolders(int folderId);
    }
}
