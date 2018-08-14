using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SortingManager manager = new SortingManager();
            int[] arr = new int[10] { 6, 2, 1, 7, 4, 8, 10, 3, 6, 14 };
            Console.Write("type : ");
            int num = int.Parse(Console.ReadLine());
            int[] orderedData = manager.Sorting(arr, num); // 선택 정렬로 정렬
            for (int i = 0; i < orderedData.Length; i++)
            { // 제대로 정렬되었는지
                Console.Write(orderedData[i] + " ");
            }
        }
    }

    internal class SortingManager
    {
        public int[] Sorting(int[] arr, int type)
        {
            if (type == 0)
            {
                return SelectionSorting(arr);
            }
            else if (type == 1)
            {
                return BubbleSorting(arr, new Decendant());
            }
            else if (type == 2)
            {
                return InsertionSorting(arr);
            }
            else
            {
                Console.WriteLine("정렬 타입은 0(선택), 1(버블), 2(삽입) 중에 고르세요");
                return null;
            }
        }

        private int[] SelectionSorting(int[] arr)
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

        private int[] BubbleSorting(int[] arr, Comparator comparer)
        {
            int value1;
            int value2;

            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (comparer.Compare(arr[i + 1], arr[i]))
                    {
                        value1 = arr[i + 1];
                        value2 = arr[i];
                        arr[i] = value1;
                        arr[i + 1] = value2;
                    }
                }
            }
            return arr;
        }

        private int[] InsertionSorting(int[] arr)
        {
            int value1;
            int value2;
            int index;
            for (int j = 0; j < arr.Length; j++)
            {
                index = j;
                for (int i = j; i >= 0; i--)
                {
                    if (arr[index] < arr[i])
                    {
                        value1 = arr[index];
                        value2 = arr[i];
                        arr[i] = value1;
                        arr[index] = value2;
                        index = i;
                    }
                }
            }
            return arr;
        }
    }

    internal interface Comparator
    {
        bool Compare(int a, int b);
    }

    internal class Asendant : Comparator
    {
        public bool Compare(int a, int b)
        {
            if (a > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class Decendant : Comparator
    {
        public bool Compare(int a, int b)
        {
            if (a > b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}