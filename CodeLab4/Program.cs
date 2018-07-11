using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab4
{
    internal class Program
    {
        // LeanearSearch
        private static void Main(string[] args)
        {
            int[] arr = new int[10] { 4, 10, 1, 5, 9, 8, 7, 6, 3, 2 };
            int result = LinearSearch(arr);
            Console.WriteLine(result);
        }

        public static int LinearSearch(int[] arr)
        {
            Console.Write("찾고 싶은 숫자 : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}