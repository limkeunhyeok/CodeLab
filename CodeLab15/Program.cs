using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeLab15
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRecursion test = new MyRecursion();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine("50! = " + test.NoFibonacci(40));

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine("50! = " + test.Fibonacci(45));

            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        
    }
    class MyRecursion
    {
        // 기본 예시
        public void Recursion(int num)
        {
            if (num <= 0)
            {
                return;
            }
            Console.WriteLine("NUM = " + num);
            Recursion(num - 1);

        }
        // 재귀를 이용한 팩토리얼
        public long Factorial(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
        // 재귀를 이용하지 않은 팩토리얼
        public long NoFactorial(int num)
        {
            long result = 1;
            if (num == 0)
            {
                return 1;
            }
            for(int i = 1; i <= num; i++)
            {
                result = result * i;
            }
            return result;
        }
        // 재귀를 이용한 피보나치
        public long Fibonacci(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            if(num == 2)
            {
                return 1;
            }
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
        // 재귀를 이용하지 않은 피보나치
        public long NoFibonacci(int num)
        {
            long value1 = 0;
            long value2 = 1;
            long result = 0;

            if (num == 1) return 1;

            for (int i = 1; i < num; i++)
            {
                result = value1 + value2;
                value1 = value2;
                value2 = result;
            }
            return result;
        }
    }
}