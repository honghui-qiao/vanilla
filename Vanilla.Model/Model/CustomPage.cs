using System.Collections.Generic;

namespace Vanilla.Model
{
    public class CustomPage
    {
        public CustomPage()
        {
            ItemCustomFields = new List<CustomField>();
        }

        public int ProjectId { get; set; }
        public int PageId { get; set; }

        public string PageName { get; set; }

        public IList<CustomField> ItemCustomFields { get; set; }
    }
}
