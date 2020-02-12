using System;
using System.Collections.Generic;
using System.Text;

namespace juan.Data.Entities
{
    public class RelCategory : Base
    {
        public Category Category { get; set; }
        public AltCategory AltCategory { get; set; }
        public int CategoryId { get; set; }
        public int AltCategoryId { get; set; }

    }
}
