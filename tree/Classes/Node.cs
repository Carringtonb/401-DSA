using System;
namespace Tree.Classes
{
    /// <summary>
    /// Instantiates a node with a left attribute, right attribute, and a value
    /// </summary>
    public class Node
    {
        //public Node Next { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
    }
}
