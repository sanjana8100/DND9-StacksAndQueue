using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND9_StacksAndQueue
{
    internal class Queue<T>
    {
        Node<T> head;
        Node<T> tail;

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public T Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is empty!!!");
                return default(T);
            }
            T popData = tail.data;
            if (head == tail)
            {
                head = null;
                return popData;
            }
            Node<T> temp = head;
            while (temp.next != tail)
                temp = temp.next;
            temp.next = null;
            tail = temp;
            return popData;
        }

        public T Peek()
        {
            return head.data;
        }

        public T Front()
        {
            return head.data;
        }

        public T Rear()
        {
            return tail.data;
        }

        public bool IsNull()
        {
            return head == null;
        }

        public int Size()
        {
            int size = 0;
            Node<T> temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }

        public void Display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
