using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Model;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.Mapping
{
    public static class FolderMapper
    {
        public static FolderView FlattenFolderModel(Folder folder)
        {
            FolderView view = new FolderView();
            view.Id = folder.Id;
            view.ParentFolderId = folder.ParentFolderId;
            view.FolderName = folder.FolderName;
            view.Description = folder.Description;
            view.AddedDate = folder.AddedDate;

            foreach (var f in folder.ChildFolders)
            {
                FolderView _v = FlattenFolderModel(f);
                _v.ParentFolder = view;
                view.ChildFolders.Add(_v);
            }

            return view;
        }

        public static FolderView ConvertToFolderView(this Folder folder)
        {
            return FlattenFolderModel(folder);
        }

        public static IList<FolderView> ConvertToFolderViews(this IEnumerable<Folder> folders)
        {
            IList<FolderView> views = new List<FolderView>();
            foreach (var f in folders)
            {
                views.Add(ConvertToFolderView(f));
            }

            return views;
        }
    }
}
