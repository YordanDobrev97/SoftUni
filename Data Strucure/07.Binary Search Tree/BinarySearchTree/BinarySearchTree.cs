using System;

public class BinarySearchTree<T> where T : IComparable
{
    private class Node
    {
        public Node(T value)
        {
            this.Value = value;
        }
        public T Value { get; set; }
        public Node Left{ get; set; }
        public Node Right { get; set; }
    }
    private Node root;

    public BinarySearchTree()
    {

    }

    private BinarySearchTree(Node node)
    {
        Copy(node);
    }

    private void Copy(Node node)
    {
        if (node == null)
        {
            return;
        }
        Insert(node.Value);
        Copy(node.Left);
        Copy(node.Right);
    }

    public void Insert(T item)
    {
        if (this.root == null)
        {
            this.root = new Node(item);
        }
        else
        {
            var current = this.root;
            Node parent = null;
            while (current != null)
            {
                parent = current;
                if (current.Value.CompareTo(item) > 0)
                {
                    current = current.Left;
                }
                else if (current.Value.CompareTo(item) < 0)
                {
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }
            current = new Node(item);
            if (parent.Value.CompareTo(item) > 0)
            {
                parent.Left = current;
            }
            else
            {
                parent.Right = current;
            }
        }
    }

    public BinarySearchTree<T> Search(T item)
    {
        var current = this.root;

        while (current != null)
        {
            if (current.Value.CompareTo(item) > 0)
            {
                current = current.Left;
            }
            else if (current.Value.CompareTo(item) < 0)
            {
                current = current.Right;
            }
            else
            {
                break;
            }
        }
        return new BinarySearchTree<T>(current);
    }

    public bool Contains(T item)
    {
        var current = this.root;

        while (current != null)
        {
            if (current.Value.CompareTo(item) > 0)
            {
                current = current.Left;
            }
            else if(current.Value.CompareTo(item) < 0)
            {
                current = current.Right;
            }
            else
            {
                break;
            }
        }

        return current != null;
    }

    public void InOrder(Action<T> action)
    {
        EachOrder(this.root, action);
    }

    private void EachOrder(Node root, Action<T> action)
    {
        if (root == null)
        {
            return;
        }
        EachOrder(this.root.Left, action);
        action(root.Value);
        EachOrder(this.root.Right, action);
    }
}