using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla.Service.Messaging.ItemService
{
    public class AddItemRequest : BaseRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public int FolderId { get; set; }
    }
}
