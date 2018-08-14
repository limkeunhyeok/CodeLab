using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab12
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Node
    {
        private Node Next;
        private int Value;

        public Node(int value)
        {
            Value = value;
            this.Next = null;
        }

        public int GetValue()
        {
            return Value;
        }

        public void SetValue(int value)
        {
            this.Value = value;
        }

        public Node GetNext()
        {
            return this.Next;
        }

        public void SetNext(Node next)
        {
            this.Next = next;
        }
    }

    class DoublyLinkedList
    {
        private Node Head;

        public void ListInit()
        {
            Head = null;
        }

        public void ListInsert(int value)
        {
            Node NewNode = new Node(value);
            if(Head == null)
            {
                Head = NewNode;
            }
            else
            {
                Node Current = Head;
                Node Previous = Current;
                while(Current.GetNext() != null)
                {
                    Current = Current.GetNext();
                    Previous = Current.GetPrev();
                }
            }
        }
    }
}
