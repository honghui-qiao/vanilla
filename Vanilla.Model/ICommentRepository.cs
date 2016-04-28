using System;
using System.Collections.Generic;
using Vanilla.Infrastructure.Domain;

namespace Vanilla.Model
{
    public interface ICommentRepository : IRepository<Comment, int>
    {
        IEnumerable<Comment> GetChildComments(int commentId);
        IEnumerable<Comment> GetCommentsByItem(int itemId);
    }
}
