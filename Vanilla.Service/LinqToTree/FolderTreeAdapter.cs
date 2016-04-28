using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Service.LinqToTree;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.LinqToTree
{
    public class FolderTreeAdapter : ILinqTree<FolderView>
    {
        FolderView _view;
        FolderTreeAdapter(FolderView view)
        {
            _view = view;
        }


        public IEnumerable<FolderView> Children()
        {
            foreach (var v in _view.ChildFolders)
            {
                yield return v;
            }
        }

        public FolderView Parent
        {
            get
            {
                return _view.ParentFolder;
            }
        }
    }
}
