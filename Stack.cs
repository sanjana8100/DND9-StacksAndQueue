using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND9_StacksAndQueue
{
    internal class Stack<T>
    {
        Node<T> head;

        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public T Pop()
        {
            if (head == null)
            {
                Console.WriteLine("The Linked List is empty!!!");
                return default(T);
            }
            T popData = head.data;
            head = head.next;
            return popData;
        }

        public T Top()
        {
            return head.data;
        }

        public bool IsEmpty()
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
