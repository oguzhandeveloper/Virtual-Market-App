﻿using System;
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
        public override void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int largerChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && rightChild(index) > leftChild(index))
                {
                    largerChildIndex = getRightChildIndex(index);
                }

                if (Nodes[largerChildIndex] > Nodes[index])
                    swap(index, largerChildIndex);
                else
                    break;
                index = largerChildIndex;
            }
        }
        public override void heapifyUp()
        {
            int index = Size - 1;

            while (hasParent(index) && parent(index) < Nodes[index])
            {
                swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }
        #endregion
    }
}
