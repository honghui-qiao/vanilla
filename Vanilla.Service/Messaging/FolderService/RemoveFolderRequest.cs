using System;
using System.Collections.Generic;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.Messaging.FolderService
{
    public class RemoveFolderRequest : BaseRequest
    {
        public int FolderId { get; set; }
    }
}
