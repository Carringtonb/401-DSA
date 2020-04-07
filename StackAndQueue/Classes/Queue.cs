using System;
namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public int Length { get; set; }

        public Queue()
        {
            Front = null;
            Rear = null;
        }

        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if(Rear != null)
            {
                Rear.Next = newNode;
                Rear = newNode;
                Length++;
            }else
            {
                Front = newNode;
                Rear = newNode;
                Length++;
            }
                    
        }

        public int Dequeue()
        {
            Node front = Front;
        }
    }
}
