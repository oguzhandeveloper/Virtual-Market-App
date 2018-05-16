using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class CategoryProduct
    {
        public string ProductType { get; set; }
        public List<Product> Products { get; set; }

        public CategoryProduct(string ProductType)
        {
            this.ProductType = ProductType;
        }

        public void Insert(Product product)
        {
            Products.Add(product);
        }
    }
}
