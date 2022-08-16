internal class Program
{
    private static void Main(string[] args)
    {
        string[] tempStr = Console.ReadLine().Split(' ');
        int N = Int32.Parse(tempStr[0]);
        int k = Int32.Parse(tempStr[1]);
        tempStr = Console.ReadLine().Split(' ');
        int[] number = new int[N];
        for(int i = 0; i < N; i++)
        {
            number[i] = Int32.Parse(tempStr[i]);
        }
        Array.Sort(number);
        Array.Reverse(number);

        System.Console.WriteLine(number[k - 1]);

    }
}