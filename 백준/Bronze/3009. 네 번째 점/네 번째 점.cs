internal class Program
{
    private static void Main(string[] args)
    {
        int[] posX = new int[1001];
        int[] posY = new int[1001];
        int resultX = 0;
        int resultY = 0;
        string[] tempStr;
        for(int i = 0; i < 3; i++)
        {
            tempStr = Console.ReadLine().Split(' ');
            posX[Int32.Parse(tempStr[0])]++;
            posY[Int32.Parse(tempStr[1])]++;
        }
        for(int i = 1; i < 1001; i++)
        {
            if(posX[i] == 1)
                resultX = i;
            if(posY[i] == 1)
                resultY = i;
        }

        System.Console.WriteLine($"{resultX} {resultY}");
    }
}