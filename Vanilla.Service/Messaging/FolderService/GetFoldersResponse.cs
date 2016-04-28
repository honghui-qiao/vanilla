using System;
using System.Collections.Generic;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.Messaging.FolderService
{
    public class GetFoldersResponse : BaseResponse
    {
        public IEnumerable<FolderView> Folders { get; set; }
    }
}
