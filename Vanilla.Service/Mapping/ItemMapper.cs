using System;
using System.Collections.Generic;
using Vanilla.Model;
using Vanilla.Service.ViewModel;

namespace Vanilla.Service.Mapping
{
    public static class ItemMapper
    {
        public static ItemView ConvertToItemView(this Item item)
        {
            return new ItemView
            {
                ItemId = item.Id,
                Title = item.Title,
                Description = item.Description,
                Body = item.Body,
                AddedDate = item.AddedDate,
                ModifiedDate = item.ModifiedDate,
                FolderId = item.FolderId
            };
        }

        public static IList<ItemView> ConvertToItemViews(this IEnumerable<Item> items)
        {
            List<ItemView> views = new List<ItemView>();
            foreach (var a in items)
            {
                views.Add(a.ConvertToItemView());
            }
            return views;
        }
    }
}
