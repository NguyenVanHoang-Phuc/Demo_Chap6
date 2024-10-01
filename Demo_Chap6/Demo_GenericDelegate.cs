using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Chap6
{
    internal class Demo_GenericDelegate
    {
        static int Sum(int x, int y) => x + y;
        static void Print(string msg) => Console.WriteLine(msg.ToUpper());
        static void Main(string[] args)
        {
            int a = 15; int b = 25; int s;
            string strResult;
            Func<int, int, int> sumFunc = Sum;
            s = sumFunc(a, b);
            strResult = $"{a} + {b} = {s}";
            Console.WriteLine("***** Invoke Print method by action delegate");
            Action<string> action = Print;
            action(strResult);
            Console.ReadLine();
        }
    }
}
