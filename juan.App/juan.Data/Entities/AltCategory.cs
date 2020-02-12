using System;
using System.Collections.Generic;
using System.Text;

namespace juan.Data.Entities
{
    public class AltCategory : Base
    {
        public string Name { get; set; }
        public List<RelCategory> RelCategories { get; set; }
    }
}
