using System;
using System.Collections.Generic;

namespace Vanilla.Service.Messaging.FolderService
{
    public class GetFoldersRequest : BaseRequest
    {
        public int ParentFolderId { get; set; }
    }
}
