
using System;
using System.Collections.Generic;

public class Tree<T>
{
    public T Node { get; set; }
    public List<Tree<T>> Children { get; set; }

    public Tree<T> Parent { get; set; }

    public Tree(T node, params Tree<T>[] child)
    {
        this.Node = node;
        this.Children = new List<Tree<T>>(child);
    }

    public void AddChild(Tree<T> child)
    {
        this.Children.Add(child);
    }

    public void Print(int intervals = 0)
    {
        Console.WriteLine($"{new string(' ', intervals)}{this.Node}");
        foreach (var item in this.Children)
        {
            item.Print(intervals + 2);
        }
    }
}
