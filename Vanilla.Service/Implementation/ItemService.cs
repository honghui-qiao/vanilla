using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanilla.Model;
using Vanilla.Service.Interface;
using Vanilla.Service.ViewModel;
using Vanilla.Service.Mapping;

namespace Vanilla.Service.Implementation
{
    public class ItemService : IItemService
    {
        private IItemRepository _rep;
        public ItemService(IItemRepository r)
        {
            _rep = r;
        }

        public ItemView GetItemBy(int id)
        {
            return _rep.FindBy(id).ConvertToItemView();
        }

        public IList<ItemView> GetAllItems()
        {
            return _rep.GetItemsByFolder(0).ConvertToItemViews();
        }

        public IList<ItemView> GetItemsByFolder(int folderId)
        {
            return _rep.GetItemsByFolder(folderId).ConvertToItemViews();
        }

        public BaseResponse AddItem(ItemView view)
        {
            Item item = new Item();
            item.Title = view.Title;
            item.Description = view.Description;
            item.Body = view.Body;
            item.AddedDate = DateTime.UtcNow;
            item.ModifiedDate = DateTime.UtcNow;
            int id = _rep.Add(item);

            return new BaseResponse
            {
                Success = id > 0,
                Message = "Added Item " + id
            };
            throw new NotImplementedException();
        }

        public BaseResponse SaveItem(ItemView item)
        {
            throw new NotImplementedException();
        }

        public BaseResponse DeleteItem(ItemView item)
        {
            throw new NotImplementedException();
        }
    }
}
