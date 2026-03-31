using System;

namespace DynamicQueue
{
    public class DyQueue<T>
    {
        Node<T>? rear;
        Node<T>? front;
        int queueSize = 0;

        public int Length { get => queueSize; }

        public void Enqueue(T data)
        {
            Node<T> temp = new Node<T>(data);
            if (queueSize == 0)
            {
                rear = temp;
                front = temp;
            }
            else
            {
                rear.next = temp;
                rear = temp;
            }

            queueSize++;
        }

        public T Dequeue()
        {
            if (queueSize == 0) throw new System.Exception("Queue is empty");

            T toReturn = front.data;

            if (queueSize == 1)
            {
                rear = front = null;
            }
            else
            {
                front = front.next;
            }

            queueSize--;

            return toReturn;
        }
    }

    public class Node<T>
    {
        public T data { get; }
        public Node<T>? next; // the next node after the current one to be dequeued

        public Node(T data)
        {
            this.data = data;
        }
    }
}