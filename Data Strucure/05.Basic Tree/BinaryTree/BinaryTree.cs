using System;
using System.Collections.Generic;

public class BinaryTree<T>
{
    public T Root { get; set; }
    public BinaryTree<T> LeftChild { get; set; }
    public BinaryTree<T> RigthChild { get; set; }


    public BinaryTree(T value, 
        BinaryTree<T> leftChild = null, 
        BinaryTree<T> rightChild = null)
    {
        this.Root = value;
        this.LeftChild = leftChild;
        this.RigthChild = rightChild;
    }

    public void InOrder(Action<T> action)
    {
        Each(action, this);
    }

    private void Each(Action<T> action, BinaryTree<T> tree)
    {
        if (tree == null)
        {
            return;
        }
        Each(action, tree.LeftChild);
        action(tree.Root);
        Each(action, tree.RigthChild);
    }
    
    public void PreOrder(int intervals = 0)
    {
        Console.WriteLine($"{new string(' ', intervals)}{this.Root}");

        if (this.LeftChild != null)
        {
            this.LeftChild.PreOrder(intervals + 2);
        }

        if (this.RigthChild != null)
        {
            this.RigthChild.PreOrder(intervals + 2);
        }
    }

    public void PostOrder(Action<T> action)
    {
        PostOrderTraversal(action, this);
    }
    private void PostOrderTraversal(Action<T> action, BinaryTree<T> tree)
    {
        if (tree == null)
        {
            return;
        }
        Each(action, tree.LeftChild);
        Each(action, tree.RigthChild);
        action(tree.Root);
    }
}

