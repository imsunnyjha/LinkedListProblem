using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListOperation
{
    class LinkList
    {
        internal Node head;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + " inserted into linked list");
        }
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList Empty!");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
