using System;
namespace HashTable.Classes
{
    public class Node
    {
        public string Value { get; set; }
        public string Key { get; set; }
        public Node Next { get; set; }

        public Node(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
