using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("person 객체 생성되기 전");
            Person person = new Person();
            Console.WriteLine("person 객체 생성");
        }
    }

    internal class Person
    {
        private string name;

        public Person()
        {
            name = "홍길동";
            Console.WriteLine("생성자 호출");
        }
    }
}