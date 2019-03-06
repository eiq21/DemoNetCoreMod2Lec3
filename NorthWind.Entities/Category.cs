using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWind.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Product { get; set; }
    }
}
