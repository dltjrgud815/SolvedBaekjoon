internal class Program
{
    private static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine());
        int temp = 0;
        int[] number = new int[N];
        for(int i = 0; i < N; i++)
        {
            number[i] = Int32.Parse(Console.ReadLine());
        }

        for(int j = 0; j < N-1; j++)
        {
            for(int i = 0; i < N - 1 ; i++)
            {
                if(number[i] > number[i + 1])
                {
                    temp = number[i];
                    number[i] = number[i + 1];
                    number[i+1] = temp;
                }
            }
        }

        for(int i = 0; i < N; i++)
        {
            System.Console.WriteLine(number[i]);
        }


    }
}