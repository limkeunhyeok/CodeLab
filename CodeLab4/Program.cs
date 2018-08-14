using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SingletonClass manager = SingletonClass.GetInstance();
        }
    }

    internal class SingletonClass
    {
        private static SingletonClass instance = null;
        private int value;

        private SingletonClass()
        {
            value = 10;
        }

        public static SingletonClass GetInstance()
        {
            instance.value++;
            if (instance == null)
            {
                instance = new SingletonClass();
            }
            return instance;
        }
    }
}