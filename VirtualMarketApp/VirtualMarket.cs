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
    }
}
