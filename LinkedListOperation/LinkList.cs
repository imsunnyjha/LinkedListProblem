using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListOperation
{
    class LinkList
    {
        internal Node head;

        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
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
        }
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList Empty!");
                return;
            }
            Console.WriteLine("\nLinkedList: ");
            while (temp != null)
            {
                
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node InsertAtPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Inavalid!");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Out of Range!");
                }
            }
            Console.WriteLine("Inserted value is: " +data);
            return head;
        }
        internal Node RemoveFirstElement()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node RemoveLastElement()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
    }
}
