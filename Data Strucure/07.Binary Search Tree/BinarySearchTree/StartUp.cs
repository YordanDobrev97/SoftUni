using System;

namespace BinaryTree
{
    class StartUp
    {
        static void Main()
        {
            var bst = new BinarySearchTree<int>();
            bst.Insert(10);
            bst.Insert(37);
            bst.Insert(1);
            bst.Insert(5);
            bst.Insert(3);

            var smallBinarySearch = bst.Search(1);
        }
    }
}
