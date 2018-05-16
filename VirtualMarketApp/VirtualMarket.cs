﻿using System;
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
        public int Size { get; set; }

        public VirtualMarket()
        {
            Size = 100; // Sınır - 
            Categories = new List<CategoryBST>();
            Hash = new HashMap(Size);

            

        }

        public void InsertProductHash(Product product, string productDescription)
        {
            Hash.Add(productDescription, product);
        }

        public void InsertProduct(Product product, string productType, string CategoryName)
        {
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

        public void InsertCategoryBTS(string categotyName)
        {
            bool isAdded = false;
            for (int i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].CategoryName.Equals(categotyName))
                    isAdded = true;
            }

            if(!isAdded)
            {
                CategoryBST category = new CategoryBST();
                category.CategoryName = categotyName;

                Categories.Add(category);
            }
        }

        public Product DeleteProductHash(string productDescription)
        {
            return Hash.Delete(productDescription);
        }
        

        public Product DeleteProductBTS(string productDesctription)
        {
            
            Product product = null;
            for (int i = 0; i < Categories.Count; i++)
            {
                product = Categories[i].Delete(productDesctription);
                if (product != null)
                    break;
            }
            return product;
        }

        public List<Product> SearchHash(string productDesription)
        {
            return Hash.Search(productDesription);
        }

        public Product OrderProduct(string productDescription)
        {
            List<Product> products = SearchHash(productDescription);

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductDescription.Equals(productDescription))
                    return products[i];
            }

            return null;
        }

        public List<ListProduct> CategoryListPreOrder(string categoryName)
        {
            int i = 0;
            for (i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].CategoryName.Equals(categoryName))
                {
                    Categories[i].PreOrder();
                    return Categories[i].CategoryPrint();
                }
            }

            return null;
        }

        public List<ListProduct> CategoryListInOrder(string categoryName)
        {
            int i = 0;
            for (i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].CategoryName.Equals(categoryName))
                {
                    Categories[i].InOrder();
                    return Categories[i].CategoryPrint();
                }
            }

            return null;
        }

        public List<ListProduct> CategoryListPostOrder(string categoryName)
        {
            int i = 0;
            for (i = 0; i < Categories.Count; i++)
            {
                if (Categories[i].CategoryName.Equals(categoryName))
                {
                    Categories[i].PostOrder();
                    return Categories[i].CategoryPrint();
                }
            }

            return null;
        }

        public bool ProductUpdate(string productDescription, string productName, string Brand, string Model, int Amount,
             decimal Cost, decimal SalePrice)
        {
            List<Product> products = Hash.Search(productDescription);
            Product product = null;

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductDescription.Equals(productDescription))
                    product = products[i];
            }

            if (product == null)
                return false;

            product.ProductName = productName;
            product.Brand = Brand;
            product.Model = Model;
            product.Amount = Amount;
            product.Cost = Cost;
            product.SalePrice = SalePrice;
            return true;

        }

        public bool ProductUpdate(string productDescription ,string Brand, string Model, int Amount,
            decimal Cost, decimal SalePrice)
        {
            List<Product> products = Hash.Search(productDescription);
            Product product = null;

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductDescription.Equals(productDescription))
                    product = products[i];
            }

            if (product == null)
                return false;
            product.Brand = Brand;
            product.Model = Model;
            product.Amount = Amount;
            product.Cost = Cost;
            product.SalePrice = SalePrice;

            return true;

        }

        public bool ProductUpdateCategory(string productDescription, string categoryName)
        {
            List<Product> products = Hash.Search(productDescription);
            Product product = null;

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductDescription.Equals(productDescription))
                    product = products[i];
            }

            if (product == null)
                return false;

            product.ProductType = categoryName;
            DeleteProductBTS(productDescription);
            InsertProduct(product, product.ProductType, categoryName);

            return true;

        }


    }
}
