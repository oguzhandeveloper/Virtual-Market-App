using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public abstract class Heap
    {
        #region internal properties
        private int Capacity { get; set; }
        internal int Size { get; set; }
        internal int[] Nodes { get; set; }
        #endregion

        #region constructors
        public Heap()
        {
            Capacity = 100;
            Size = 0;
            Nodes = new int[Capacity];
        }
        #endregion

        #region helperMethods
        public void EnlargeIfNeeded()
        {
            if (Size == Capacity)
            {
                Capacity = 2 * Capacity;
                Array.Copy(Nodes, Nodes, Capacity);
            }
        }

        public int getLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        public bool hasLeftChild(int parentIndex)
        {
            return getLeftChildIndex(parentIndex) < Size;
        }

        public int leftChild(int index)
        {
            return Nodes[getLeftChildIndex(index)];
        }

        public int getRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        public bool hasRightChild(int parentIndex)
        {
            return getRightChildIndex(parentIndex) < Size;
        }

        public int rightChild(int index)
        {
            return Nodes[getRightChildIndex(index)];
        }

        public int getParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        public bool hasParent(int childIndex)
        {
            return getParentIndex(childIndex) >= 0;
        }

        public int parent(int index)
        {
            return Nodes[getParentIndex(index)];
        }

        public void swap(int index1, int index2)
        {
            int temp = Nodes[index1];
            Nodes[index1] = Nodes[index2];
            Nodes[index2] = temp;
        }

        #endregion

        #region available public methods

        /// <summary>
        /// Gets the minimum element at the root of the tree
        /// </summary>
        /// <returns>Int value of minimum element</returns>
        /// <exception cref="">InvalidOperationException when heap is empty</exception>
        public int peek()
        {
            if (Size == 0)
                throw new InvalidOperationException("Heap is empty");

            return Nodes[0];
        }

        /// <summary>
        /// Removes the minimum element at the root of the tree
        /// </summary>
        /// <returns>Int value of minimum element</returns>
        /// <exception cref="">InvalidOperationException when heap is empty</exception>
        public int pop()
        {
            if (Size == 0)
                throw new InvalidOperationException("Heap is empty");

            int item = Nodes[0];
            Nodes[0] = Nodes[Size - 1];
            Size--;
            heapifyDown();
            return item;
        }

        /// <summary>
        /// Add a new item to heap, enlarging the array if needed
        /// </summary>
        /// <returns>void</returns>
        public void add(int item)
        {
            EnlargeIfNeeded();
            Nodes[Size] = item;
            Size++;
            heapifyUp();
        }
        #endregion

        #region abstract methods
        public abstract void heapifyUp();
        public abstract void heapifyDown();
        #endregion
    }
}
