using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public static class CompareProducts
    {
        public static int Compare(CategoryProduct first, CategoryProduct second)
        {
            return (String.Compare(first.ProductType, second.ProductType, true));
            //0 dönerse eşit
            //1 dönerse 1. Büyük
            //-1 dönerse 2. Büyük
        }

        public static int Compare(CategoryProduct first, string key)
        {
            return (String.Compare(first.ProductType, key, true));
            //0 dönerse eşit
            //1 dönerse 1. Büyük
            //-1 dönerse 2. Büyük
        }

        public static Product CompareProduct(CategoryProduct category, string key)
        {
            List<Product> products = category.Products;
            int i;
            for ( i = 0; i < products.Count; i++)
            {
                if (String.Compare(products[i].ProductDescription, key) == 0)
                    return products[i];
            }

            return null;
        }


    }
}
