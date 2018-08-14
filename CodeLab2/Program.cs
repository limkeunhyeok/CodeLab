using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab2
{
    internal class Program
    {
        //-1은 타입 오류, -2는 타겟 오류
        private static void Main(string[] args)
        {
            SearchManager manager = new SearchManager();
            int[] arr = new int[10] { 1, 3, 5, 7, 8, 10, 11, 13, 14, 16 };
            Console.Write("type : ");
            int type = int.Parse(Console.ReadLine());
            Console.Write("target : ");
            int target = int.Parse(Console.ReadLine());
            int result = -1;

            LinearSearch searchType = new LinearSearch();
            manager.SetSearchMethod(searchType);
            result = manager.Search(arr, target);

            MySearch searchType2 = new MySearch();
            manager.SetSearchMethod(searchType2);
            result = manager.Search(arr, target);

            /*
                        if (type == 0)
                        {
                            result = manager.Search(arr, SortingType.LinearSearch, target);
                        }
                        else
                        {
                            result = manager.Search(arr, SortingType.BinarySearch, target);
                        }
                        if (result == -1)
                        {
                            Console.WriteLine("type을 잘못 입력");
                        }
                        else if (result == -2)
                        {
                            Console.WriteLine("target을 잘못 입력");
                        }
                        else
                        {
                            Console.WriteLine("index는 " + result);
                        }
                        */
        }
    }

    internal enum SortingType
    {
        LinearSearch, BinarySearch
    }

    public class SearchManager
    {
        private ArraySearch searchMethod;

        public void SetSearchMethod(ArraySearch method)
        {
            this.searchMethod = method;
        }

        // search type 선택 0은 선형탐색, 1은 이진탐색
        public int Search(int[] arr, int target)
        {
            return searchMethod.Search(arr, target);
        }
    }

    public interface ArraySearch
    {
        int Search(int[] arr, int target);
    }

    internal class MySearch : ArraySearch
    {
        public int Search(int[] arr, int target)
        {
            //~~~~~
            return 0;
        }
    }

    internal class LinearSearch : ArraySearch
    {
        public int Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -2;
        }
    }

    internal class BinarySearch : ArraySearch
    {
        public int Search(int[] arr, int target)
        {
            int first = 0;
            int last = arr.Length - 1;
            int mid = 0;

            while (first <= last)
            {
                mid = (first + last) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else
                {
                    if (arr[mid] > target)
                    {
                        last = mid - 1;
                    }
                    else
                    {
                        first = mid + 1;
                    }
                }
            }
            return -2;
        }
    }
}