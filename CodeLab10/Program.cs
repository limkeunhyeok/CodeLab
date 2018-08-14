using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace CodeLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List stack = new List();
            Console.WriteLine(stack.IsEmpty());
            stack.Print();
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(7);
            Console.WriteLine(stack.IsEmpty());
            stack.Print();
            
            stack.Pop();
            int result = stack.Peek();
            Console.WriteLine(result);
            stack.Pop();
            result = stack.Peek();
            Console.WriteLine(result);
            stack.Pop();
            result = stack.Peek();
            Console.WriteLine(result);
            stack.Pop();
            Console.WriteLine(stack.IsEmpty());
            stack.Print();
            
        }
    }
}
