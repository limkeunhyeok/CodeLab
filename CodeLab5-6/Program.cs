using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab5_6
{
    internal class Program
    {
        // 문자열 합치기
        private static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(ConcatString(str1, str2));
        }

        public static string ConcatString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            char[] text = new char[length1 + length2];
            for (int i = 0; i < text.Length; i++)
            {
                if (i < length1)
                {
                    text[i] = str1[i];
                }
                else
                {
                    text[i] = str2[i - length1];
                }
            }
            return new string(text);
        }
    }
}