using System;
using System.Collections.Generic;
using Vanilla.Infrastructure.Domain;

namespace Vanilla.Model
{
    public class Folder : EntityBase<int>, IAggregateRoot
    {
        public Folder()
        {
            ChildFolders = new List<Folder>();
            Items = new List<Item>();
        }

        public int? ParentFolderId { get; set; }

        public Project Project { get; set; }
        public int ProjectId { get; set; }

        public string FolderName { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Folder ParentFolder { get; set; }
        public virtual IList<Folder> ChildFolders { get; set; }
        public virtual IList<Item> Items { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
