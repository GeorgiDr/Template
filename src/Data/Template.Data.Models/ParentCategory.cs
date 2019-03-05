using System;
using System.Collections.Generic;
using System.Text;
using Template.Data.Core;

namespace Template.Data.Models
{
    public class ParentCategory : BaseModel<int>
    {
        public string Name { get; set; }
    }
}
