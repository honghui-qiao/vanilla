using System;
using System.Collections.Generic;
using System.Linq;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.Messaging.FolderService
{
    public class GetFolderResponse : BaseResponse
    {
        public FolderView Folder { get; set; }
    }
}
