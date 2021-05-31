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
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(63);
            bst.Insert(67);
            bst.GetSize();

            bst.Search(70, bst);


            bst.Display(); 
            Console.WriteLine("                                           56                    ---> Root \n");
            Console.WriteLine("                                 30                    70                    ");
            Console.WriteLine("                          22           40         60             95            ");
            Console.WriteLine("                     11                                65                  ");
            Console.WriteLine("                3          16                   63           67           ");



            Console.ReadLine();
        }
    }
}
    

