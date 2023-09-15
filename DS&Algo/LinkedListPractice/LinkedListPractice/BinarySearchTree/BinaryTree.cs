using System;

namespace LinkedListPractice.BinarySearchTree
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data;
        public Node<T> LeftNode;
        public Node<T> RightNode;
    }
    #region Logic to add data to binary tree
    public class BinaryTree<T> where T : IComparable<T>
    {
        Node<T> _root;

        public void Add(T data)
        {
            Node<T> node = new() { Data = data };
            if (_root == null)
                _root = node;

            else {
                Insert(_root, node);
            }
        }

        public Node<T> Get(T data)
        {
            if (_root == null) 
                return null;

            return Search(_root, data); 
        }

        private void DisplayAll(Node<T> root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.Data + ",");
            DisplayAll(root.LeftNode);
            DisplayAll(root.RightNode);
        }

        public void DisplayTree()
        {
            DisplayAll(_root);
        }

        private Node<T> Search(Node<T> root, T data)
        {
            if (root.Data.Equals(data))
                return root;

            else
            {
                if (!root.Data.IsGreaterThanOrEqualTo(data))
                    return Search(root.LeftNode, data);
                else 
                    return Search(root.RightNode, data);
            }
        }

        private void Insert(Node<T> root, Node<T> node)
        {
            if (!root.Data.IsGreaterThanOrEqualTo(node.Data))
            {
                if (root.LeftNode == null)
                    root.LeftNode = node;

                else
                    Insert(root.LeftNode, node);
            }
            else
            {
                if (root.RightNode == null)
                    root.RightNode = node;

                else
                    Insert(root.RightNode, node);
            }
        }
    }
    #endregion
    #region Logic for finding the depth of the node and adding data.
    //internal class BinaryTree<T>
    //{
    //    public Node<T> _root;

    //    public void Add(T data)
    //    {
    //        Node<T> newItem = new Node<T>();
    //        newItem.Data = data;

    //        if (_root == null)
    //        {
    //            _root = newItem;
    //            return;
    //        }

    //        Add(_root, newItem);
    //    }

    //    private void Add(Node<T> root, Node<T> newItem)
    //    {
    //        // Check if left node is null or right node is null, and add the new item accordingly
    //        if (root.LeftNode == null)
    //        {
    //            root.LeftNode = newItem;
    //        }
    //        else if (root.RightNode == null)
    //        {
    //            root.RightNode = newItem;
    //        }
    //        else
    //        {
    //            // Both left and right nodes are already occupied
    //            // Determine the depth of the current node
    //            int leftDepth = GetDepth(root.LeftNode);
    //            int rightDepth = GetDepth(root.RightNode);

    //            // Recursively add the new item to the side with the smaller depth
    //            //NOTE: This provides a rough depth of both left & right nodes with less accuracy
    //            //hence the binary tree data representation will not be symmetric
    //            if (leftDepth <= rightDepth)
    //            {
    //                Add(root.LeftNode, newItem);
    //            }
    //            else
    //            {
    //                Add(root.RightNode, newItem);
    //            }
    //        }
    //    }

    //    private int GetDepth(Node<T> node)
    //    {
    //        if (node == null)
    //            return 0;

    //        int leftDepth = GetDepth(node.LeftNode);
    //        int rightDepth = GetDepth(node.RightNode);

    //        return Math.Max(leftDepth, rightDepth) + 1;
    //    }
    //}
    #endregion
}