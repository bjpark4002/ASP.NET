using System;

namespace delegatePractice
{
    class Program
    {
        delegate void Test(int a, int b);

        public static void Sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} : {2}",a,b, a + b);
        }
        static public void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} : {2}", a, b ,a - b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test tem = new Test(Sum);
            tem(5, 10);
            tem = Sub;
            tem(10, 4);
        }


    }


}
