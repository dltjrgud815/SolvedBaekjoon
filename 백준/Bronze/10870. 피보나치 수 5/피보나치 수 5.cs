using System;

namespace BJ0805
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int result = fibonacci(n);
            Console.WriteLine(result);

        }

        public static int fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else if (n == 0)
                return 0;
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}