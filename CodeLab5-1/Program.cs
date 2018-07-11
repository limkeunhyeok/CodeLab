using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab5_1
{
    internal class Program
    {
        // 정수형 배열이 주어졌을 때 최대/최소 값 찾기
        // 단 배열안의 값은 0~100 사이의 값이 여야함
        private static void Main(string[] args)
        {
            int[] arr = new int[10] { 4, 10, 1, 5, 9, 12, 7, 6, 3, 2 };
            int MaxVauleIndex = MaxIndex(arr);
            int MinVauleIndex = MinIndex(arr);
            int MaxValue = arr[MaxVauleIndex];
            int MinValue = arr[MinVauleIndex];
            Console.Write("최댓값 : " + MaxValue);
            Console.WriteLine("   인덱스값 : " + MaxVauleIndex);
            Console.Write("최솟값 : " + MinValue);
            Console.WriteLine("   인덱스값 : " + MinVauleIndex);
        }

        public static int MaxIndex(int[] arr)
        {
            int index = 0;
            int value = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (value < arr[i])
                {
                    value = arr[i];
                    index = i;
                }
            }
            return index;
        }

        public static int MinIndex(int[] arr)
        {
            int index = 0;
            int value = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                if (value > arr[i])
                {
                    value = arr[i];
                    index = i;
                }
            }
            return index;
        }

        public static int MinIndex2(int[] arr)
        {
            int minValue = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}