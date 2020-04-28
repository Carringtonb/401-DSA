using System;
namespace RepeatedWord.Classes
{
      public class HashTable
        {
            public static int nodeArray = 1024;
            public Node[] Arr { get; set; }


            public HashTable()
            {
                Arr = new Node[nodeArray];
            }

            public void Add(string key, string value)
            {
                int placement = Hash(key);
                Node newNode = new Node(key, value);

                if (Arr[placement] == null)
                {
                    Arr[placement] = newNode;
                }
                else
                {
                    Node current = Arr[placement];
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = new Node(key, value);
                }
            }

            public Node Get(string key)
            {
                int placement = Hash(key);
                Node current = Arr[placement];

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        return current;
                    }
                    current = current.Next;
                }
                return null;
            }

            public bool Contains(string key)
            {
                int placement = Hash(key);
                Node current = Arr[placement];

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }

            public int Hash(string key)
            {
                int hash = 0;
                foreach (int letter in key)
                {
                    hash += letter;
                }

                return hash * 691 % 1024;
            }
        }
}
