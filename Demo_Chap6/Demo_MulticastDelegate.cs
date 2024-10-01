using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Chap6
{
    public delegate void MyDelegate2(string msg);
    internal class Demo_MulticastDelegate
    {
        class MyClass1
        {
            public static void Print(string msg)
                => Console.WriteLine($"{msg.ToUpper()}");

            public static void Show(string msg)
                => Console.WriteLine($"{msg.ToLower()}");

            public static void Display(string msg)
                => Console.WriteLine($"{msg}");
        }

        class Demo_Multicast
        {

            static void Main(string[] args)
            {
                string msg = "Multiicast Delegate";
                MyDelegate2 MyDeLe1 = MyClass1.Print;
                MyDelegate2 MyDeLe2 = MyClass1.Show;
                Console.WriteLine("*** Combine MyDeLe1 + MyDeLe2 ***");
                MyDelegate2 MyDeLe = MyDeLe1 + MyDeLe2;
                MyDeLe(msg);
                Console.WriteLine("*** Combine MyDeLe1 + MyDeLe2 + MyDeLe3 ***");
                MyDelegate2 MyDeLe3 = MyClass1.Display;
                MyDeLe += MyDeLe3;
                MyDeLe(msg);
                Console.WriteLine("-------------------");
                Console.WriteLine("*** Remove MyDeLe2 ***");
                MyDeLe -= MyDeLe2;
                MyDeLe("Hello World !");
                Console.ReadLine();
            }
        }
    }
}
