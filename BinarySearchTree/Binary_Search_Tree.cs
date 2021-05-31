using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Binary_Search_Tree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public Binary_Search_Tree<T> LeftTree { get; set; }
        public Binary_Search_Tree<T> RightTree { get; set; }
        public Binary_Search_Tree(T nodeData) 
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;
        }
        int leftCount = 0; 
        int rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            try
            {
                T CurrentNodeValue = this.NodeData;
                if (CurrentNodeValue.CompareTo(item) > 0) 
                {
                    if (this.LeftTree == null)
                    {
                        this.LeftTree = new Binary_Search_Tree<T>(item);
                    }
                    else
                    {
                        this.LeftTree.Insert(item);
                    }
                }
                else
                {
                    if (this.RightTree == null) 
                    {
                        this.RightTree = new Binary_Search_Tree<T>(item);
                    }
                    else
                    {
                        this.RightTree.Insert(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void GetSize()
        {
            Console.WriteLine($"Size   {1 + this.leftCount + this.rightCount}");
        }
        public void Display() 
        {
            try
            {
                if (this.LeftTree != null)
                {
                    this.leftCount++;
                    this.LeftTree.Display(); 
                }
                Console.WriteLine(this.NodeData.ToString());
                if (this.RightTree != null)
                {
                    this.rightCount++;
                    this.RightTree.Display(); 
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
