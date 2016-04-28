using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Vanilla.Service.ViewModel
{
    public class ItemCreationVM
    {
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Body { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public int FolderId { get; set; }
        public SelectList Folders { get; set; }
    }
}
