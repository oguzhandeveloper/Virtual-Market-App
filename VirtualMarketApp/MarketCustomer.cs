using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class MarketCustomer : Person
    {
        public VirtualMarket Market { get; set; }
        public List<Product> ShoppingList { get; set; }

        public MarketCustomer()
        {
            ShoppingList = new List<Product>();
        }

        public void Add(Product product)
        {
            Product product1 = ProductControl(product.ProductDescription);
            if (product1 != null)
                return;
            ShoppingList.Add(product);
        }

        public Product ProductControl(string productDesctription)
        {
            Product product = null;
            for (int i = 0; i < ShoppingList.Count; i++)
            {
                if (ShoppingList[i].ProductDescription.Equals(productDesctription))
                {
                    product = ShoppingList[i];
                    break;
                }
            }

            return product;
        }

        public void BuyAll()
        {
            int length = ShoppingList.Count;
           while(ShoppingList.Count != 0)
            {
                ShoppingList[0].Amount--;
                ShoppingList.RemoveAt(0);
            }
            
        }

        public bool BuyProduct(string productDescription)
        {

            Product product = ProductControl(productDescription);
            if (product == null)
                return false;
            product.Amount--;
            ShoppingList.Remove(product);
            return true;

        }

        public bool DeleteProduct(string productDescription)
        {
            for (int i = 0; i < ShoppingList.Count; i++)
            {
                if (ShoppingList[i].ProductDescription.Equals(productDescription))
                {
                    ShoppingList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
