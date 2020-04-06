using System;
using System.Collections.Generic;

namespace Tree.Classes
{
    public class Tree
    {
        public Node root { get; set; }

        public Tree()
        {
            root = null;
        }

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
