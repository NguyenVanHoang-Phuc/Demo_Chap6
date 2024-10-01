namespace Demo_Chap6
{
    public delegate int MyDelegate(int numOne, int numTwo);

    public delegate void Message(string msg);
    class Demo_Delegate
    {
        static int Add(int numOne, int numTwo) => numOne + numTwo;
        static int Subtract(int numOne, int numTwo) => (numOne - numTwo);
        public static void Print(string msg) => Console.WriteLine(msg);

        private static void Main(string[] args)
        {
            int n1 = 25;
            int n2 = 15;
            int result;

            Message m = Print;


            MyDelegate obj1 = new MyDelegate(Add);

            result = obj1(n1, n2);

            Console.WriteLine(result);

            MyDelegate obj2 = Subtract;

            result = obj2.Invoke(n1, n2);

            Console.WriteLine(result);

            m("Sum :" + obj1(n1, n2));
        }
    }
}
