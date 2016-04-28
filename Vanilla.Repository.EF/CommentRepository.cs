using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Vanilla.Model;

namespace Vanilla.Repository.EF
{
    public class CommentRepository : ICommentRepository
    {
        private VanillaContext _ctx;
        public CommentRepository(VanillaContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Comment> GetChildComments(int commentId)
        {
            return _ctx.Comments.Where(c => c.ParentCommentId == commentId);
        }

        public IEnumerable<Comment> GetCommentsByItem(int itemId)
        {
            return _ctx.Comments.Where(c => c.ItemId == itemId && c.ParentCommentId == null);
        }

        public int Add(Comment entity)
        {
            Comment c = _ctx.Comments.Add(entity);
            _ctx.SaveChanges();
            return c.Id;
        }

        public void Save(Comment entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Remove(Comment entity)
        {
            _ctx.Comments.Remove(entity);
            _ctx.SaveChanges();
        }

        public Comment FindBy(int id)
        {
            return _ctx.Comments.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Comment> FindAll()
        {
            return _ctx.Comments.Where(c => c.ParentCommentId == null).ToList();
        }

        public IEnumerable<Comment> FindAll(int index, int count)
        {
            return _ctx.Comments.Where(c => c.ParentCommentId == null)
                .OrderBy(c => c.AddedDate)
                .Skip(index * count).Take(count);
        }

        public IEnumerable<Comment> FindBy(Infrastructure.Querying.Query query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> FindBy(Infrastructure.Querying.Query query, int index, int count)
        {
            throw new NotImplementedException();
        }
    }
}
