using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.AddLast(3);
            list.AddLast(1);
            list.AddLast(5);
            list.AddLast(3);
            list.AddLast(7);
            list.AddLast(3);
            list.DeleteLast();
            list.PrintAll();
        }
    }

    internal class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public void AddLast(int value)
        {
            // 삽입할 노드 생성
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node curr = head;
                while (curr.GetNext() != null)
                {
                    curr = curr.GetNext();
                }

                curr.SetNext(newNode);
            }
        }

        public void DeleteLast()
        {
            // 지울게 없다면 그냥 종료
            if (head == null)
            {
                return;
            }
            else
            {
                Node curr = head;
                Node prev = curr;
                while (curr.GetNext() != null)
                {
                    prev = curr;
                    curr = curr.GetNext();
                }

                prev.SetNext(null);
            }
        }

        public void PrintAll()
        {
            Console.Write("[");
            if (head != null)
            {
                Node curr = head;
                Console.Write(curr.GetValue() + ", ");
                while (curr.GetNext() != null)
                {
                    curr = curr.GetNext();

                    if (curr.GetNext() == null)
                        Console.Write(curr.GetValue());
                    else
                        Console.Write(curr.GetValue() + ", ");
                }
            }
            Console.WriteLine("]");
        }

        public int Count()
        {
            int cnt = 0;
            if (head == null)
            {
                return cnt;
            }
            else
            {
                Node curr = head;
                while (curr.GetNext() != null)
                {
                    curr = curr.GetNext();
                    cnt++;
                }

                return cnt;
            }
        }
    }

    internal class Node
    {
        // Node 안에 실제 데이터가 저장되는 곳
        private int value;

        // Node 자료형을 접근할 수 있음
        private Node next;

        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        public Node GetNext()
        {
            return this.next;
        }

        public void SetNext(Node next)
        {
            this.next = next;
        }
    }
}