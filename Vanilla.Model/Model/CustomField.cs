using System;
using System.Collections.Generic;

namespace Vanilla.Model
{
    public class CustomField
    {
        public int ProjectId { get; set; }
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public CustomFieldType CustomFieldType { get; set; }

        public IList<Item> Items { get; set; }
    }
}
