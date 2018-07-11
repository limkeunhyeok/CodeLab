using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int j = 1;
            int i = 1;
            while (j <= 5)
            {
                while (i <= j)
                {
                    Console.Write("*");
                    i++;
                }
                i = 1;
                Console.WriteLine("/");
                j++;
            }
        }
    }
}