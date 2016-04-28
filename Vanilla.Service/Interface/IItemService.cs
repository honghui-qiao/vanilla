using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vanilla.Service.Messaging;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.Interface
{
    public interface IItemService
    {
        ItemView GetItemBy(int id);

        IList<ItemView> GetAllItems();
        IList<ItemView> GetItemsByFolder(int folderId);

        BaseResponse AddItem(ItemView item);
        BaseResponse SaveItem(ItemView item);
        BaseResponse DeleteItem(ItemView item);
    }
}
