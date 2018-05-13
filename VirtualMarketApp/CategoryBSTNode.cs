using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class CategoryBSTNode
    {
        public CategoryProduct Data { get; set; }
        public CategoryBSTNode NodeRight { get; set; }
        public CategoryBSTNode NodeLeft { get; set; }

        public CategoryBSTNode()
        {
            
            Data = null;
            NodeLeft = null;
            NodeRight = null;
        }

        public CategoryBSTNode(CategoryProduct Data)
        {
            this.Data = Data;
            NodeLeft = null;
            NodeRight = null;
        }
    }
}
