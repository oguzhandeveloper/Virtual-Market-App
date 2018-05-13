using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class Product
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }
        public decimal Cost { get; set; }
        public decimal SalePrice { get; set; }
        public string ProductDescription { get; set; }


        public Product()
        {
        }
    }
}
