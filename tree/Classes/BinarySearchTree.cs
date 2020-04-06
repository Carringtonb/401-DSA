using System;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root;

        public Node insertNode(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.Value = value;
            }else if (value < root.Value)
            {
                root.Left = insertNode(root.Left, value);
            }
            else
            {
                root.Right = insertNode(root.Right, value);
            }
            this.Root = root;
            return this.Root;
        }

        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            traverse(root.Left);
            traverse(root.Right);
        }
     
    }
}
