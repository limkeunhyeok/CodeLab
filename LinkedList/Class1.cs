
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     public class Node
     {
        private Node Next; // 다음 노드의 주소값을 가리킴
        private int Value; // 해당 노드의 데이터

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

        public void SetNext(Node Next)
        {
            this.Next = Next;
        }
    }

    public class List
    {
        private Node Top;

        public void ListInit()
        {
            Top = null;
        }
        public void Push(int value)
        {
            Node NewNode = new Node(value);
            if (Top == null)
            {
                Top = NewNode;
            }
            else
            {
                Node Current = Top;
                while (Current.GetNext() != null)
                {
                    Current = Current.GetNext();
                }
                Current.SetNext(NewNode);
            }
        }
        public void Pop()
        {
            Node Current = Top;
            Node Previous = Current;
            while (Current.GetNext() != null)
            {
                Previous = Current;
                Current = Current.GetNext();
            }
            if(Previous == Current)
            {
                ListInit();
            }
            Previous.SetNext(null);
            // Current = Previous;            
        }
        public bool IsEmpty() // 비어있으면 false 있으면 true
        {
            if(Top == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int Peek()
        {
            Node Current = Top;
            while(Current.GetNext() != null)
            {
                Current = Current.GetNext();
            }
            return Current.GetValue();
        }
        public void Print()
        {
            Console.Write("[");
            if (Top != null)
            {
                Node Current = Top;
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
            }
            Console.WriteLine("]");
        }

    }
}
