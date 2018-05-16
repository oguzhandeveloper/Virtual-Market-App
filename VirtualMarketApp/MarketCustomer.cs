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

        public void Add(Product product)
        {
            ShoppingList.Add(product);
        }

        public void BuyAll()
        {
            for (int i = 0; i < ShoppingList.Count; i++)
            {
                Market.DeleteProductBTS(ShoppingList[i].ProductDescription);
            }
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
