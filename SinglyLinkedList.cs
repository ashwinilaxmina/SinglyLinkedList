using System;

namespace SinglyLinkedList
{
    public class SinglyLinkedList
    {
        SinglyLinkedNode Head { get; set; }
        SinglyLinkedNode Tail { get; set; }
        int Count { get; set; }

        public void AddFirst(int value)
        {
            AddFirst(new SinglyLinkedNode(value));
        }

        public void AddFirst(SinglyLinkedNode node)
        {
            SinglyLinkedNode temp = Head;

            Head = node;

            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(int value)
        {
            AddLast(new SinglyLinkedNode(value));
        }

        public void AddLast(SinglyLinkedNode node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    SinglyLinkedNode current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }
        }

        public bool Remove(int item)
        {
            SinglyLinkedNode previous = null;
            SinglyLinkedNode current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
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
