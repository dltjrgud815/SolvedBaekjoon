using System.Text;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int tempint = Int32.Parse(Console.ReadLine());

        int cnt = 1;
        int sum = 1;
        int[] check = new int[]{1, 2, 3, 4, 5, 6};
        int[] result = new int[]{2, 3, 4, 5, 6, 7};


        while(sum < tempint)
        {
            for(int i = 0 ; i < 6; i++)
            {
                if(result[i] >= tempint)
                {
                    sum = result[i];
                    break;
                }
                check[i] = check[i] + 6;
                result[i] = result[i] + check[i];  
            }
            
            cnt ++;

        }
        System.Console.WriteLine(cnt);
    }
}