using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string temp = Console.ReadLine();
        string[] words = temp.Split(" ");

        int a = Int32.Parse(words[0]);
        int b = Int32.Parse(words[1]);
        int c = Int32.Parse(words[2]);
        long cnt = 1;

        if(b >= c)
        {
            cnt = -1;  
        }
        else
        {
            cnt = a/(c - b) + 1;
        }
    
        
        System.Console.WriteLine(cnt);
        
    }
}