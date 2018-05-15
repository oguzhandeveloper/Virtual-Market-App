using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public abstract class Heap
    {
        public int Capacity { get; set; }
        public int Size { get; set; }

        public Product[] Nodes { get; set; }

       

        #region constructors
        public Heap(int capacity)
        {
            this.Capacity = capacity;
            Size = 0;
            Nodes=new Product[Capacity];
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

        public int GetLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        public bool HasLeftChild(int parentIndex)
        {
            return GetLeftChildIndex(parentIndex) < Size;
        }

        public Product LeftChild(int index)
        {
            return Nodes[GetLeftChildIndex(index)];
        }

        public int GetRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        public bool HasRightChild(int parentIndex)
        {
            return GetRightChildIndex(parentIndex) < Size;
        }

        public Product RightChild(int index)
        {
            return Nodes[GetRightChildIndex(index)];
        }

        public int GetParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        public bool HasParent(int childIndex)
        {
            return GetParentIndex(childIndex) >= 0;
        }

        public Product Parent(int index)
        {
            return Nodes[GetParentIndex(index)];
        }

        public void Swap(int index1, int index2)
        {
            Product temp =Nodes[index1];
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
        public Product Peek()
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
        public Product Pop()
        {
            if (Size == 0)
                throw new InvalidOperationException("Heap is empty");

            Product item = Nodes[0];
            Nodes[0] =Nodes[Size - 1];
            Size--;
            HeapifyDown(0);
            return item;
        }

        public Product Pop(string productDescription)
        {


            if (Size == 0)
                throw new InvalidOperationException("Heap is empty");
            int index = -1;
            for (int i = 0; i < Size; i++)
            {
                if (Nodes[i].ProductDescription.Equals(productDescription))
                    index = i;
            }

            if (index == -1)
                return null;

            Product item = Nodes[0];
            Nodes[0] = Nodes[Size - 1];
            Size--;
            HeapifyDown(index);
            return item;
        }

        /// <summary>
        /// Add a new item to heap, enlarging the array if needed
        /// </summary>
        /// <returns>void</returns>
        public void Add(Product item)
        {
            EnlargeIfNeeded();
            Nodes[Size] = item;
            Size++;
            HeapifyUp();
        }
        #endregion

        #region abstract methods
        public abstract void HeapifyUp();
        public abstract void HeapifyDown(int index);

        #endregion
    }
}
