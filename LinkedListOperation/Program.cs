using System;

namespace LinkedListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Implementation!");

            LinkList list = new LinkList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
