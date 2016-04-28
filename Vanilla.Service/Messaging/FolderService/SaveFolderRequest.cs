using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.Messaging.FolderService
{
    public class SaveFolderRequest : BaseRequest
    {
        public FolderView Folder { get; set; }
    }
}
