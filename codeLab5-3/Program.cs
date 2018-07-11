using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeLab5_3
{
    internal class Program
    {
        // 두 원소의 위치 바꾸기
        private static void Main(string[] args)
        {
            int[] arr = new int[10] { 4, 10, 1, 5, 9, 12, 7, 6, 3, 2 };
            Console.Write("n1 값 : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("n2 값 : ");
            int n2 = int.Parse(Console.ReadLine());

            Swap(arr, n1, n2);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Swap(int[] arr, int n1, int n2)
        {
            int value1 = arr[n1];
            int value2 = arr[n2];
            arr[n1] = value2;
            arr[n2] = value1;
        }
    }
}