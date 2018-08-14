using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab14
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Tree = new BinaryTree();
            Tree.TreeInsert(5);
            Tree.TreeInsert(5);
            Tree.TreeInsert(5);
            Tree.TreeInsert(5);
            Tree.TreeInsert(5);
            Tree.Print();

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
    class BinaryTree
    {
        private Node Root;
        private Node LeftNode;
        private Node RightNode;

        public void TreeInit()
        {
            Root = null;
        }

        public void TreeInsert(int value)
        {
            Node NewNode = new Node(value);
            if(Root == null)
            {
                Root = NewNode;
            }
            else
            {
                Node CurrentLeft = LeftNode;
                Node CurrentRight = RightNode;
                if(CurrentLeft == null)
                {
                    CurrentLeft = NewNode;
                }
                if(CurrentRight == null)
                {
                    CurrentRight = NewNode;
                }
            }
            
        }
        public void Print()
        {
            Console.WriteLine(Root.GetValue());
            Console.Write(LeftNode.GetValue());
            Console.WriteLine(RightNode.GetValue());

        }

    }
}
