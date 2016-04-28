using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla.Service.ViewModel
{
    public class ItemListViewModel
    {
        public ItemListViewModel()
        {
            Items = new List<ItemView>();
        }

        public IList<ItemView> Items { get; set; }
    }
}
