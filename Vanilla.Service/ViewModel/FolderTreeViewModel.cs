using System;
using System.Collections.Generic;

namespace Vanilla.Service.ViewModel
{
    public class FolderTreeViewModel
    {
        public FolderTreeViewModel()
        {
            Folders = new List<FolderView>();
        }

        public int SelectedFolderId { get; set; }
        public IList<FolderView> Folders { get; set; }
    }
}
