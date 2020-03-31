using System;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        private Node Top { get; set; }

        public int Length { get; set; } = 0;

        public Stack()
        {
            Top = null;
        }
        /// <summary>
        /// Take in the current values of the nodes in the stack, overrides them to a string value and returns the string.
        /// </summary>
        /// <returns>Value of Nodes in stack</returns>
        public override string ToString()
        {
            Node current = Top;
            StringBuilder sb = new StringBuilder();

            sb.Append("Top of Stack ->");

            while (current != null)
            {
                sb.Append($"{current.Value} ->");
                current = current.Next;
            }

            sb.Append("Null");
            return sb.ToString();
        }

        public int Pop()
        {
            Node prevTop = Top;
            Top = Top.Next;
            prevTop.Next = null;
            Length--;
            return prevTop.Value;
        }

        public void Push(int val)
        {
            Node oldTop = Top;
            Node newTop = new Node(val);
            Top = newTop;
            newTop.Next = oldTop;
            Length++;

        }

        public int Peek()
        {
            try
            {
                return Top.Value;
            }
            catch
            {
                throw new Exception();
            }
        }

        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
