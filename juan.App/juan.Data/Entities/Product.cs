using System;
using System.Collections.Generic;
using System.Text;

namespace juan.Data.Entities
{
    class Product
    {
        public string Name { get; set; }
        public int RelCategoryId { get; set; }
        public List<RelCategory> RelCategories { get; set; }
        public string Desc { get; set; }
        public int ColorId { get; set; }
        public int ProductId { get; set; }

    }
}
