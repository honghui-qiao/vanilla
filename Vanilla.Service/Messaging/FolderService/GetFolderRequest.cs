using System;

namespace Vanilla.Service.Messaging
{
    public class GetFolderRequest : BaseRequest
    {
        public int FolderId { get; set; }
    }
}
