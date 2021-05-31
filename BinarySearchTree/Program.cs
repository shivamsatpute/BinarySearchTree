using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("BinarySearchTree");
            Binary_Search_Tree<int> bst = new Binary_Search_Tree<int>(56); 
            bst.Insert(30); 
            bst.Insert(70);
            bst.GetSize();
            bst.Display(); 
            Console.WriteLine("         56        ---> Root \n");
            Console.WriteLine("     30     70");
            Console.ReadLine();
        }
    }
    
}
