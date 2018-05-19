using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    class Test
    {
        public List<MarketCustomer> Customers { get; set; }
        public List<MarketStaff> Staffs { get; set; }
        public VirtualMarket Market;

        public Test()
        {            
        }

        public void DoTest()
        {
            Customers.Add(customer);
            customer.Market = this.Market;
            Staffs.Add(staff);
            staff.Market = this.Market;
            Market.InsertProduct(product, "Dizüstü2", "Bilgisayar");
            Market.InsertProductHash(product, product.ProductDescription);
            Market.InsertProduct(product2, "Akıllı Telefon", "Telefon");
            Market.InsertProductHash(product2, product2.ProductDescription);
        }

        public MarketCustomer customer = new MarketCustomer
        {
            Name = "Emre",
            UserName = "emre",
            Password = "1234"
        };
        public MarketStaff staff = new MarketStaff
        {
            Name = "emre",
            UserName = "emre",
            Password = "1234"
        };

            Product product2 = new Product
            {
                ProductName = "Samsung Galaxy s8",
                Brand = "Samsung",
                Model = "Galaxy",
                Amount = 40,
                Cost = 3600,
                SalePrice = 3800,
                ProductDescription = "Telefon",
                ProductType = "Test"
            };
        Product product = new Product
        {
            ProductName = "Bilgisayar",
            Brand = "Lenovo",
            Model = "ideapad",
            Amount = 4,
            Cost = 1420,
            SalePrice = 120,
            ProductDescription = "Dizüstü",
            ProductType = "Test"
        };

        
    }
}
