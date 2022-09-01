using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        int[] tempInt = new int[3];
        string[] tempStr;
        while (true)
        {
            int sum = 0;
            tempStr = Console.ReadLine().Split(' ');
            for(int i = 0; i < 3; i++)
            {
                tempInt[i] = (int)MathF.Pow(Int32.Parse(tempStr[i]), 2);
                sum += tempInt[i];
            }
            if(tempInt[0] + tempInt[1] + tempInt[2] == 0)
                break;
            
            int max = tempInt.Max();
            if(sum / 2 == max)
                sb.Append("right\n");
            else
                sb.Append("wrong\n");
            
        }

        System.Console.WriteLine(sb);
    }
}