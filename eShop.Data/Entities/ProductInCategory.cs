using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class ProductInCategory
    {
        public int ProcductId { set; get; }
        public Product Product { set; get; }
        public int CategoryId { set; get; }
        public Category Category { set; get; }
    }
}
