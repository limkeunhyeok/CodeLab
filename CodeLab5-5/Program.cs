using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab5_5
{
    internal class Program
    {
        // 문자열 자르기
        private static void Main(string[] args)
        {
            string str = "Hello World";
            Console.Write("어디에서 : ");
            int index1 = int.Parse(Console.ReadLine());
            Console.Write("어디까지 : ");
            int index2 = int.Parse(Console.ReadLine());
            Console.WriteLine(SliceString(str, index1, index2));
        }

        public static string SliceString(string str, int index1, int index2)
        {
            string text;

            text = str.Remove(0, index1);
            text = text.Remove(index2 - index1);
            return text;
        }
    }
}