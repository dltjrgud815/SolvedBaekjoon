using System.Text;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int tempint = Int32.Parse(Console.ReadLine());
        bool isOdd = false;

        int cnt = 0;
        int sum = 0;
        int num = 0;

        while(sum < tempint)
        {
            cnt++;
            sum += cnt;
            
        }
        num = (int)MathF.Abs(tempint - sum);
        if(cnt % 2 == 0)
            System.Console.WriteLine($"{cnt - num}/{num + 1}");
        else
            System.Console.WriteLine($"{num+1}/{cnt-num}");
    }
}