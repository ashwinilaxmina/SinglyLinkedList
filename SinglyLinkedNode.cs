using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SinglyLinkedNode
    {
        public SinglyLinkedNode(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public SinglyLinkedNode Next { get; set; }
    }
}
