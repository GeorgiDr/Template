using System;
using System.Collections.Generic;
using System.Text;
using Template.Data.Core;

namespace Template.Data.Models
{
    public class Product : BaseModel<int>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Content { get; set; }

        public int ParentCategoryId  { get; set; }

        public virtual ParentCategory ParentCategory { get; set; }

        public string OldOrNew { get; set; }


    }
}
