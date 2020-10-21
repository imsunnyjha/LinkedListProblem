using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListOperation
{
    class LinkList
    {
        internal Node head;

        internal void AddNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = node;
                temp.next = head;
                head = temp;
            }
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
