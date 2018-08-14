using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab11
{
    class Program
    {
        static void Main(string[] args)
        {
            CycleLinkedList cll = new CycleLinkedList();
            cll.ListInsert(5);
            cll.ListInsert(4);
            cll.ListInsert(3);
            cll.ListInsert(2);
            cll.ListInsert(1);
            cll.ListInsert(2);
            cll.ListInsert(3);
            cll.ListRemove();

            cll.Print();

        }
    }
    class Node
    {
        private Node Next;
        private int Value;

        public Node(int Value)
        {
            this.Value = Value;
            this.Next = null;
        }
        public int GetValue()
        {
            return Value;
        }
        public void SetValue(int Value)
        {
            this.Value = Value;
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
    class CycleLinkedList
    {
        private Node Head; // 다음 주소를 가리키고
        private Node Tail; // 첫 생성된 노드의 주소를 가리킴

        public void ListInit()
        {
            Head = Tail;
            Tail = null;
        }

        public void ListInsert(int value)
        {
            Node NewNode = new Node(value); // 새노드 생성

            if (Tail == null) // 처음 생성한 노드가 tail이 됨
            {
                Tail = NewNode;
                Head = Tail;
            }
            if (Tail == Head) //  2번째 생성되는 노드에서 1번째 노드의 헤드는 2번째를 가리키고 2번째는 tail을 가리킴
            {
                Node Current = Head;
                Current.SetNext(NewNode);
                Head = NewNode;
                NewNode.SetNext(Tail);
            }
            else // 이전 노드는 NewNode를 가리키고 NewNode는 tail을 가리켜야함
            {
                Node Current = Tail;
                Current = Current.GetNext();
                while(Current.GetNext() != Tail)
                {
                    Current = Current.GetNext();
                }
                Current.SetNext(NewNode);
                NewNode.SetNext(Tail);
            }
        }

        public void ListRemove() // 최근 만들어진 노드를 제거
        {
            Node Current = Head;
            Node Previous = Current; // 최근에 만들어진 노드의 전 노드가 가리키는 것을 tail로 바꿔줌
            while(Current.GetNext() != Tail)
            {
                Previous = Current;
                Current = Current.GetNext();
            }
            Previous.SetNext(Tail);
        }
        public void Print()
        {
            Console.Write("[");
            if ( Head != Tail)
            {
                Node Current = Tail;
                Console.Write(Current.GetValue() + ", ");
                while (Current.GetNext() != Tail)
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
