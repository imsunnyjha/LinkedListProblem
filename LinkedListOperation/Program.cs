using System;

namespace LinkedListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Implementation!");

            LinkList list = new LinkList();
            list.AddNode(70);
            list.AddNode(30);
            list.AddNode(56);
            list.Display();
        }
    }
}
