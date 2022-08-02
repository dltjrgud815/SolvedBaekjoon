using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string tempstr = Console.ReadLine();
        string[] words = tempstr.Split(" ");

        int N = Int32.Parse(words[0]);
        int M = Int32.Parse(words[1]);

        tempstr = Console.ReadLine();
        words = tempstr.Split(" ");
        int sum = 0;
        int maxSum = 0;

        int[] Card = new int[N];
        for(int i = 0 ; i < N; i++)
        {
            Card[i] = Int32.Parse(words[i]);
        }

        for(int i = 0; i < N-2; i++)
        {
            for(int j = i + 1; j < N-1; j++ )
            {
                for(int k = j +1; k < N; k++)
                {
                    sum = Card[i] + Card[j] + Card[k];
                    if(sum <= M && maxSum <= sum)
                    {
                        maxSum = sum;
                    }
                    sum = 0;
                }
            }
        }

        System.Console.WriteLine(maxSum);
    }
}