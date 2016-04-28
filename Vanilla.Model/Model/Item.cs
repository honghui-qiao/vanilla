using System;
using System.Collections.Generic;
using Vanilla.Infrastructure.Domain;

namespace Vanilla.Model
{
    public class Item : EntityBase<int>, IAggregateRoot
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int? FolderId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }

        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Folder Folder { get; set; }
        public virtual IList<Comment> Comments { get; set; }
        //public virtual IList<CustomField> CustomFields { get; set; }
        //public virtual IList<CustomPage> CustomPages { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
