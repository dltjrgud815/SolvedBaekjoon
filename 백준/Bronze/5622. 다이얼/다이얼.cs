using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        string str = Console.ReadLine();
        sb.Append(str);

        int sum = 0;

        for(int i = 0; i < sb.Length; i++)
        {
            char temp = sb[i];
            if(temp < 'S')
                sum += ((temp - 'A') / 3) + 2;
            else if(temp == 'S')
                sum += 7;
            else if(temp > 'S' && temp < 'Z')
                sum += ((temp - 'T') / 3) + 8;
            else
                sum += 9;              
        }
        sum += sb.Length;
        System.Console.WriteLine(sum);

        
    }

}