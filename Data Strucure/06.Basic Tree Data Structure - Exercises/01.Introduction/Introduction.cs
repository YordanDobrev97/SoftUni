using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Introduction
{
    public class Introduction
    {
        static Dictionary<int, Tree<int>> parentsNodes = new Dictionary<int, Tree<int>>();
        static List<int> leafs = new List<int>();

        static void Main()
        {
            CreateTree();
            
            PrintDeepestNode();
            
            PrintRoot();
            
            PrintLeaf();
            
            PrintMiddleNodes();
            
            PrintLongestPath();
        }

        public static void PrintLongestPath()
        {
            var collection = new List<int>();
            var root = parentsNodes.Values.First().Node;
            collection.Add(root);
            DFS(parentsNodes.Values.FirstOrDefault(), collection);

            Console.WriteLine($"Longest path: {string.Join(" ", collection)}");
        }

        private static void DFS(Tree<int> tree, 
            List<int> collection)
        {
            foreach (var item in tree.Children)
            {
                if (item.Children.Count == 0)
                {
                    collection.Add(item.Node);
                    return;
                }
                collection.Add(item.Node);
                DFS(item, collection);
                return;
            }
        }

        public static void PrintDeepestNode()
        {
            var deepNode = parentsNodes.
                Values.Select(x => x.Children.FirstOrDefault())
                .Where(x => x.Children.Count == 0).FirstOrDefault();

            Console.WriteLine($"Deepest node: {deepNode.Node}");
        }

        public static void PrintLeaf(Tree<int> tree = null)
        {
            var nodes = parentsNodes
                .SelectMany(x => x.Value.Children)
                .Where(x => x.Children.Count == 0).ToArray();

            SortedSet<int> sortedLeafs = new SortedSet<int>();

            foreach (var item in nodes)
            {
                sortedLeafs.Add(item.Node);
            }
            Console.WriteLine($"Leaf nodes: {string.Join(" ", sortedLeafs)}");
        }

        public static void PrintMiddleNodes()
        {
            var middleNodes = parentsNodes.Values
                .Where(x => x.Parent != null 
                        && x.Children.Count > 0)
                        .Select(x => x.Node)
                        .ToList();

            Console.WriteLine($"Middle nodes: {string.Join(" ", middleNodes)} ");
        }

        public static void CreateTree()
        {
            var numberOfNodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                var nodes = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var parent = nodes[0];
                var child = nodes[1];

                var treeNode = GetNode(parent);
                var childNode = GetNode(child);

                treeNode.AddChild(childNode);
                childNode.Parent = treeNode;
            }
            Console.WriteLine();
        }

        private static Tree<int> GetNode(int parent)
        {
            if (!parentsNodes.ContainsKey(parent))
            {
                parentsNodes.Add(parent, new Tree<int>(parent));
            }
            return parentsNodes[parent];
        }

        public static void PrintRoot()
        {
            var nodeParent = parentsNodes.Select(x => x.Key)
                .FirstOrDefault();

            Console.WriteLine($"Root node: {nodeParent}");
        }

        public static void PrintTree()
        {
            foreach (var item in parentsNodes)
            {
                item.Value.Print();
            }
        }
    }
}
