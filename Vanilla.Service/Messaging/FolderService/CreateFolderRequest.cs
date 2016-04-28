using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.Messaging.FolderService
{
    public class CreateFolderRequest : BaseRequest
    {
        public string FolderName { get; set; }
        public string Description { get; set; }
        public int? ParentFolderId { get; set; }
    }
}
