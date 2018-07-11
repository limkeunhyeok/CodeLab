using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab5_7
{
    internal class Program
    {
        // 선택정렬, 배열안의 원소는 최소 100보다 다 작아야함
        private static void Main(string[] args)
        {
            int[] arr = new int[10] { 4, 10, 1, 5, 9, 2, 7, 6, 3, 2 };
            int[] result = SelectionSort(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(result[i] + " ");
            {
            }
        }

        public static int[] SelectionSort(int[] arr)
        {
            int length = arr.Length;
            int value1 = 100;
            int index = 0;
            for (int j = 0; j < length; j++)
            {
                // value1에 제일 작은 수가 들어감
                for (int i = j; i < length; i++)
                {
                    if (value1 > arr[i])
                    {
                        value1 = arr[i];
                        index = i;
                    }
                }

                // 제일 작은 수를 j번째 인덱스와 교환
                int value2 = arr[j];
                arr[index] = value2;
                arr[j] = value1;
                value1 = 100;
                index = 0;
            }
            return arr;
        }
    }
}