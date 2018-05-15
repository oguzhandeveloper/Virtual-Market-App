using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class MaxHeap : Heap
    {
        #region constructors
        public MaxHeap() : base()
        {
        }
        
        #endregion

        #region internal methods
        public override void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int largerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index).SalePrice > LeftChild(index).SalePrice)
                {
                    largerChildIndex = GetRightChildIndex(index);
                }

                if (Nodes[largerChildIndex].SalePrice > Nodes[index].SalePrice)
                    Swap(index, largerChildIndex);
                else
                    break;
                index = largerChildIndex;
            }
        }
        public override void HeapifyUp()
        {
            int index = Size - 1;

            while (HasParent(index) && Parent(index).SalePrice < Nodes[index].SalePrice)
            {
                Swap(index, GetParentIndex(index));
                index = GetParentIndex(index);
            }
        }
        #endregion
    }
}
