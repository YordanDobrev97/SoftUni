using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class StartUp
    {
        static void Main()
        {
            var binaryTree = new BinaryTree<int>(5,
                new BinaryTree<int>(4),
                new BinaryTree<int>(9));

            Console.WriteLine("Pre-order traversal: ");
            binaryTree.PreOrder();

            Console.WriteLine();

            Console.WriteLine("In-order traversal: ");
            binaryTree.InOrder(x => Console.WriteLine(x));

            Console.WriteLine();

            Console.WriteLine("Post-order traversal: ");
            binaryTree.PostOrder(x => Console.WriteLine(x));
        }
    }
}
