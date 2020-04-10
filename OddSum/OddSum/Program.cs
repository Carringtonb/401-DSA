using System;


namespace OddSum
{
    class Program
    {
        public class BinarySearchTree
        {
            static void Main()
            {
                BuildTree();
              

            }

            public class Node
            {
                public int Value;
                public Node Left;
                public Node Right;
                
            }
            public Node root;
            public BinarySearchTree()
            {
                root = null;
            }
            public void Insert(int i)
            {
                Node newNode = new Node();
                newNode.Value = i;
                if (root == null)
                    root = newNode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (i < current.Value)
                        {
                            current = current.Left;
                            if (current == null)
                            {
                                parent.Left = newNode;
                                break;
                            }

                            else
                            {
                                current = current.Right;
                                if (current == null)
                                {
                                    parent.Right = newNode;
                                    break;
                                }
                            }
                        }
                    }
                }
            }


            public static BinarySearchTree BuildTree()
            {
                BinarySearchTree nums = new BinarySearchTree();
                nums.Insert(50);
                nums.Insert(17);
                nums.Insert(23);
                nums.Insert(12);
                nums.Insert(19);
                nums.Insert(9);
                nums.Insert(14);
                nums.Insert(67);

                Console.WriteLine($"{nums.root.Value}");
                return nums;
            }
        }


    
    }
}