internal class Program
{
    private static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine());

        int[] x = new int[N];
        int[] y = new int[N];
        int[] countXY = new int[N];

        for(int i = 0; i < N ; i++)
        {
            string[] tempstr = Console.ReadLine().Split(' ');
            x[i] = Int32.Parse(tempstr[0]);
            y[i] = Int32.Parse(tempstr[1]);
        }

        for(int i = 0; i < N - 1; i ++)
        {
            for(int j = i; j < N; j++)
            {
                if((x[i] > x[j] && y[i] > y[j]) || (x[i] > x[j] && y[i] > y[j]))
                    countXY[j] ++;
                else if((x[i] >= x[j] && y[i] <= y[j]) || (x[i] <= x[j] && y[i] >= y[j]) || (x[i] == x[j] && y[i] == y[j]))
                {
                    //return;
                } 
                else 
                    countXY[i] ++;


            }
        }

        for(int i = 0 ; i < N; i++)
        {
            countXY[i] ++;
            if(i == N - 1)
                System.Console.Write(countXY[i]);
            else
                System.Console.Write(countXY[i] + " ");
        }
    }
}