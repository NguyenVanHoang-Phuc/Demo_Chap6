using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Chap6
{
    public delegate void MyDelegate1(string msg);
    internal class Demo_PassDelegate
    {
        class MyClass
        {
            public static void Print(string msg)
                => Console.WriteLine($"{msg.ToUpper()}");

            public static void Show(string msg)
                => Console.WriteLine($"{msg.ToLower()}");

        }

        class Program
        {
            static void InvokeDelegate(MyDelegate1 dele, string msg) => dele(msg);
            static void Main(string[] args)
            {
                string msg = "Passing Delegate as a Parameter";
                InvokeDelegate(MyClass.Print, msg);
                InvokeDelegate(MyClass.Show, msg);
                Console.ReadLine();
            }

        }
    }
}
