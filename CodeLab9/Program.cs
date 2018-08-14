using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.ArrayStack(5);
            stack.Push(3);
            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            stack.Print();
            int result = stack.Peek();
            Console.WriteLine(result);

            stack.Pop();
            result = stack.Peek();
            Console.WriteLine(result);

            stack.Print();
        }
    }
    class Stack
    {
        private int length;
        private int count;
        private int[] stack;

        public int [] ArrayStack(int length)
        {
            stack = new int[length];
            return stack;

        }
        public void Push(int value)
        {
            stack[count] = value;
            count++;
        }
        public void  Pop()
        {
            stack[count - 1] = 0;
            count--;
        }
       
        public int Peek()
        {
            return stack[count - 1];
        }
        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < stack.Length; i++)
            {
                Console.Write(stack[i] + " ,");
            }
            Console.WriteLine("]");
        }
    }
}
