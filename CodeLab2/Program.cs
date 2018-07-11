using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1~1000 3과 5의 배수의 합
            int i = 1;
            int sum = 0;
            while (i <= 1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}