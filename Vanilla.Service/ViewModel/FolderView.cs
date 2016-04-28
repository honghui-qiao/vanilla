using System;
using System.Collections.Generic;

namespace Vanilla.Service.ViewModel
{
    public class FolderView
    {
        public FolderView()
        {
            ChildFolders = new List<FolderView>();
            Items = new List<ItemView>();
        }

        public int Id { get; set; }
        public int? ParentFolderId { get; set; }
        public string FolderName { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public FolderView ParentFolder { get; set; }
        public IList<FolderView> ChildFolders { get; set; }
        public IList<ItemView> Items { get; set; }
    }
}
