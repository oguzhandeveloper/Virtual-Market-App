using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class MinHeap : Heap
    {
        #region constructors
        public MinHeap(int capacity) : base(capacity)
        {
        }
        #endregion

        #region internal methods
        public override void HeapifyDown(int index)
        {
            
            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index).SalePrice < LeftChild(index).SalePrice)
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if (Nodes[smallerChildIndex].SalePrice < Nodes[index].SalePrice)
                    Swap(index, smallerChildIndex);
                else
                    break;
                index = smallerChildIndex;
            }
        }
        public override void HeapifyUp()
        {
            int index = Size - 1;

            while (HasParent(index) && Parent(index).SalePrice > Nodes[index].SalePrice)
            {
                Swap(index, GetParentIndex(index));
                index = GetParentIndex(index);
            }
        }
        #endregion
    }
}
