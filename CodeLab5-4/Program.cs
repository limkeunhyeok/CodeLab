using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab5_4
{
    internal class Program
    {
        // 문자열 뒤집기
        private static void Main(string[] args)
        {
            string str = "hello world";
            Console.WriteLine(ReverseString(str));
        }

        public static string ReverseString(string str)
        {
            char[] text = str.ToCharArray();

            for (int i = 0; i <= str.Length / 2; i++)
            {
                char temp1 = text[i];
                char temp2 = text[str.Length - 1 - i];
                text[i] = temp2;
                text[str.Length - 1 - i] = temp1;
            }
            return new string(text);
        }
    }
}