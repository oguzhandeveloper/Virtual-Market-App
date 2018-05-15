using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class VirtualMarket
    {
        public List<CategoryBST> Categories { get; set; }
        public HashMap Hash { get; set; }
        public MaxHeap MaxHeapObject { get; set; }
        public MinHeap MinHeapObject { get; set; }

        public void InsertProduct(Product product, string productType, string CategoryName)
        {
            Hash.Add(product.ProductDescription, product);
            MaxHeapObject.Add(product);
            MinHeapObject.Add(product);

            bool isAdded = false;
            for (int i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].CategoryName.Equals(CategoryName))
                {
                    isAdded = true;
                    Categories[i].Insert(product, productType);
                }
            }

            if (!isAdded)
            {
                CategoryBST category = new CategoryBST();
                category.CategoryName = CategoryName;
                category.Insert(product, productType);
                Categories.Add(category);
            }
        }

      


    }
}
