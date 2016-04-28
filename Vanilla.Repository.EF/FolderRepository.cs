using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Vanilla.Model;
using Vanilla.Infrastructure;
using Vanilla.Infrastructure.Domain;
using Vanilla.Infrastructure.Querying;

namespace Vanilla.Repository.EF
{
    public class FolderRepository : IFolderRepository
    {
        private VanillaContext _ctx;

        public FolderRepository(VanillaContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Folder> FindAll()
        {
            return _ctx.Folders.ToList();
        }

        public IEnumerable<Folder> FindAll(int index, int count)
        {
            return _ctx.Folders.OrderBy(m => m.AddedDate)
                .Skip(index * count).Take(count);
        }

        public Folder FindBy(int id)
        {
            return _ctx.Folders.SingleOrDefault(c => c.Id == id);
        }

        public int Add(Folder entity)
        {
            Folder f = _ctx.Folders.Add(entity);
            _ctx.SaveChanges();
            return f.Id;
        }

        public void Save(Folder entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Remove(Folder entity)
        {
            _ctx.Folders.Remove(entity);
        }

        public IEnumerable<Folder> GetChildFolders(int folderId)
        {
            return _ctx.Folders.Where(c => c.ParentFolderId == folderId);
        }

        public IEnumerable<Folder> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Folder> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }
    }
}
