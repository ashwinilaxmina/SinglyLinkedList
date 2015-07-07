using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddFirst(1);
            list.AddFirst(10);
            Console.WriteLine("Items in the list are: ");
            list.PrintList();
            list.AddLast(12);
            list.PrintList();
            list.RemoveFirst();
            list.PrintList();
            list.AddLast(13);
            Console.WriteLine("----------------------------");
            list.PrintList();
            Console.WriteLine("----------------------------");
            list.RemoveLast();
            list.PrintList();
            Console.WriteLine("----------------------------");
            list.Remove(12);
            list.PrintList();
            Console.ReadLine();
            
        }
    }
}
