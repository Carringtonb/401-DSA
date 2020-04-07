using System;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root;

        /// <summary>
        /// Organizes nodes into a tree and puts the larger values on the right branch and the lower values on the left.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns>The value of the root node</returns>
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
