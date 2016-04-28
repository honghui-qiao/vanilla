using System;
using System.Collections.Generic;
using Vanilla.Infrastructure.Domain;

namespace Vanilla.Model
{
    public class Comment : EntityBase<int>, IAggregateRoot
    {
        public int? ParentCommentId { get; set; }
        public int ItemId { get; set; }


        public string Body { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual Comment ParentComment { get; set; }
        public virtual IList<Comment> ChildComments { get; set; }
        public virtual Item Item { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
