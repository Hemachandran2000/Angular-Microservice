using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartDTO
{
    public class SubCategorydto
    {
        public Guid SubCategoryId { get; set; }
        public string CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string SubCategoryDesc { get; set; }
    }
}
