using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab13
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueLinkedList Queue = new QueueLinkedList();
            Queue.Print();
            Queue.EnQueue(3);
            Queue.EnQueue(1);
            Queue.EnQueue(2);
            Queue.EnQueue(3);
            Queue.EnQueue(4);
            Queue.Print();
            Queue.DeQueue();
            Queue.Print();


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
            Value = value;
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
    class QueueLinkedList
    {
        private Node Head;

        public void QueueInit()
        {
            Head = null;
        }
        public bool QueueIsEmpty()
        {
            if(Head == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void EnQueue(int value)
        {
            Node NewNode = new Node(value);
            if(Head == null)
            {
                Head = NewNode;
            }
            else
            {
                Node Current = Head;
                while(Current.GetNext() != null)
                {
                    Current = Current.GetNext();
                }
                Current.SetNext(NewNode);
            }
        }
        public void DeQueue()
        {
            Node Current = Head;
            Node Previous = Current;
            Current = Current.GetNext();
            Head = Current;
            Previous = null;
            
        }
        public int QueuePeek()
        {
            Node Current = Head;
            return Current.GetValue();
        }
        public void Print()
        {
            if(QueueIsEmpty() == false)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.Write("[");
                Node Current = Head;
                Console.Write(Current.GetValue() + ", ");
                while (Current.GetNext() != null)
                {
                    Current = Current.GetNext();

                    if (Current.GetNext() == null)
                    {
                        Console.Write(Current.GetValue());
                    }
                    else
                    {
                        Console.Write(Current.GetValue() + ", ");
                    }
                }
                Console.WriteLine("]");
            }            
        }
    }
}
