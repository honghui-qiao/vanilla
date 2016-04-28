using System;
using System.Collections.Generic;

namespace Vanilla.Service.ViewModel
{
    public class ItemView
    {
        public ItemView()
        {
            Comments = new List<CommentView>();
        }

        public FolderView Folder { get; set; }
        public int ItemId { get; set; }
        public int? FolderId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public IList<CommentView> Comments { get; set; }
    }
}
