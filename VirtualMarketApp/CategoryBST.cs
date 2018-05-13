using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class CategoryBST
    {
        private CategoryBSTNode root;
        private string listMessage;

        public CategoryBST() { }
        public CategoryBST(CategoryBSTNode root)
        {
            this.root = root;
        }

        public bool Delete()
        {
            throw new Exception("Kullanılmadı");
        }

        #region Insert
        public bool Insert(Product product, string productType)
        {
            CategoryBSTNode temp = root;

            CategoryBSTNode prevTemp = root;

            bool isLeft = false;
            while (temp != null)
            {
                prevTemp = temp;
                if (CompareProducts.Compare(temp.Data, productType) == 0)
                    break;
                else if (CompareProducts.Compare(temp.Data, productType) == 1)
                {
                    temp = temp.NodeLeft;
                    isLeft = true;
                }
                else if (CompareProducts.Compare(temp.Data, productType) == -1)
                {
                    isLeft = false;
                    temp = temp.NodeRight;
                }
            }
            //Ürün tipi yok ise
            if (temp == null)
            {
                CategoryProduct category = new CategoryProduct(productType);
                category.Insert(product);
                if (isLeft)
                    prevTemp.NodeLeft = new CategoryBSTNode(category);
                else
                    prevTemp.NodeRight = new CategoryBSTNode(category);
                return true;
            }
            //Ürün tipi mevcut ise
            else
            {
                ///TODO : Aynı product' tan olması durumu
                temp.Data.Insert(product);
                return true;
            }

        }
        #endregion

        #region SearchProduct
        public Product SearchProduct(string key)
        {
            Product product = SearchProduct(root, key);
            if (product == null)
                return null;
            else
                return product;
        }

        public Product SearchProduct(CategoryBSTNode node, string key)
        {
            throw new Exception("Kullanılmadı...");
            //if (node == null)
            //    return null;
            //else if (CompareProducts.CompareProduct(node.Data, key) != null )
            //    return node;
            //else if (CompareProducts.Compare(node.Data, key) == 1)
            //    return SearchProduct(node.NodeLeft, key);
            //else
            //    return SearchProduct(node.NodeRight, key);
        }
        #endregion
        //TODO

        #region SearchCategoryProduct
        public CategoryProduct SearchCategoryProduct(string key)
        {
            CategoryBSTNode node = SearchCategotyProduct(root, key);
            if (node == null)
                return null;
            else
                return node.Data;
        }

        public CategoryBSTNode SearchCategotyProduct(CategoryBSTNode node, string key)
        {
            if (node == null)
                return null;
            else if (CompareProducts.Compare(node.Data, key) == 0)
                return node;
            else if (CompareProducts.Compare(node.Data, key) == 1)
                return SearchCategotyProduct(node.NodeLeft, key);
            else
                return SearchCategotyProduct(node.NodeRight, key);
        }
        #endregion

        #region MinValueProduct
        public CategoryProduct MinValueProduct()
        {
            CategoryBSTNode tempLeft = root;
            while (tempLeft.NodeLeft != null)
                tempLeft = tempLeft.NodeLeft;

            return tempLeft.Data;

        }
        #endregion

        #region MaxValueProduct
        public CategoryProduct MaxValueProduct()
        {
            CategoryBSTNode tempRight = root;
            while (tempRight.NodeRight != null)
                tempRight = tempRight.NodeRight;

            return tempRight.Data;

        }
        #endregion

        #region Visit
        private void Visit(CategoryBSTNode node)
        {
            listMessage += node.Data.ProductType;
            //TODO
        }
        #endregion

        #region CategoryPrint
        public string CategoryPrint()
        {
            return listMessage;
            //TODO
        }
        #endregion

        #region PreOrder
        public void PreOrder()
        {
            listMessage = "";
            PreOrderVisit(root);
        }

        public void PreOrderVisit(CategoryBSTNode node)
        {
            if (node == null)
                return;
            Visit(node);
            PreOrderVisit(node.NodeLeft);
            PreOrderVisit(node.NodeRight);
        }
        #endregion

        #region InOrder
        public void InOrder()
        {
            listMessage = "";//TODO
            InOrderVisit(root);
        }

        public void InOrderVisit(CategoryBSTNode node)
        {
            if (node == null)
                return;
            InOrderVisit(node.NodeLeft);
            Visit(node);
            InOrderVisit(node.NodeRight);
        }
        #endregion

        #region PostOrder
        public void PostOrder()
        {
            listMessage = "";//TODO
            PostOrderVisit(root);
        }

        public void PostOrderVisit(CategoryBSTNode node)
        {
            if (node == null)
                return;
            PostOrderVisit(node.NodeLeft);
            PostOrderVisit(node.NodeRight);
            Visit(node);
        }
        #endregion


        #region ProductsCount
        public int ProductsCount()
        {
            return ProductsCount(root);
        }
        public int ProductsCount(CategoryBSTNode node)
        {
            int count = 0;
            if (node != null)
            {
                count = 1;
                count += ProductsCount(node.NodeLeft);
                count += ProductsCount(node.NodeRight);
            }
            return count;
        }
        #endregion

        #region LeafCount
        public int LeafCount()
        {
            return LeafCount(root);
        }
        public int LeafCount(CategoryBSTNode node)
        {
            int count = 0;
            if (node != null)
            {
                if (node.NodeLeft == null && node.NodeRight == null)
                    count = 1;
                else
                    count = LeafCount(node.NodeLeft) + LeafCount(node.NodeRight);
            }
            return count;
        }

        #endregion
    }
}
