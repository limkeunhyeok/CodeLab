using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LinkedList List = new LinkedList();
            List.ListInsert(4);
            List.ListInsert(3);
            List.ListInsert(1);
            List.ListInsert(2);
            List.ListInsert(8);
            List.ListInsert(1);
            List.ListInsert(9);
            List.Print();

            List.ListRemove(0);
            List.Sorting();
            List.Print();
        }
    }

    internal class Node
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

    internal class LinkedList
    {
        private Node Head;

        // 리스트 초기화
        public void ListInit()
        {
            Head = null;
        }

        // 리스트 데이터 삽입
        public void ListInsert(int value)
        {
            Node NewNode = new Node(value);
            if (Head == null)
            {
                Head = NewNode;
            }
            else
            {
                Node Current = Head;
                while (Current.GetNext() != null)
                {
                    Current = Current.GetNext();
                }
                Current.SetNext(NewNode);
            }
        }

        public void ListRemove(int index) // 0부터 시작하니까 당연히 길이가 7일때 7집어넣으면 오류남 ㅇㅇㅇ
                                          // 근데 0넣으면 왜 다지워지냐 ㅅㅂ
                                          // 아 0넣으면 previous가 이전값인데 없네
                                          // 그래서 if썻는데 모르겟다 안댐
        {
            int cnt = 0;

            Node Current = Head;
            Node Previous = Current;
            if (index == 0)
            {
                Current = Current.GetNext();
                Head = Current;
            }
            else
            {
                while (index != cnt)
                {
                    Previous = Current;
                    Current = Current.GetNext();
                    cnt++;
                }
                Previous.SetNext(Current.GetNext());
                Current.SetNext(null);
            }
        }

        // 리스트에 저장되어 있는 데이터 수를 반환
        public int ListCount()
        {
            int cnt = 0;
            if (Head == null)
            {
                return cnt;
            }
            else
            {
                Node Current = Head;
                while (Current.GetNext() != null)
                {
                    Current = Current.GetNext();
                    cnt++;
                }
            }
            return cnt + 1; // 0부터 시작하므로 길이는 +1
        }

        public void Print()
        {
            Console.Write("[");
            if (Head != null)
            {
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
            }
            Console.WriteLine("]");
        }

        public void Sorting()
        {
            int length = ListCount();
            int value1 = 0;
            int value2 = 0;

            Node Current = Head;
            Node Previous = Current;
            // while문 다돌고 current하고 previous를 초기화 시켜야 되서 집어넣음
            Node CurrentInit = Head;
            Node PreviousInit = Current;

            // 처음에 for문 2개 쓸려는데 안됨 그래서 while문으로 바꿈
            for (int j = 0; j < length; j++)
            {
                while (Current.GetNext() != null)
                {
                    Previous = Current;
                    Current = Current.GetNext();
                    value1 = Previous.GetValue();
                    value2 = Current.GetValue();
                    if (value1 > value2)
                    {
                        Previous.SetValue(value2);
                        Current.SetValue(value1);
                    }
                }
                Previous = PreviousInit;
                Current = CurrentInit;
            }
        }
    }
}