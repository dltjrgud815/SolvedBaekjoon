using System;
using System.Text;

namespace baekjoon0809
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int i = (int)Math.Pow(2, N) - 1;
            Console.WriteLine(i);
            StringBuilder sb = new StringBuilder();
            move(sb, N, 1, 2, 3);
            Console.WriteLine(sb.ToString());

        }

        static void move(StringBuilder sb, int n, int st, int mid ,int en)
        {
            if (n == 1)
            {
                sb.AppendFormat("{0} {1}\n", st, en);
                return;
            }
            
            move(sb, n - 1, st, en, mid);
            sb.AppendFormat("{0} {1}\n", st, en);
            move(sb, n-1, mid, st, en);
            
        }
    }
}