using System;

namespace Delegate
{
    class Program
    {
        public static void Test(Action<int, int, int, int, int, int, int, int> runAfterWork)
        {
            runAfterWork(0, 1, 2, 3, 4, 5, 6, 7);
        }
        static void Main(string[] args)
        {
            Test(delegate { Console.WriteLine("Run after work"); });
            Console.ReadKey();
        }
    }
}
