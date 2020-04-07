using System;
using System.Collections.Generic;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node root { get; set; }

        public BinaryTree()
        {
            root = null;
        }
        /// <summary>
        /// Organizes the nodes in a tree and returns the nodes in PreOrder
        /// Pair Programming with Teddy
        /// </summary>
        /// <returns>Array of node values in order with root FILO</returns>
        public List<int> PreOrder()
        {
            Node Root = root;
            List<int> storage = new List<int>();

            void listHelper(Node helper, List<int> storage)
            {
                if (helper == null)
                {
                    return;
                }

                storage.Add(helper.Value);
                listHelper(helper.Left, storage);
                listHelper(helper.Right, storage);
            }

            listHelper(root, storage);
            return storage;
        }
        /// <summary>
        /// Organizes the nodes in a tree and returns them with the root called in the middle
        /// </summary>
        /// <returns>Array of nodes organized in order</returns>
        public List<int> InOrder()
        {
            Node Root = root;
            List<int> storage = new List<int>();

            void listHelper(Node helper, List<int> storage)
            {
                if (helper == null)
                {
                    return;
                }

                listHelper(helper.Left, storage);
                storage.Add(helper.Value);
                listHelper(helper.Right, storage);
            }

            listHelper(root, storage);
            return storage;
        }
        /// <summary>
        /// Organizes the nodes in a tree and returns them with the root checked at the end
        /// </summary>
        /// <returns>Array of nodes organized in PostOrder</returns>
        public List<int> PostOrder()
        {
            Node Root = root;
            List<int> storage = new List<int>();

            void listHelper(Node helper, List<int> storage)
            {
                if (helper == null)
                {
                    return;
                }

                listHelper(helper.Left, storage);
                listHelper(helper.Right, storage);
                storage.Add(helper.Value);
            }

            listHelper(root, storage);
            return storage;
        }
    }
}
