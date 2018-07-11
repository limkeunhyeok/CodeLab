using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab4_1
{
    internal class Program
    {
        //LinearSearch +@
        private static void Main(string[] args)
        {
            int[] arr = new int[10] { 4, 10, 1, 5, 9, 2, 7, 6, 3, 2 };
            int[] result = LinearSearch(arr);
            PrintArray(result);
        }

        public static int[] LinearSearch(int[] arr)
        {
            int[] array = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int j = 0;
            Console.Write("찾고 싶은 숫자 : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == num)
                {
                    array[j] = i;
                    j++;
                }
            }
            return array;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}