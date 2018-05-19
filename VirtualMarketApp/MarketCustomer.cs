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
            for (int i = 0; i < length; i++)
            {
                Market.DeleteProductBTS(ShoppingList[i].ProductDescription);
                Market.DeleteProductHash(ShoppingList[i].ProductDescription);
            }
        }

        public bool BuyProduct(string productDescription)
        {

            Market.DeleteProductBTS(productDescription);
            Market.DeleteProductHash(productDescription);
            return DeleteProduct(productDescription);
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
