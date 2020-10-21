using System;

namespace LinkedListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Implementation!");

            LinkList list = new LinkList();
            list.AppendNode(70);            
            list.AppendNode(56);
            list.Display();
            list.InsertAtPosition(2,30);
            list.Display();
            list.RemoveFirstElement();
            list.Display();
        }
    }
}
