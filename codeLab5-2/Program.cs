using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeLab5_2
{
    internal class Program
    {
        // n번째로 큰 값 찾기
        private static void Main(string[] args)
        {
            int[] arr = new int[10] { 4, 10, 1, 5, 9, 2, 7, 6, 3, 2 };
            Console.WriteLine(SearchNthBigger(arr));
        }

        public static int SearchNthBigger(int[] arr)
        {
            Console.Write("n번째 값 : ");
            int n = int.Parse(Console.ReadLine());
            int value1;
            int value2;

            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i + 1] > arr[i])
                    {
                        value1 = arr[i + 1];
                        value2 = arr[i];
                        arr[i] = value1;
                        arr[i + 1] = value2;
                    }
                    else
                    {
                        value1 = arr[i];
                        value2 = arr[i + 1];
                        arr[i] = value1;
                        arr[i + 1] = value2;
                    }
                }
            }
            return arr[n - 1];
        }
    }
}