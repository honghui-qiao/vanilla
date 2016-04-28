using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Vanilla.Infrastructure.Querying;
using Vanilla.Model;

namespace Vanilla.Repository.EF
{
    public class ItemRepository : IItemRepository
    {
        private VanillaContext _ctx;
        public ItemRepository(VanillaContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Item> GetItemsByFolder(int folderId = 0)
        {
            if (folderId == 0)
            {
                return _ctx.Items.OrderByDescending(x => x.AddedDate);
            }
            else
            {
                return _ctx.Items.Where(c => c.FolderId == folderId);
            }
        }

        public int Add(Item entity)
        {
            Item item = _ctx.Items.Add(entity);
            _ctx.SaveChanges();
            return item.Id;
        }

        public void Save(Item entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Remove(Item entity)
        {
            _ctx.Items.Remove(entity);
            _ctx.SaveChanges();
        }

        public Item FindBy(int id)
        {
            return _ctx.Items.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Item> FindAll()
        {
            return _ctx.Items.ToList();
        }

        public IEnumerable<Item> FindAll(int index, int count)
        {
            return _ctx.Items.OrderBy(m => m.AddedDate)
                .Skip(index * count).Take(count);
        }

        public IEnumerable<Item> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }
    }
}
