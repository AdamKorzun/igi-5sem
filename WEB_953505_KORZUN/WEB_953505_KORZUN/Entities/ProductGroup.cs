using System;
using System.Collections.Generic;

namespace WEB_953505_KORZUN.Entities
{
    public class ProductGroup
    {
        public int ProductGroupId { get; set; }
        public string GroupName { get; set; }
        public List<Product> Products { get; set; }
    }
}
