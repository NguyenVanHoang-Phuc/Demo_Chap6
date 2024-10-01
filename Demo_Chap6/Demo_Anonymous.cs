using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Chap6
{
    internal class Demo_Anonymous
    {
        public delegate void MyDeLe(int value);
        static void Main(string[] args)
        {
            MyDeLe printValue = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value {0}", val);
            };
            printValue += delegate
            {
                Console.WriteLine("This is Anonymous Method. ");
            };
            printValue(1000);
        }
    }
}
