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


            Market.InsertProduct(product, "Dizüstü", "Bilgisayar");
            Market.InsertProductHash(product, product.ProductDescription);
            Market.InsertProduct(product2, "Akıllı Telefon", "Telefon");
            Market.InsertProductHash(product2, product2.ProductDescription);

            Market.InsertProduct(product3, "Buzdolabı", "Beyaz Eşya");
            Market.InsertProductHash(product3, product3.ProductDescription);
            Market.InsertProduct(product4, "white shirt", "Giyim");
            Market.InsertProductHash(product4, product4.ProductDescription);

            Market.InsertProduct(product5, "Hamburger", "Yemek");
            Market.InsertProductHash(product5, product5.ProductDescription);
            Market.InsertProduct(product6, "Elma Ağacı", "Bahçe");
            Market.InsertProductHash(product6, product6.ProductDescription);

            Market.InsertProduct(product7, "Iphone", "Telefon");
            Market.InsertProductHash(product7, product7.ProductDescription);
            Market.InsertProduct(product8, "Masaüstü", "Bilgisayar");
            Market.InsertProductHash(product8, product8.ProductDescription);
        }

         MarketCustomer customer = new MarketCustomer
        {
            Name = "Emre",
            UserName = "emre",
            Password = "1234"
        };
         MarketStaff staff = new MarketStaff
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

        Product product3 = new Product
        {
            ProductName = "Bosh Buzdolabı",
            Brand = "Bosh",
            Model = "Freeze",
            Amount = 10,
            Cost = 3200,
            SalePrice = 3950,
            ProductDescription = "buzdolabı",
            ProductType = "buzdolabı"
        };
        Product product4 = new Product
        {
            ProductName = "Elbise",
            Brand = "Koton",
            Model = "White Shirt",
            Amount = 4,
            Cost = 750,
            SalePrice = 1200,
            ProductDescription = "white shirt",
            ProductType = "Giyim"
        };
        Product product5 = new Product
        {
            ProductName = "Yemek",
            Brand = "Burger King",
            Model = "Hamburger",
            Amount = 12,
            Cost = 18,
            SalePrice = 25,
            ProductDescription = "Hamburger",
            ProductType = "Yemek"
        };
        Product product6 = new Product
        {
            ProductName = "Elma Ağacı",
            Brand = "BauHouse",
            Model = "Ağaç",
            Amount = 2,
            Cost = 600,
            SalePrice = 1205,
            ProductDescription = "Elma Ağacı",
            ProductType = "Bahçe"
        };
        Product product7 = new Product
        {
            ProductName = "Iphone 8",
            Brand = "Iphone",
            Model = "8 IOS8",
            Amount = 40,
            Cost = 4500,
            SalePrice = 5500,
            ProductDescription = "Iphone",
            ProductType = "Test"
        };
        Product product8 = new Product
        {
            ProductName = "Bilgisayar",
            Brand = "HP",
            Model = "I348KNF",
            Amount = 4,
            Cost = 2800,
            SalePrice = 3600,
            ProductDescription = "Masaüstü",
            ProductType = "Masaüstü"
        };





    }
}
