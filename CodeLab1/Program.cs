using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 구구단
            for (int j = 2; j <= 9; j++)
            {
                Console.WriteLine(j + "단");
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine(j + " * " + i + " = " + j * i);
                }
                Console.WriteLine();
            }
        }
    }
}