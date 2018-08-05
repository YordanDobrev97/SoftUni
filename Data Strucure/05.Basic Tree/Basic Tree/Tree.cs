using System;
using System.Collections.Generic;

public class Tree<T>
{
    private T value;
    private List<Tree<T>> children;

    public Tree(T value, params Tree<T>[] child)
    {
        this.value = value;
        this.children = new List<Tree<T>>(child);
    }

    public T Value
    {
        get
        {
            return this.value;
        }
        private set
        {
            this.value = value;
        }
    }

    public List<Tree<T>> Children
    {
        get
        {
            return this.children;
        }
        private set
        {
            this.children = value;
        }
    }

    public void PrintTree(int intervals = 0)
    {
        System.Console.WriteLine($"{new string(' ', intervals)}{this.value}");

        foreach (var child in this.children)
        {
            child.PrintTree(intervals + 2);
        }
    }

    public IEnumerable<T> DFS()
    {
        var collection = new List<T>();

        DFS(this, collection);

        return collection;
    }

    private void DFS(Tree<T> tree, List<T> collection)
    {
        foreach (var child in tree.children)
        {
            DFS(child, collection);
        }
        collection.Add(tree.value);
    }

    public IEnumerable<T> OrderBFS()
    {
        Queue<T> result = new Queue<T>();
        var collection = new Queue<Tree<T>>();
        collection.Enqueue(this);

        while (collection.Count > 0)
        {
            var current = collection.Dequeue();
            result.Enqueue(current.value);

            foreach (var child in current.children)
            {
                collection.Enqueue(child);
            }
        }

        return result;
    }
}