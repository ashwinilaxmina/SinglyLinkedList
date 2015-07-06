using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SinglyLinkedList
    {
        SinglyLinkedNode Head { get; set; }
        SinglyLinkedNode Tail { get; set; }
        int Count { get; set; }

        public void AddFirst(int item)
        {
            if (Head == null && Tail == null)
            {
                SinglyLinkedNode temp = new SinglyLinkedNode(item);
                Head = temp;
                Head.Next = null;
                Tail = temp;
                Tail.Next = null;
                Count++;
            }
            else
            {
                SinglyLinkedNode temp2 = new SinglyLinkedNode(item);
                temp2 = Head;
                Head = temp2;
                Head.Next = temp2;
                Count++;
                
            }
        }

        public void PrintList()
        {
            SinglyLinkedNode temp = Head;
            while(temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
}
