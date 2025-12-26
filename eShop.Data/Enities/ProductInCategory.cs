using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data.Enities
{
    public class ProductInCategory
    {
        public int ProductId { set; get; }
        
        public int CategoryId { set; get; }

        //Navigation Properties
        public Product Product { set; get; }
        public Category Category { set; get; }

    }
}
